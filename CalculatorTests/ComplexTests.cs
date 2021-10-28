using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass()]
    public class ComplexTests
    {
        [TestMethod()]
        public void EqualTest()
        {
            Complex test = new Complex();
            Complex a = new Complex(2, 3);
            Complex b = new Complex(5, -7);
            Assert.AreEqual("Вектор второго числа больше первого", Complex.Equal(a, b));

            a.SetComplex(5, -7);
            b.SetComplex(2, 3);
            Assert.AreEqual("Вектор первого числа больше второго", Complex.Equal(a, b));

            a.SetComplex(5, -7);
            b.SetComplex(5, -7);
            Assert.AreEqual("Векторы равны", Complex.Equal(a, b));
        }

        [TestMethod()]
        public void answerTest()
        {
            Complex test = new Complex();
            Complex a = new Complex(2,3);
            Complex b = new Complex(5,-7);
            test = a + b;
            Assert.AreEqual("7-4i", Complex.Answer(test));
            test = a - b;
            Assert.AreEqual("-3+10i", Complex.Answer(test));
            test = a * b;
            Assert.AreEqual("31+1i", Complex.Answer(test));
            test = a / b;
            Assert.AreEqual("-0.149+0.392i", Complex.Answer(test));
            Assert.AreEqual("-0.149+0.392i", Complex.Answer(test));
        }
    }
}