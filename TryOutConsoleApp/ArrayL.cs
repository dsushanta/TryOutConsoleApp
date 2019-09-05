using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TryOutConsoleApp
{
    class ArrayL {
        public void tryOutArrayList() {
            ArrayList a = new ArrayList();
            a.Add(1);
            a.Add("Johny Bravo");
            a.Add(true);

            foreach(object e in a) {
                Console.WriteLine(e);
            }

            Console.WriteLine(a.Count);
            Console.WriteLine(a[2]);
        }
    }
}
