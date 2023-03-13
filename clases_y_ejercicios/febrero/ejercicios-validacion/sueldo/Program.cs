using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sueldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // Ejercicio sueldo mayor a 3000
            //Variables

            float sueldo;
            string linea;


            Console.WriteLine("Digita el sueldo:");
            linea = Console.ReadLine();

            sueldo = float.Parse(linea);

            // condicional
            if (sueldo>3000)
            {
                Console.WriteLine("Esta persona debe pagar impuesto");

            }
            else
            {
                Console.WriteLine("No pagas impuestos (de momento jeje)");
            }*/

            /*
            //Ejercicio numero mayor

            /Variables
            int num1,num2,num3;
            string linea;

            //obtener valores y parsear
            Console.WriteLine("Digita numero 1:");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);


            Console.WriteLine("Digita numero 2:");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.WriteLine("Digita numero 3:");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            if (num1 > num2 && num1>num3)
            {
                Console.WriteLine("El numero mayor es: "+num1);
            }

            else if(num2 > num1 && num2 > num3)
            {
                Console.WriteLine("El numero mayor es: " + num2);
            }

            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("El numero mayor es: " + num3);
            }

            else
            {
                Console.WriteLine("Los números son iguales");
            }*/

            // Variables
            int num1, num2, num3;
            string linea;

            //obtener valores y parsear
            Console.WriteLine("Digita numero 1:");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);


            Console.WriteLine("Digita numero 2:");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            if (num1 > num2)
            {
                int suma = num1 + num2, resta = num1 - num2;
                Console.WriteLine("Resultado\nSuma: "+suma +"\nResta: "+resta);
            } else
            {
                int multiplicacion = num1 * num2, division = num1/ num2;
                Console.WriteLine("Resultado\nMultiplicación: " + multiplicacion + "\nDivisión: " + division);

            }

            Console.ReadKey();
        }
    }
}
