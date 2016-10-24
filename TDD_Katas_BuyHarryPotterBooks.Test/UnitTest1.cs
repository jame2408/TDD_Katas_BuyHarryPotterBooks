using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_Katas_BuyHarryPotterBooks;
using System.Collections.Generic;

namespace TDD_Katas_BuyHarryPotterBooks.Tests
{
    /// <summary>
    /// 有一家書店在賣哈利波特書籍系列，
    /// 每一本書定價 $100 元。
    /// 買兩本不同的書可以打5% 的折扣、
    /// 買三本不同的書可以打 10% 的折扣、
    /// 買四本不同的書可以打 20%、
    /// 如果買到五本可以打到 25% 的折扣
    /// </summary>
    [TestClass()]
    public class BuyBooksPriceTest
    {
        [TestMethod()]
        public void BuyBooksPriceTest_第一集買一本_總價100元()
        {
            //1. Arrange
            var BooksNumbers = new List<int> { 1, 0, 0, 0, 0};            

            var target = new TDD_Katas_BuyHarryPotterBooks.CalculatorPrice();

            double expected = 100;
            
            //2. Act
            double actual;
            actual = target.BuyBooksPrice(BooksNumbers);

            //3. Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BuyBooksPriceTest_第1集與第2集各買一本_總價190元_測試5啪折扣()
        {
            //1. Arrange
            var BooksNumbers = new List<int> { 1, 1, 0, 0, 0 };

            var target = new TDD_Katas_BuyHarryPotterBooks.CalculatorPrice();

            double expected = 190;

            //2. Act
            double actual;
            actual = target.BuyBooksPrice(BooksNumbers);

            //3. Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BuyBooksPriceTest_第1集到第3集各買一本_總價270元_測試10啪折扣()
        {
            //1. Arrange
            var BooksNumbers = new List<int> { 1, 1, 1, 0, 0 };

            var target = new TDD_Katas_BuyHarryPotterBooks.CalculatorPrice();

            double expected = 270;

            //2. Act
            double actual;
            actual = target.BuyBooksPrice(BooksNumbers);

            //3. Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BuyBooksPriceTest_第1集到第4集各買一本_總價320元_測試20啪折扣()
        {
            //1. Arrange
            var BooksNumbers = new List<int> { 1, 1, 1, 1, 0 };

            var target = new TDD_Katas_BuyHarryPotterBooks.CalculatorPrice();

            double expected = 320;

            //2. Act
            double actual;
            actual = target.BuyBooksPrice(BooksNumbers);

            //3. Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BuyBooksPriceTest_第1集到第5集各買一本_總價375元_測試25啪折扣()
        {
            //1. Arrange
            var BooksNumbers = new List<int> { 1, 1, 1, 1, 1 };

            var target = new TDD_Katas_BuyHarryPotterBooks.CalculatorPrice();

            double expected = 375;

            //2. Act
            double actual;
            actual = target.BuyBooksPrice(BooksNumbers);

            //3. Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BuyBooksPriceTest_第1集到第6集各買一本_總價450元_測試25啪折扣_測試超過5本()
        {
            //1. Arrange
            var BooksNumbers = new List<int> { 1, 1, 1, 1, 1, 1 };

            var target = new TDD_Katas_BuyHarryPotterBooks.CalculatorPrice();

            double expected = 450;

            //2. Act
            double actual;
            actual = target.BuyBooksPrice(BooksNumbers);

            //3. Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BuyBooksPriceTest_第1集買兩本_總價200元_測試兩本相同不打折狀況()
        {
            //1. Arrange
            var BooksNumbers = new List<int> { 2, 0, 0, 0, 0 };

            var target = new TDD_Katas_BuyHarryPotterBooks.CalculatorPrice();

            double expected = 200;

            //2. Act
            double actual;
            actual = target.BuyBooksPrice(BooksNumbers);

            //3. Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BuyBooksPriceTest_第1集買兩本_第2集買一本_總價290元_測試一本相同原價_另兩本不同打折狀況()
        {
            //1. Arrange
            var BooksNumbers = new List<int> { 2, 1, 0, 0, 0 };

            var target = new TDD_Katas_BuyHarryPotterBooks.CalculatorPrice();

            double expected = 290;

            //2. Act
            double actual;
            actual = target.BuyBooksPrice(BooksNumbers);

            //3. Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BuyBooksPriceTest_第1集到第5集各買兩本_總價875元_測試五本打折_另五本不打折狀況()
        {
            //1. Arrange
            var BooksNumbers = new List<int> { 2, 2, 2, 2, 2 };

            var target = new TDD_Katas_BuyHarryPotterBooks.CalculatorPrice();

            double expected = 875;

            //2. Act
            double actual;
            actual = target.BuyBooksPrice(BooksNumbers);

            //3. Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

