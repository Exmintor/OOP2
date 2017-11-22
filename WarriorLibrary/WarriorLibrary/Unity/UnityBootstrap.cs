using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using Unity.Injection;

namespace WarriorLibrary.Unity
{
    public static class UnityBootstrap
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            //Will inject a sword whenever an IWeapon is needed
            container.RegisterType<IWeapon, Sword>();
            //Will inject Katana into Samurais
            container.RegisterType<Samurai>(new InjectionConstructor(new Katana()));
            //Will inject Spear into Knights
            container.RegisterType<Knight>(new InjectionConstructor(new Spear()));
        }
    }
}
