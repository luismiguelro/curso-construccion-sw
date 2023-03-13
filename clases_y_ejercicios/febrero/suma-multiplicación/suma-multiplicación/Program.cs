using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suma_multiplicación
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // varibles 
            int num1,num2;
            string linea;

            // Imprimir
            Console.Write("Digita numero 1: ");

            //obtener valor
            linea = Console.ReadLine();

            num1= int.Parse(linea);

            // Imprimir
            Console.Write("Digita numero 2: ");

            //obtener valor
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.WriteLine("*********RESULTADO*********\n-Suma: " + (num1+num2) + "\n-Multiplicación: "+(num1*num2));

            // para que no se cierre en la ejecución
            Console.ReadKey();



        }
    }
}
