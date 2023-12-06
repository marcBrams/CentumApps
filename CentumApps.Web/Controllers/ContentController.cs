using CentumApps.Domain.Entities;
using CentumApps.Infastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace CentumApps.Web.Controllers
{
    public class ContentController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ContentController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var contents = _db.Contents.ToList();
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
                _db.Contents.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index", "Content");
            }
            return View();
        }

        public IActionResult Update(int contentId)
        {
            Content? obj = _db.Contents.FirstOrDefault(u => u.ContentId == contentId);
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
                _db.Contents.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        /* delete data */
        public IActionResult Delete(int contentId)
        {
            Content? obj = _db.Contents.FirstOrDefault(u => u.ContentId == contentId);
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
            Content? objFromDb = _db.Contents.FirstOrDefault(u => u.ContentId == obj.ContentId);
            /* update data to db based on id*/
            if (objFromDb is not null)
            {
                _db.Contents.Remove(objFromDb);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
