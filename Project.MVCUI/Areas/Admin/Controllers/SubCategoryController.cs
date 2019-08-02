using Project.BLL.ConcreteRepository;
using Project.MODEL.Entities;
using Project.TOOLS.CustomTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Project.MVCUI.Areas.Admin.Controllers
{
    public class SubCategoryController : Controller
    {
        SubCategoryRepository sc_rep;
        CategoryRepository cat_rep;
        public SubCategoryController()
        {
            sc_rep = new SubCategoryRepository();
            cat_rep = new CategoryRepository();
        }
        // GET: Admin/SubCategory
        public ActionResult SubCategoryList()
        {
            
            return View(sc_rep.SelectActives());
        }
        public ActionResult SubCategoryDetail(int id)
        {
            return View(sc_rep.GetByID(id));
        }
        public ActionResult AddSubCategory()
        {
            return View(Tuple.Create(cat_rep.SelectActives(), new SubCategory()));
        }
        [HttpPost]
        public ActionResult AddSubCategory([Bind(Prefix ="item2")]SubCategory item,HttpPostedFileBase resim)
        {
            item.ImagePath = ImageUploader.UploadImage("~/Pictures/", resim);
            sc_rep.Add(item);
            return RedirectToAction("SubCategoryList");

        }
        public ActionResult DeleteSubCategory(int id)
        {
            sc_rep.Delete(sc_rep.GetByID(id));
            return RedirectToAction("SubCategoryList");
        }
        
        public ActionResult UpdateSubCategory(int id)
        {
            return View(Tuple.Create(cat_rep.SelectActives(), sc_rep.GetByID(id)));
        }
        [HttpPost]
        public ActionResult UpdateSubCategory([Bind(Prefix ="item2")]SubCategory item , HttpPostedFileBase resim, string resimSil)
        {
            if (resimSil=="true")
            {
                item.ImagePath = "Dosya Boş";
            }
            else
            {
                if (resim==null)
                {
                    SubCategory tempSubCategory = sc_rep.GetByID(item.ID);
                    item.ImagePath = tempSubCategory.ImagePath;
                }
                else
                {
                    item.ImagePath = ImageUploader.UploadImage("/Pictures/", resim);
                }
            }
            sc_rep.Update(item);
            return RedirectToAction("SubCategoryList");
        }


    }
}