using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_1
{
    class Program
    {
        static void Main(string[] args)
        {

            IntegerList POLJE = new IntegerList(10);

            POLJE.Add(2);
            POLJE.Add(2);
            POLJE.Add(4);
            POLJE.Add(5);
            POLJE.Add(8);
            POLJE.Add(21);
            POLJE.Add(2);
            POLJE.Add(7);
            POLJE.RemoveAt(2);
            POLJE.Remove(2);
            POLJE.IndexOf(21);

            int p = POLJE.Count();

            for (int i = 0; i<p; i++)
            {
                Console.WriteLine(POLJE.GetElement(i));
            }
            Console.WriteLine(POLJE.Contains(21));


        }
              
    }
}
