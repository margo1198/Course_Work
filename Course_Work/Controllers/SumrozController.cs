using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Course_Work.Models;

namespace Course_Work.Controllers
{
    public class SumrozController : Controller
    {
        //
        // GET: /Sumroz/
        public ActionResult Input()
        {
            Sumroz InputData = new Sumroz();
            Sumroz.ReadFile();
            return View();
        }
	}
}