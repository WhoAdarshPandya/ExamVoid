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
            SqlPojo.insertFood("biryani", "rice", "150", "true");

            return View();
        }

        public ActionResult GetAllItems()
        {
            SqlPojo.getAllFoodItemsInDb();
            return View();
        }

        public ActionResult DeleteItem()
        {
            SqlPojo.DeleteTheItem("3");
            return View();
        }
        
        public ActionResult UpdateItem()
        {
            SqlPojo.UpdateTheItem("5", "hakka nodules", "chaines", "180", "false");
            return View();
        }
    }
}