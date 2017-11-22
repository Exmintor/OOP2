using System;
using System.Collections.Generic;
using System.Text;

namespace WarriorLibrary
{
    public abstract class Warrior
    {
        private IWeapon weapon;

        public IWeapon Weapon
        {
            get
            {
                return weapon;
            }
            private set
            {
                weapon = value;
            }
        }

        public Warrior(IWeapon weapon)
        {
            this.Weapon = weapon;
        }
        public string Attack(string target)
        {
            return $"{this} uses {weapon.Hit(target)}";
        }
    }
}
