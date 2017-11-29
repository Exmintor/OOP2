using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CurrencyWebApplication.Models
{
    public class TestHello : IHello
    {
        private string hello;

        public string Hello
        {
            get => this.hello;
            private set => this.hello = value;
        }

        public TestHello()
        {
            this.Hello = "Hello";
        }

        public string SayHello()
        {
            return this.Hello;
        }
    }
}