using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Course_Work.Models;

namespace Course_Work.Controllers
{
    public class AlgoritmController : Controller
    {
        //
        // GET: /Algoritm/
        public ActionResult Input()
        {
            Algoritm InputData = new Algoritm();
            return View();
        }
        [HttpPost]
        public ActionResult Input(Algoritm alg)
        {
            Matrix InputData = new Matrix();
            Matrix.ReadFile();
            Matrix.zero_matr();
            for (int i = 0; i < Matrix.amount_ver; i++)
                for (int j = 0; j < Matrix.amount_ver; j++)
                {
                    if (i != j)
                    {


                        double kfhb = (Matrix.all_versh(i, j) - Matrix.ob_versh(i, j)) / (Matrix.all_versh(i, j) + Matrix.ob_versh(i, j));
                        double kdfudsu = Matrix.all_versh(i, j) - Matrix.ob_versh(i, j);
                        double ksauhawiud = Matrix.all_versh(i, j) + Matrix.ob_versh(i, j);
                        double sdufhaieush = Math.Round(kdfudsu / ksauhawiud, 3);
                        Matrix.road_l[i][j] = sdufhaieush;
                    }
                }
            //ViewBag.Answer = alg.Variables;

            Algoritm.amountVersionInFirstPD = alg.Variables;
            Algoritm.PodgrafTwo();
            Algoritm.sumr();
            return View();
        }
	}
}