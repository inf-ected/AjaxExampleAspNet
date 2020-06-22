using AjaxExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxExample.Controllers
{
    public class DogController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        // GET: Dog
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateDog(Dog dog)
        {
            context.Dogs.Add(dog);
            context.SaveChanges();
            string message = "Succes";
            return Json(new { Message = message, JsonRequestBehavior.AllowGet });
        }

        public JsonResult GetDogById(string id)
        {
            var dog = context.Dogs.FirstOrDefault(x => x.Id == int.Parse(id));
            return Json(dog, JsonRequestBehavior.AllowGet );

        }
        public JsonResult GetDogs()
        {
            var dog = context.Dogs.ToList();
            return Json(dog, JsonRequestBehavior.AllowGet);

        }
    }
}