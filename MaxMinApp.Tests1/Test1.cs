//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using MaxMinApp;

//namespace MaxMinApp.Tests1
//{
//    [TestClass]
//    public class Test1
//    {
//        // ===== ТЕСТЫ МАКСИМУМА =====


//        [TestMethod]
//        public void GetMax_FirstIsMax_ReturnsFirst()
//        {
//            double result = Calculator.GetMax(10.5, 3.2, 7.1);
//            Assert.AreEqual(10.5, result);
//        }

//        [TestMethod]
//        public void GetMax_SecondIsMax_ReturnsSecond()
//        {
//            double result = Calculator.GetMax(1.0, 99.9, 50.0);
//            Assert.AreEqual(99.9, result);
//        }

//        [TestMethod]
//        public void GetMax_ThirdIsMax_ReturnsThird()
//        {
//            double result = Calculator.GetMax(4.4, 2.2, 8.8);
//            Assert.AreEqual(8.8, result);
//        }

//        [TestMethod]
//        public void GetMax_AllEqual_ReturnsValue()
//        {
//            double result = Calculator.GetMax(5.0, 5.0, 5.0);
//            Assert.AreEqual(5.0, result);
//        }

//        [TestMethod]
//        public void GetMax_NegativeNumbers_ReturnsLeastNegative()
//        {
//            double result = Calculator.GetMax(-1.0, -5.5, -3.3);
//            Assert.AreEqual(-1.0, result);
//        }

//        // ===== ТЕСТЫ МИНИМУМА =====

//        [TestMethod]
//        public void GetMin_FirstIsMin_ReturnsFirst()
//        {
//            double result = Calculator.GetMin(1.1, 5.5, 3.3);
//            Assert.AreEqual(1.1, result);
//        }

//        [TestMethod]
//        public void GetMin_SecondIsMin_ReturnsSecond()
//        {
//            double result = Calculator.GetMin(7.7, 0.5, 4.4);
//            Assert.AreEqual(0.5, result);
//        }

//        [TestMethod]
//        public void GetMin_ThirdIsMin_ReturnsThird()
//        {
//            double result = Calculator.GetMin(9.0, 6.0, 2.0);
//            Assert.AreEqual(2.0, result);
//        }

//        [TestMethod]
//        public void GetMin_MixedSigns_ReturnsMostNegative()
//        {
//            double result = Calculator.GetMin(-10.0, 0.0, 5.0);
//            Assert.AreEqual(-10.0, result);
//        }

//        [TestMethod]
//        public void GetMin_DecimalNumbers_ReturnsCorrect()
//        {
//            double result = Calculator.GetMin(3.14, 2.71, 1.41);
//            Assert.AreEqual(1.41, result);
//        }
//    }
//}
