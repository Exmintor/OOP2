using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using System;
using System.Collections.Generic;
using System.Text;
using WarriorLibrary;
using WarriorLibrary.Ninject;

namespace UnitTestWarrior
{
    [TestClass]
    public class WarriorNinjectTests
    {
        IKernel kernel;
        public WarriorNinjectTests()
        {
            kernel = new StandardKernel(new WarriorModule());
        }

        [TestMethod]
        public void SamuraiNinject()
        {
            //Arrange
            Warrior warrior;
            string target;

            //Act 
            warrior = kernel.Get<Samurai>();
            target = "target";

            //Assert
            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Samurai));
            Assert.IsInstanceOfType(warrior.Weapon, typeof(Katana));
            Assert.AreEqual($"{warrior.ToString()} uses {warrior.Weapon.Name} on {target}.", warrior.Attack(target));
        }

        [TestMethod]
        public void NinjaNinject()
        {
            //Arrange
            Warrior warrior;
            string target;

            //Act 
            warrior = kernel.Get<Ninja>();
            target = "target";

            //Assert
            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Ninja));
            Assert.IsInstanceOfType(warrior.Weapon, typeof(Sword));
            Assert.AreEqual($"{warrior.ToString()} uses {warrior.Weapon.Name} on {target}.", warrior.Attack(target));
        }

        [TestMethod]
        public void KnightNinject()
        {
            //Arrange
            Warrior warrior;
            string target;

            //Act 
            warrior = kernel.Get<Knight>();
            target = "target";

            //Assert
            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Knight));
            Assert.IsInstanceOfType(warrior.Weapon, typeof(Spear));
            Assert.AreEqual($"{warrior.ToString()} uses {warrior.Weapon.Name} on {target}.", warrior.Attack(target));
        }
    }
}
