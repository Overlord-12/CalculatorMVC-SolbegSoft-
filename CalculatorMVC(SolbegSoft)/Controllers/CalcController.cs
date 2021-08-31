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
        public ActionResult Index(CalcModel calc, string calculate)
        {
            if(calculate == "calc")
            {
                char[] сharList = { '+', '-', '*', '/', 'C' };
                var input = calc.Example;
                char oper = сharList.First(input.Contains);
                if (oper == 'C' || oper == 'С')
                {
                    calc.Example = "";
                }
                double[] nums = input.Split(сharList.ToArray())
                    .Select(double.Parse)
                    .ToArray();

                calc.Example = Convert.ToString(CalcModel.Calculation(nums[0], nums[1], oper));
                var test = CalcModel.Calculation(nums[0], nums[1], oper);

                return View(calc);
            }
            else
            {
                if (calculate == "clear")
                {
                    calc.Example = "";
                    return View(calc);
                }
                calc.Example += calculate;
                    return View(calc);
            }
           
        }
      
    }
}