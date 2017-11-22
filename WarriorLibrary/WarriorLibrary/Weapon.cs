using System;
using System.Collections.Generic;
using System.Text;

namespace WarriorLibrary
{
    public abstract class Weapon : IWeapon
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            protected set
            {
                name = value;
            }
        }

        public string Hit(string target)
        {
            return $"{this.Name} on {target}.";
        }
    }
}
