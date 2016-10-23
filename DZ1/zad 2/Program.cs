using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2


{

    class Program
    {
        static void Main(string[] args)
        {
            GenericList<X> lista = new GenericList<X>();
            X dag = new X();
            X pero = new X();
            X wex = new X();
            dag.broj = 1;
            pero.broj = 2;
            wex.broj = 4;
            lista.Add(dag);
            lista.Add(dag);
            lista.Add(dag);
            lista.Add(dag);
            lista.Add(wex);
            lista.Add(wex);
            lista.Add(pero);
            lista.RemoveAt(0);
            lista.Remove(dag);

            Console.WriteLine(lista.Count());
            Console.WriteLine(lista.Contains(dag));
            lista.Clear();

            Console.WriteLine(lista.Contains(dag));



        }
    }
}