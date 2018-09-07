using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLib
{
    public interface IFuncs
    {
        decimal RubToUsd(decimal r);
        decimal UsdToRub(decimal d);
        decimal UserCourse(decimal user_course, decimal d);
    }
}
