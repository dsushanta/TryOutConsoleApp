using System;
using System.Collections;
using System.Text;

namespace TryOutConsoleApp
{
    class HashT {
        public void tryOutHashTables() {
            Hashtable hash = new Hashtable();
            hash.Add("1", "Joey");
            hash.Add("Chandler", 2);
            hash.Add(true, false);
            ICollection keys = hash.Keys;
            foreach (object k in keys) {
                Console.WriteLine(k + " : " + hash[k]);
            }
        }
    }
}
