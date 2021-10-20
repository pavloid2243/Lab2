using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Tests
{
    [TestClass()]
    public class LogicTest
    {
        [TestMethod()]
        public void InTime()
        {
            int a, b, c, d, n, m, i, y;
            String s;
           
            a = 7;
            b = 40;
            c = 8;
            d = 50;
            n = 8;
            m = 30;

           
            s = Logic.Logica(a, b, c, d, n, m);
            Assert.AreEqual("Поезд стоит на платформе", s);


        }
        [TestMethod()]
        public void Later()
        {
            int a, b, c, d, n, m, i, y;
            String s;
            a = 7;
            b = 40;
            c = 8;
            d = 50;
            n = 9;
            m = 30;


            s = Logic.Logica(a, b, c, d, n, m);
            Assert.AreEqual("Поезд не стоит на платформе", s);
        }
        [TestMethod()]
        public void Earlier()
        {
            int a, b, c, d, n, m, i, y;
            String s;
            a = 7;
            b = 40;
            c = 8;
            d = 50;
            n = 6;
            m = 30;


            s = Logic.Logica(a, b, c, d, n, m);
            Assert.AreEqual("Поезд не стоит на платформе", s);
        }
        [TestMethod()]
        public void OnNextDay()
        {
            int a, b, c, d, n, m, i, y;
            String s;
            a = 7;
            b = 40;
            c = 6;
            d = 50;
            n = 17;
            m = 30;


            s = Logic.Logica(a, b, c, d, n, m);
            Assert.AreEqual("Поезд стоит на платформе", s);
        }
    }
}