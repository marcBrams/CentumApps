using CentumApps.Application.Common.Interfaces;
using CentumApps.Domain.Entities;
using CentumApps.Infastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace CentumApps.Web.Controllers
{
    public class ContentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ContentController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var contents = _unitOfWork.Content.GetAll();
            return View(contents);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Content obj)
        {
            if (ModelState.IsValid)
            {
                obj.IsActive = true;
                _unitOfWork.Content.Add(obj);
                _unitOfWork.Content.Save();
                return RedirectToAction("Index", "Content");
            }
            return View();
        }

        public IActionResult Update(int contentId)
        {
            Content? obj = _unitOfWork.Content.Get(u => u.ContentId == contentId);
            /* get data by find primary key */
            /*Villa? objByFind = _db.Villas.Find(villaId);*/

            //var ContentList = _db.Contents.Where(u => u.Price > 50 && u.Occupancy > 0);
            /* error handling if id not found*/
            if (obj == null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(obj);
        }

        [HttpPost]
        public IActionResult Update(Content obj)
        {
            /* update data to db based on id*/
            if (ModelState.IsValid)
            {
                _unitOfWork.Content.Update(obj);
                _unitOfWork.Content.Save();
                return RedirectToAction("Index");
            }
            return View();
        }

        /* delete data */
        public IActionResult Delete(int contentId)
        {
            Content? obj = _unitOfWork.Content.Get(u => u.ContentId == contentId);
            /* get data by find primary key */
            /*Villa? objByFind = _db.Villas.Find(villaId);*/

            /* error handling if id not found*/
            if (obj is null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(obj);
        }

        [HttpPost]
        public IActionResult Delete(Content obj)
        {
            Content? objFromDb = _unitOfWork.Content.Get(u => u.ContentId == obj.ContentId);
            /* update data to db based on id*/
            if (objFromDb is not null)
            {
                _unitOfWork.Content.Remove(objFromDb);
                _unitOfWork.Content.Save();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
