using System;
using System.Collections.Generic;
using System.Text;

namespace TryOutConsoleApp.Generics
{
    class GenericsRunner
    {
        public static void Main(string[] args)
        {
            Generics1<int> g1 = new Generics1<int>(10);
            g1.display();

            Generics1<string> g2 = new Generics1<string>("Friends");
            g2.display();

            User joey = new User("Joey", "Tribbiani");
            GenericConstraints<User> gc = new GenericConstraints<User>(joey);
            gc.Display();
        }
        
    }
}
