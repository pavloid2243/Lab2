using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void LogicaTest()
        {
            var a = 5;
            var b = 2;
            var message = Logic.Logica(a, b);
            

            Assert.AreEqual("Отрезаем квадрат размером 2 x 2 Отрезаем квадрат размером 2 x 2 Отрезаем квадрат размером 1 x 1 Отрезаем квадрат размером 1 x 1 Количество квадратов = 4 ", message);

        }
    }
}