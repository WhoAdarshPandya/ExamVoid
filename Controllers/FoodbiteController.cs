using ExamVoid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamVoid.Controllers
{
    public class FoodbiteController : Controller
    {
        // GET: Foodbite
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Insert()
        {

            return View();
        }

        public ActionResult GetAllItems()
        {
            List<Food> foodList = SqlPojo.getAllFoodItemsInDb();
            return View(foodList);
        }

        public ActionResult DeleteItem()
        {
            return View();
        }
        
        public ActionResult UpdateItem()
        {
            return View();
        }

        public ActionResult InsertTheFood(Food f)
        {
            SqlPojo.insertFood(f.name, f.category, f.price, f.avail);
            return RedirectToAction("GetAllItems");
        }

        public ActionResult DeleteTheItem(deleteModel d)
        {
            SqlPojo.DeleteTheItem(d.id);
            return RedirectToAction("GetAllItems");
        }

        public ActionResult UpdateTheItem(Food f)
        {
            SqlPojo.UpdateTheItem(f.id.ToString(), f.name, f.category, f.price, f.avail);
            return RedirectToAction("GetAllItems");
        }
    }
}