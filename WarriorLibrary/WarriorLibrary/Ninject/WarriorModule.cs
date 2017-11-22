using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace WarriorLibrary.Ninject
{
    public class WarriorModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IWeapon>().To<Sword>();
            Bind<IWeapon>().To<Katana>().WhenInjectedInto<Samurai>();
            Bind<IWeapon>().To<Spear>().WhenInjectedInto<Knight>();
        }
    }
}
