using System;
using System.Collections.Generic;
using System.Text;

namespace WarriorLibrary
{
    public interface IWeapon
    {
        string Name { get;}

        string Hit(string target);
    }
}
