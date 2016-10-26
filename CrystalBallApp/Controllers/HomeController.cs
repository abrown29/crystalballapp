using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrystalBallApp.Models;

namespace CrystalBallApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult ShakeBall()
        {
            CrystalBall ball = new CrystalBall();
            string reply = ball.getResponse();
            return Json(reply, JsonRequestBehavior.AllowGet);
        }
    }
}