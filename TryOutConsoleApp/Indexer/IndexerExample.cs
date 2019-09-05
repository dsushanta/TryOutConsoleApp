using System;
using System.Collections.Generic;
using System.Text;

namespace TryOutConsoleApp.Indexer
{
    class IndexerExample
    {
        private int[] a;
        private int[] b;

        public IndexerExample()
        {
            a = new int[10];
            b = new int[3];
        }

        public int this[int index]
        {
            get {
                if (index < 0 || index >= a.Length)
                    throw new IndexOutOfRangeException("Index is out of range !!");

                return a[index];
                }
            set {
                if (index < 0 || index >= a.Length)
                    throw new IndexOutOfRangeException("Index is out of range !!");

                a[index] = value;
            }
        }
    }
}
