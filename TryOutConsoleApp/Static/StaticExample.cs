using System;
using System.Collections.Generic;
using System.Text;

namespace TryOutConsoleApp.Static
{
    class StaticExample
    {
        public static int stat_variable;

        static StaticExample()
        {
            Console.WriteLine("It runs only once");
            stat_variable = 10;
        }

        public void set_stat_variable(int v)
        {
            stat_variable = v;
        }
    }
}
