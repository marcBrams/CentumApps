using CentumApps.Application.Common.Interfaces;
using CentumApps.Domain.Entities;
using CentumApps.Infastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace CentumApps.Web.Controllers
{
    public class CDUController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public CDUController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var data = _unitOfWork.CDU.GetAll();
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CDU_100 obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.CDU.Add(obj);
                _unitOfWork.CDU.Save();
                return RedirectToAction("Index", "ShiftReport");
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

                // upload image logic
                if (obj.Image != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(obj.Image.FileName);
                    string imagePath = Path.Combine(_webHostEnvironment.WebRootPath, @"images\VisualManagementContent");

                    if (!string.IsNullOrEmpty(obj.ImageUrl))
                    {
                        var oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, obj.ImageUrl.TrimStart('\\'));

                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }

                    using (var fileStream = new FileStream(Path.Combine(imagePath, fileName), FileMode.Create))
                    {
                        obj.Image.CopyTo(fileStream);
                    }

                    obj.ImageUrl = @"\images\VisualManagementContent\" + fileName;
                }

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

                if (!string.IsNullOrEmpty(objFromDb.ImageUrl))
                {
                    var oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, objFromDb.ImageUrl.TrimStart('\\'));

                    if (System.IO.File.Exists(oldImagePath))
                    {
                        System.IO.File.Delete(oldImagePath);
                    }
                }

                _unitOfWork.Content.Remove(objFromDb);
                _unitOfWork.Content.Save();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
