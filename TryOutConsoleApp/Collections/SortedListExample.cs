using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TryOutConsoleApp.Collections
{
    class SortedListExample
    {
        SortedList sl = new SortedList();

        public void addElementToSL()
        {
            sl.Add(3, "Hi");
            sl.Add(2, "Hello");
        }

        public void displayAL()
        {
            foreach (DictionaryEntry v in sl)
            {
                Console.WriteLine("Key : "+v.Key+" | Value : "+v.Value);
            }
        }

        public void operations()
        {
            
        }
    }
}
