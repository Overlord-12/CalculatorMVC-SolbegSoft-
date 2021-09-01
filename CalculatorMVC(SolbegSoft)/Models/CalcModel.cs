using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculatorMVC_SolbegSoft_.Models
{
    public class CalcModel
    {
        public string Example { get; set; }
        public string Exeption { get; set; }

       public static double Calculation(CalcModel calc,double firsNumb, double secondNumb, char oper)
       {
            switch (oper)
            {
                case '+':
                    return firsNumb + secondNumb;
                case '-':
                    return firsNumb - secondNumb;
                case '*':
                    return firsNumb * secondNumb;
                case '/':
                    if (firsNumb == 0)
                    {
                        calc.Exeption = "You can't divide it by zero";
                        return 0;
                    }
                    return firsNumb / secondNumb;
                default:
                    Console.WriteLine("Exeption");
                    return 0;
            }
       }

    }
}