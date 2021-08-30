using CalculatorMVC_SolbegSoft_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculatorMVC_SolbegSoft_.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View(new CalcModel());
        }


        [HttpPost]
        public  ActionResult Index(CalcModel calc,string operation)
        {
            if (operation == "plus") calc.Total = calc.FirstNumb + calc.SecondNumb;
            if (operation == "minus") calc.Total = calc.FirstNumb - calc.SecondNumb;
            if (operation == "miltiply") calc.Total = calc.FirstNumb * calc.SecondNumb;
            if (operation == "division") calc.Total = calc.FirstNumb / calc.SecondNumb;
            return View(calc);
        }
    }
}