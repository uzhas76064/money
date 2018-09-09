using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLib.Tests
{
    [TestClass()]
    public class FuncsTests
    {
        [TestMethod()]
        public void RubToUsdTest()
        {
            decimal r = 10;
            decimal expected = 0.015M;

            Funcs funcs = new Funcs();

            decimal actual = funcs.RubToUsd(r);
            funcs = null;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void UsdToRubTest()
        {
            decimal d = 10;
            decimal expected = 675.2M;

            Funcs funcs = new Funcs();

            decimal actual = funcs.UsdToRub(d);
            funcs = null;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void UserCourseTest()
        {
            decimal userCourse = 20;
            decimal d = 10;
            decimal expected = 200;

            Funcs funcs = new Funcs();

            decimal actual = funcs.UserCourse(userCourse, d);
            funcs = null;
            Assert.AreEqual(actual, expected);
        }
    }
}