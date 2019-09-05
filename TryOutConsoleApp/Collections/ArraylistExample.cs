using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TryOutConsoleApp.Collections
{
    class ArraylistExample
    {
        private ArrayList al;
        public ArraylistExample()
        {
            al = new ArrayList();
        }

        public void addElementToAL()
        {
            al.Add(2);
            al.Add("Joey");
            al.Add(true);
            al.Add(2);
        }

        public void displayAL()
        { 
            foreach(var v in al)
            {
                Console.WriteLine(v);
            }
        }

        public void operations()
        {
            //al.Sort();
            //displayAL();
            al.Reverse();
            displayAL();
        }
    }
}
