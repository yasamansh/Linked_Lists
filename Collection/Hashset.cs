using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class hashSet
    {
        public void readWriteHashSet()
        {
            HashSet<int> set1 = new HashSet<int>();

            set1.Add(1);
            set1.Add(2);
            set1.Add(2);
            set1.Add(4);
            set1.Add(4);

            HashSet<int> set2 = new HashSet<int>();

            set2.Add(2);
            set2.Add(3);
            set2.Add(4);
            set2.Add(5);
            set2.Add(4);

            Console.WriteLine("Union:");
            foreach (var item in set1.Union(set2))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Intersect:");
            foreach (var item in set1.Intersect(set2))
            {
                Console.WriteLine(item);
            }

        }
    }
}
