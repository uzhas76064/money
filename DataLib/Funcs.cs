using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DataLib
{
    public class Funcs : Variables, IFuncs
    {
        public decimal RubToUsd(decimal r)
        {
            USD = 0.0015M;
            RUB = r;
            return checked(USD * r);

        }

        public decimal UsdToRub(decimal d)
        {
           
            RUB = 67.52M;
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
