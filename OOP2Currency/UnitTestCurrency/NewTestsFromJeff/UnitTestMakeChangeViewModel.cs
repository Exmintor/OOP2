using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WPFMidterm.ViewModels;
using System.ComponentModel;
using CurrencyLibrary.USCurrency;

namespace UnitTestWpfAppCurrency
{
    [TestClass]
    public class UnitTestMakeChangeViewModel
    {

        MakeChangeViewModel vm;

        public UnitTestMakeChangeViewModel()
        {
            vm = new MakeChangeViewModel(new CurrencyLibrary.USCurrency.USCurrencyRepo());
        }

        [TestMethod]
        public void NotifyPropertyChanged_tests()
        {
            //Arrange
            List<string> receivedEvents = new List<string>();

            vm.PropertyChanged += delegate (object sender, PropertyChangedEventArgs e)
            {
                receivedEvents.Add(e.PropertyName);
            };

            //Act
            vm.MoneyAmount = 1;
            vm.Coins.Add(new Penny());

            //Assert
            
            Assert.AreEqual(receivedEvents[0], "MoneyAmount");
            
        }
    }
}
