using System;
using System.Collections.Generic;
using System.Text;

namespace TryOutConsoleApp.Generics
{
    class GenericConstraints<T> : BaseGenerics<T> where T: class
    {
        private T memberVar;

        public GenericConstraints(T memberVar)
        {
            this.memberVar = memberVar;
        }

        public void Display()
        {
            Console.WriteLine(memberVar);
        }
    }
}
