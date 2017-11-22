using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using WarriorLibrary;

namespace UnitTestWarrior
{
    [TestClass]
    public class WarriorTests
    {
        [TestMethod]
        public void SamuraiNoInject()
        {
            //Arrange
            Weapon weapon;
            Warrior warrior;
            string target;

            //Act 
            weapon = new Katana();
            warrior = new Samurai(weapon); //Dependency Samuria gets Katana
            target = "target";

            //Assert
            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Samurai));
            Assert.IsInstanceOfType(warrior.Weapon, typeof(Katana));
            Assert.AreEqual($"{warrior.ToString()} uses {warrior.Weapon.Name} on {target}.", warrior.Attack(target));
        }

        [TestMethod]
        public void NinjaNoInject()
        {
            //Arrange
            Weapon weapon;
            Warrior warrior;
            string target;

            //Act 
            weapon = new Sword();
            warrior = new Ninja(weapon); //Dependency Ninja gets sword
            target = "target";

            //Assert
            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Ninja));
            Assert.IsInstanceOfType(warrior.Weapon, typeof(Sword));
            Assert.AreEqual($"{warrior.ToString()} uses {warrior.Weapon.Name} on {target}.", warrior.Attack(target));
        }

        [TestMethod]
        public void KnightNoInject()
        {
            //Arrange
            Weapon weapon;
            Warrior warrior;
            string target;

            //Act 
            weapon = new Spear();
            warrior = new Knight(weapon); //Dependency Samuria gets Katana
            target = "target";

            //Assert
            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Knight));
            Assert.IsInstanceOfType(warrior.Weapon, typeof(Spear));
            Assert.AreEqual($"{warrior.ToString()} uses {warrior.Weapon.Name} on {target}.", warrior.Attack(target));
        }
    }
}
