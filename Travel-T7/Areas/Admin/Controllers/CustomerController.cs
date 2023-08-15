using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_T7.Models;
using Travel_T7.Models.EF;
namespace Travel_T7.Areas.Admin.Controllers
{
    public class CustomerController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/Customer
        public ActionResult Index(int? page, string searchtext)
        {
            var pageSize = 8;
            if(page == null)
            {
                page = 1;
            }
            IEnumerable<KhachHang> items = db.KhachHangs.OrderByDescending(x => x.Id);
            if (!string.IsNullOrEmpty(searchtext))
            {
                items = items.Where(x =>    x.FirstName.Contains(searchtext) ||
                                            x.LastName.Contains(searchtext) ||
                                            x.Telephone.Contains(searchtext));
            }
            var pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            items = items.ToPagedList(pageSize, pageIndex);
            ViewBag.pageSize = pageSize;
            ViewBag.page = page;
            return View(items);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(KhachHang model)
        {
            if(ModelState.IsValid)
            {
                db.KhachHangs.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var item = db.KhachHangs.Find(id);
            return View(item);
        }
        [HttpPost]
        public ActionResult Edit(KhachHang model) 
        {
        
            if (ModelState.IsValid)
            {
                db.KhachHangs.Attach(model);
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

    }
}