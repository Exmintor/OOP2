using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPFMidterm.ViewModels;
using CurrencyLibrary;
using CurrencyLibrary.USCurrency;
using System.Collections.ObjectModel;
using CurrencyLibrary.Interfaces;

namespace UnitTestWpfAppCurrency
{
    [TestClass]
    public class UnitTestCurrencyRepoViewModel
    {

        ICurrencyRepo repo;
        RepoViewModel vm;

        public UnitTestCurrencyRepoViewModel()
        {

        }

        [TestMethod]
        public void Coins_For_ComboBoxCoins_Collections_AreSame() 
        {
            //Arrange
            repo = new USCurrencyRepo();
            vm = new RepoViewModel((USCurrencyRepo)repo);

            ObservableCollection<ICoin> testCoinsforcdCoins;

            //Act
            testCoinsforcdCoins = vm.CoinsForComboBox;
            var coinList = USCurrencyRepo.GetCoinList();
            //Assert
            CollectionAssert.AreEqual(coinList, testCoinsforcdCoins);

        }

        //TODO test INotifyPropertyChanged
    }
}
