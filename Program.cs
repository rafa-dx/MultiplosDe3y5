using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplosDe3y5
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int final = 1000;
            Console.WriteLine("Multiplos de 3 y 5");
            for (int x=3;x<=final;x++)
            { 
                if(x%3==0 || x%5==0)
                {
                    Console.WriteLine(" "+ x);
                    suma += x;
                }
            }
            Console.WriteLine("la suma de los multiplos es: " + suma);
            Console.ReadLine();
        }
    }
}
