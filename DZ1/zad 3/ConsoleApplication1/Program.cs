using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ZAD3
{
    class Program
    {
        static void Main(string[] args)
        {
            IGenericList<string> polje = new GenericList<string>();
            polje.Add("DA");
            polje.Add("NE");
            polje.Add("NIKAD");
            polje.Add("OOP");
            foreach (var item in polje)
            {
                Console.WriteLine(item);
            }
        }
    }
}
