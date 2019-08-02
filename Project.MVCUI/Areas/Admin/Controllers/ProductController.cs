using Project.BLL.ConcreteRepository;
using Project.MODEL;
using Project.MODEL.Entities;
using Project.TOOLS.CustomTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        CategoryRepository cat_rep;
        ProductRepository p_rep;
        SubCategoryRepository s_rep;
        public ProductController()
        {
            cat_rep = new CategoryRepository();
            p_rep = new ProductRepository();
            s_rep = new SubCategoryRepository();
        }
        // GET: Admin/Product
        public ActionResult ProductList()
        {
            return View(p_rep.SelectActives());
        }
        public ActionResult AddProduct()
        {
            return View(Tuple.Create(cat_rep.SelectActives(), s_rep.SelectActives(), new Product()));
        }
        [HttpPost]
        public ActionResult AddProduct([Bind(Prefix ="item3")]Product item3,[Bind(Prefix="item2")]SubCategory item2,[Bind(Prefix ="item1")]Category item1 , HttpPostedFileBase resim,string yayindami)
        {
            
            if (yayindami=="true")
            {
                item3.IsAvailable = true;
            }
            else
            {
                item3.IsAvailable = false;
            }
          
            //todo
            
           
            //{

            //    ViewBag.Secim = "Lütfen Kategori veya Alt Kategori seçimi yapınız";
            //    return View(ViewBag.Secim);
            //}


            item3.ImagePath = ImageUploader.UploadImage("~/Pictures/", resim);
            p_rep.Add(item3);
            return RedirectToAction("ProductList");

        }
        public ActionResult DeleteProduct(int id)
        {
            p_rep.Delete(p_rep.GetByID(id));
            return RedirectToAction("ProductList");
        }
        public ActionResult UpdateProduct(int id)
        {
            return View(Tuple.Create(cat_rep.SelectActives(),s_rep.SelectActives(), p_rep.GetByID(id)));
        }
        [HttpPost]
        public ActionResult UpdateProduct([Bind(Prefix = "item3")]Product item, HttpPostedFileBase resim, string resimSil)
        {
            if (resimSil == "true")
            {
                item.ImagePath = "Dosya Boş";
            }
            else
            {
                if (resim == null)
                {
                    Product tempSubCategory = p_rep.GetByID(item.ID);
                    item.ImagePath = tempSubCategory.ImagePath;
                }
                else
                {
                    item.ImagePath = ImageUploader.UploadImage("/Pictures/", resim);
                }
            }
            p_rep.Update(item);
            return RedirectToAction("ProductList");
        }

        public ActionResult ProductDetail(int id)
        {
            return View(p_rep.GetByID(id));
        }

    }
}