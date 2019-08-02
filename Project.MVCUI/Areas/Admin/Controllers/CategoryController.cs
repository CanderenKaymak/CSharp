using Project.BLL.ConcreteRepository;
using Project.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository cat_rep = new CategoryRepository();
        // GET: Admin/Category
        public ActionResult CategoryList()
        {
            return View(cat_rep.SelectActives());
        }
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category item)
        {
            cat_rep.Add(item);
            return RedirectToAction("CategoryList");
        }
        public ActionResult UpdateCategory(int id)
        {
            return View(cat_rep.GetByID(id));
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category item)
        {
            cat_rep.Update(item);

            return RedirectToAction("CategoryList");
        }
        public ActionResult DeleteCategory(int id)
        {
            cat_rep.Delete(cat_rep.GetByID(id));
            return RedirectToAction("CategoryList");
        }
        public ActionResult CategoryDetail(int id)
        {
            return View(cat_rep.GetByID(id));
        }
    }
}