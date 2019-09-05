using System;
using System.Collections.Generic;
using System.Text;

namespace TryOutConsoleApp.Generics
{
    class Generics1<T> : BaseGenerics<T>
    {
        private T genericVar;

        public Generics1(T genericVar)
        {
            this.genericVar = genericVar;
        }

        public T genericProperty
        {
            get;
            set;
        }

        public void display()
        {
            Console.WriteLine(this.genericVar);
        }
    }
}
