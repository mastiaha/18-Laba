using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Laba
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            int[] array = new int[3] { 4, 5, 6 };
            list.AddRange(array);
            list.RemoveAt(3);
            list.Reverse();
            for (int i = 0; i < list.Count; i++)
            {
                list[i]++;
            }
            foreach(int l in list)
            {
                Console.WriteLine(l);
            }
            Console.ReadKey();
        }
    }
}
