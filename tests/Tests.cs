﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

<<<<<<< HEAD
using RectangleProject.Models;

namespace RectangleProject.Tests
=======
namespace gyak_01_02_01_Maze.Tests
>>>>>>> f384c7da00e3b2e8eb3bd3c9d5bde9bbd693350a
{
    [TestClass()]
    public class Tests
    {
        [TestMethod()]
        public void Test()
        {
<<<<<<< HEAD
            Rectangle r = new Rectangle(4.25,7.34);
            double expectedSideA = 4.25;
            double actualSideA = r.SideA;
            Assert.AreEqual(expectedSideA, actualSideA, "A Négyzet konstruktora nem jól határozza meg az egyik oldalt!");

            double expectedSideB = 7.34;
            double actualSideB = r.SideB;
            Assert.AreEqual(expectedSideB, actualSideB, "A Négyzet konstruktora nem jól határozza meg az egyik oldalt!");

            r.SideA = 5.2545;
            expectedSideA = 5.2545;
            actualSideA = r.SideA;
            Assert.AreEqual(expectedSideA, actualSideA, 0.01, "A Négyzet oldal tulajdonság set vagy get metódusa nem megfelelően működik!");

            r.SideB = 6.1333;
            expectedSideB = 6.1333;
            actualSideB = r.SideB;
            Assert.AreEqual(expectedSideA, actualSideA, 0.01, "A Négyzet oldal tulajdonság set vagy get metódusa nem megfelelően működik!");

            double expectedPerimeter = 22.7756;
            double actualDistrict = r.Perimeter;
            Assert.AreEqual(expectedPerimeter, actualDistrict, 0.01, "A Circle District tulajdonság get metódusa nem megfelelően működik!");

            double expectedArea = 32.22742485;
            double actualArea = r.Area;
            Assert.AreEqual(expectedArea, actualArea, 0.01, "A Circle Area tulajdonság get metódusa nem megfelelően működik!");

            string sideA = r.SideA.ToString();
            string sideB = r.SideB.ToString();
            string roundedPrerimeter = Math.Round(r.Perimeter, 2).ToString();
            string roundedArea = Math.Round(r.Area, 2).ToString();
            string toString = r.ToString();

            bool haveSideA = toString.Contains(sideA);
            bool haveSideB = toString.Contains(sideB);
            bool haveParimeter = toString.Contains(roundedPrerimeter);
            bool haveArea = toString.Contains(roundedArea);

            Assert.IsTrue(haveSideA, "A ToString metódus nem jeleníti meg az egyik oldalt!");
            Assert.IsTrue(haveSideB, "A ToString metódus nem jeleníti meg az egyik oldalt");
            Assert.IsTrue(haveParimeter, "A ToString metódus nem jeleníti meg a kerületet két tizedes jegy pontossággal!");
            Assert.IsTrue(haveArea, "A ToString metódus nem jeleníti meg a területet két tizedes jegy pontosságal.");

        }
    }
=======
            Assert.Fail();
        }
   }
>>>>>>> f384c7da00e3b2e8eb3bd3c9d5bde9bbd693350a
}