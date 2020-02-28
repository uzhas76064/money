using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ValuteParser;

namespace DataLib
{
    public class Funcs : Variables, IFuncs
    {
        UsdParser Parser = new UsdParser();

        public decimal RubToUsd(decimal r)
        {
            USD = Math.Round(1 / Parser.UsdXmlToDecimal(), 3);
            RUB = r;
            return checked(USD * r);
        }

        public decimal UsdToRub(decimal d)
        {

            RUB = Parser.UsdXmlToDecimal();
            USD = d;
            return checked(RUB * d);
        }

        public decimal UserCourse(decimal user_course, decimal d)
        {
            RUB = user_course;
            USD = d;

            return checked(RUB * USD);
        }
    }
}
