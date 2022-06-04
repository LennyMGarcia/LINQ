using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valoresNumericos = new int[] {1,2,3,4,5,6,7,8,9,10};

            
            Console.WriteLine("Numeros pares: ");
            //Aqui se utiliza LINQ, IEnumerable al parecer hace una iteracion de un tipo de dato especificado
            IEnumerable<int> numerosPares = from numero in valoresNumericos where numero %2== 0 select numero;

            /*List<int> numerosPares = new List<int>();

            foreach (int i in valoresNumericos)
            {
                if( i% 2 ==0)
                {
                    numerosPares.Add(i);
                }

            }*/

            foreach(int i in numerosPares)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
