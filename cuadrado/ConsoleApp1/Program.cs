using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //variables
            int lado,superficie;
            string linea;

            // imprimir
            Console.Write("Digita un lado del cuadrado: ");
            linea = Console.ReadLine();

            lado = int.Parse(linea);
            superficie = (int)Math.Pow(lado,2);
            Console.Write("La superficie del cuadrado es: " + superficie );

            Console.ReadKey();

            

        }
    }
}
