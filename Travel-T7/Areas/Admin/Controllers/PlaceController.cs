using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using Travel_T7.Models;
using Travel_T7.Models.EF;


namespace Travel_T7.Areas.Admin.Controllers
{
    
    public class PlaceController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/Place
        public ActionResult Index(int? page, string searchtext)
        {
            var pageSize = 5;
            if (page == null)
            {
                page = 1;
            }
            IEnumerable<Place> items = db.Places.OrderByDescending(x => x.Id);
            if (!string.IsNullOrEmpty(searchtext))
            {
                items = items.Where(x => x.Name.Contains(searchtext));
            }
            var pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;   
             items = items.ToPagedList(pageIndex,pageSize);
            ViewBag.pageSize = pageSize;
            ViewBag.page = page;
            return View(items);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Place model) { 
            if (ModelState.IsValid)
            {
                db.Places.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item = db.Places.Find(id);
            if(item != null)
            {
                db.Places.Remove(item);
                db.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var item = db.Places.Find(id);
            return View(item);
        }
        public ActionResult Edit(Place model) {
            if(ModelState.IsValid)
            {
                db.Places.Attach(model);
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}