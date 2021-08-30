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
        public  ActionResult Index(CalcModel calc,string calculate)
        {
            if (calculate == "plus")
            {
                calc.Total = calc.FirstNumb + calc.SecondNumb;
                calc.FirstNumb = calc.Total;
            }
            if (calculate == "minus")
            {
                calc.Total = calc.FirstNumb - calc.SecondNumb;
                calc.FirstNumb = calc.Total;
            }
            if (calculate == "miltiply")
            {
                calc.Total = calc.FirstNumb * calc.SecondNumb;
                calc.FirstNumb = calc.Total;
            }
            if (calculate == "division")
            {
                calc.Total = calc.FirstNumb / calc.SecondNumb;
                calc.FirstNumb = calc.Total;
            }
            if(calculate == "clear")
            {
                calc.Total = 0;
                calc.FirstNumb = 0;
                calc.SecondNumb = 0;
            }
               
            return View(calc);
        }
    }
}