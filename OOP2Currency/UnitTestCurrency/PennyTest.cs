using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurrencyLibrary;
using CurrencyLibrary.USCurrency;
using CurrencyLibrary.Interfaces;

namespace UnitTestCurrency
{
    [TestClass]
    public class PennyTest
    {
        [TestMethod]
        public void PennyConstructorTest()
        {
            //Arrange
            Penny coin, philiPenny;
            //Act
            coin = new Penny();
            philiPenny = new Penny(USCoinMintMark.P);
            //Assert
            Assert.AreEqual(USCoinMintMark.D, coin.MintMark);
            Assert.AreEqual(System.DateTime.Now.Year, coin.Year);
            Assert.IsInstanceOfType(coin, typeof(ICoin));
            Assert.AreEqual(USCoinMintMark.P, philiPenny.MintMark);
        }
        [TestMethod]
        public void PennyMonetaryValueTest()
        {
            //Arrange
            Penny coin;
            //Act
            coin = new Penny();
            //Assert
            Assert.AreEqual(coin.MonetaryValue, .01);
        }
        [TestMethod]
        public void PennyAboutTest()
        {
            //Arrange
            Penny coin;
            //Act
            coin = new Penny();
            string expectedOutput = "US Penny is from 2017. It is worth $0.01. It was made in Denver.";
            //Assert
            Assert.AreEqual(coin.About(), expectedOutput);
        }
    }
}
