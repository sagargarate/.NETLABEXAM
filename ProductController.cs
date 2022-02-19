using LabExam.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabExam.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            using (Model1 dbmodel = new Model1())
                return View(dbmodel.Products.ToList());
        }

        //Get

        public ActionResult Edit(int id)
        {
            using (Model1 dbmodel = new Model1())
            {
                return View(dbmodel.Products.Where( x => x.ProductId == id).FirstOrDefault());
            }
        }

        //Post

        public ActionResult Edit(int id,Product product)
        {
            try
            {
                using (Model1 dbmodel = new Model1())
                {
                    dbmodel.Entry(product).State = EntityState.Modified;
                    dbmodel.SaveChanges();
                }
                return RedirectToAction("Index");
            }

            catch
            {
                return View();
            }
        }
    }
}