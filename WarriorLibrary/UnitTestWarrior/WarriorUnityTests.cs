using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using WarriorLibrary;
using WarriorLibrary.Unity;

namespace UnitTestWarrior
{
    [TestClass]
    public class WarriorUnityTests
    {
        IUnityContainer unityContainer;

        public WarriorUnityTests()
        {
            unityContainer = new UnityContainer();
            UnityBootstrap.RegisterTypes(unityContainer);
        }

        [TestMethod]
        public void SamuraiUnityInject()
        {
            //Arrange
            Warrior warrior;
            string target;

            //Act 
            warrior = unityContainer.Resolve<Samurai>();
            target = "target";

            //Assert
            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Samurai));
            Assert.IsInstanceOfType(warrior.Weapon, typeof(Katana));
            Assert.AreEqual($"{warrior.ToString()} uses {warrior.Weapon.Name} on {target}.", warrior.Attack(target));
        }

        [TestMethod]
        public void NinjaUnityInject()
        {
            //Arrange
            Warrior warrior;
            string target;

            //Act 
            warrior = unityContainer.Resolve<Ninja>();
            target = "target";

            //Assert
            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Ninja));
            Assert.IsInstanceOfType(warrior.Weapon, typeof(Sword));
            Assert.AreEqual($"{warrior.ToString()} uses {warrior.Weapon.Name} on {target}.", warrior.Attack(target));
        }

        [TestMethod]
        public void KnightUnityInject()
        {
            //Arrange
            Warrior warrior;
            string target;

            //Act 
            warrior = unityContainer.Resolve<Knight>();
            target = "target";

            //Assert
            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Knight));
            Assert.IsInstanceOfType(warrior.Weapon, typeof(Spear));
            Assert.AreEqual($"{warrior.ToString()} uses {warrior.Weapon.Name} on {target}.", warrior.Attack(target));
        }
    }
}
