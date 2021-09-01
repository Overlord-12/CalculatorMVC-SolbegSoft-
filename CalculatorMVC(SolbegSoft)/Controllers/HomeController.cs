using CalculatorMVC_SolbegSoft_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculatorMVC_SolbegSoft_.Controllers
{
    public class HomeController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View(new CalcModel());
        }


        [HttpPost]
        public ActionResult Index(CalcModel calc)
        {
            try
            {
                char[] сharList = { '+', '-', '*', '/', 'C' };
                var input = calc.Example.Replace(".",",");
                char oper = сharList.First(input.Contains);
                if (oper == 'C' || oper == 'С')
                {
                    calc.Example = "";
                }
                double[] nums = input.Split(сharList.ToArray())
                    .Select(double.Parse)
                    .ToArray();

                calc.Example = Convert.ToString(CalcModel.Calculation(nums[0], nums[1], oper));
                return View(calc);
            }
            catch(Exception)
            {
                calc.Example = "Execution error";
                return View(calc);
            }
                


        }
    }
}