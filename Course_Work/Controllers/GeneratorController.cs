using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Course_Work.Models;

namespace Course_Work.Controllers
{
    public class GeneratorController : Controller
    {
        //
        // GET: /Generator/
        public ActionResult Input()
        {
            Generator InputData = new Generator();
            return View();
        }
        [HttpPost]
        public ActionResult Input(Generator g)
        {
            Generator.amount_versh = g.amount_ver;
            Generator.amont_reb = g.amount_r;
            Generator.generator(Generator.amount_versh, Generator.amont_reb);
            return View();
        }
	}
}