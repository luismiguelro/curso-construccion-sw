using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2_suma_producto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // variables
            int num1, num2, num3, num4;
            string linea;

            
            // Imprimir
            Console.Write("Digita numero 1: ");

            //obtener valor
            linea = Console.ReadLine();

            num1 = int.Parse(linea);

            // Imprimir
            Console.Write("Digita numero 2: ");

            //obtener valor
            linea = Console.ReadLine();

            num2 = int.Parse(linea);

            Console.WriteLine("\n*********RESULTADO*********\n-Suma: " + (num1 + num2)+ "\n***************************\n");


            // Imprimir
            Console.Write("Digita numero 3: ");

            //obtener valor
            linea = Console.ReadLine();

            num3 = int.Parse(linea);

            // Imprimir
            Console.Write("Digita numero 4: ");

            //obtener valor
            linea = Console.ReadLine();

            num4 = int.Parse(linea);

            Console.WriteLine("\n*********RESULTADO*********\n-Multiplicación: " + (num3 * num4) + "\n***************************\n");

            // para que no se cierre en la ejecución
            Console.ReadKey();
        }
    }
}
