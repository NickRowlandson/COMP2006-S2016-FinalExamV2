using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

/**
 * Author's	name: Nicholas Rowlandson   
 * Student Number: 200167125
 * Date	Modified: Thursday, August 18th, 2016
 * Version: 0.0.1
 * File: HomeController.cs
 * Description: This controller is used to manage the home page
 */
namespace COMP2006_S2016_FinalExamV2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}