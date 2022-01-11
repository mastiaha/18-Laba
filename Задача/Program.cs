using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача
{
    class Program
    {
        static void Main()
        {
            string skobki = Console.ReadLine();
            Console.WriteLine(Check(skobki) == -1 ? "Ошибок нет. Скобки расставлены правильно!" : Check(skobki).ToString());
            Console.WriteLine(Check(skobki) != -1 ? "Ошибка! Скобки расставлены неправильно!" : Check(skobki).ToString());

            Console.ReadKey();
        }

        static int Check(string skobki)
        {
            string type = "[{(]})";
            Stack<char> st = new Stack<char>();

            for (int i = 0; i < skobki.Length; i++)
            {
                int f = type.IndexOf(skobki[i]);

                if (f >= 0 && f <= 2)
                    st.Push(skobki[i]);

                if (f > 2)
                {
                    if (st.Count == 0 || st.Pop() != type[f - 3])
                        return i;
                }
            }

            if (st.Count != 0)
                return skobki.LastIndexOf(st.Pop());

            return -1;
        }

    }
}
