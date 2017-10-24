using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurrencyLibrary;
using CurrencyLibrary.USCurrency;
using CurrencyLibrary.Interfaces;

namespace UnitTestCurrency
{
    [TestClass]
    public class USCoinTests
    {

        Penny penny;

        public USCoinTests()
        {
            penny = new Penny();
        }


        [TestMethod]
        public void USCoinPennyConstructor()
        {
            //Arrange
            penny = new Penny();
            //Act 

            //Assert
            Assert.AreEqual(USCoinMintMark.D, penny.MintMark); //D is the default mint mark
            Assert.AreEqual(System.DateTime.Now.Year, penny.Year); //Current year is default year

        }

        [TestMethod]
        public void USCoinMintMarkTest()
        {

            //Arrange
            string mintNameDenver, mintNamePhili, mintNameSanFran, mintNameWestPoint;
            USCoinMintMark D, P, S, W;

            //Act 
            mintNameDenver = "Denver";
            mintNamePhili = "Philadelphia";
            mintNameSanFran = "San Francisco";
            mintNameWestPoint = "West Point";
            D = USCoinMintMark.D;
            P = USCoinMintMark.P;
            S = USCoinMintMark.S;
            W = USCoinMintMark.W;

            //Assert
            Assert.AreEqual(USCoin.GetMintNameFromMark(D), mintNameDenver);
            Assert.AreEqual(USCoin.GetMintNameFromMark(P), mintNamePhili);
            Assert.AreEqual(USCoin.GetMintNameFromMark(S), mintNameSanFran);
            Assert.AreEqual(USCoin.GetMintNameFromMark(W), mintNameWestPoint);
        }

        [TestMethod]
        public void USCoinPennyMonetaryValue()
        {
            //Arrange
            penny = new Penny();
            //Act 
            //nothing should have .01;
            //Assert
            Assert.AreEqual(.01, penny.MonetaryValue);
        }

        [TestMethod]
        public void USCoinPennyAbout()
        {
            //Arrange
            penny = new Penny();
            //Act 

            //Assert
            Assert.AreEqual("US Penny is from 2017. It is worth $0.01. It was made in Denver.", penny.About());
        }
    }
}
