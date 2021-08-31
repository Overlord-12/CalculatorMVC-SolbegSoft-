using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculatorMVC_SolbegSoft_.Models
{
    public class CalcModel
    {
        public string Example { get; set; }

       public static double Calculation(double firsNumb, double secondNumb, char oper)
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
                        Console.WriteLine("На ноль делить нельзя");
                        return 0;
                    }
                    return firsNumb / secondNumb;
                default:
                    Console.WriteLine("Ошибка");
                    return 0;
            }
       }

    }
}