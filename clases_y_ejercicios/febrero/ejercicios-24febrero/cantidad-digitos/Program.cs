using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantidad_digitos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ejercicio 1
             *
            // variables 
            int num1, num2;
            string linea;

            // Imprimir
            Console.Write("Digita numero 1: ");

            //obtener valor
            linea = Console.ReadLine();

            num1 = int.Parse(linea);

           if (num1 <0)
            {
                Console.Write("Ingrese un numero positivo entre 0 y 99");
                return;
            }

           if(num1 >=0 && num1 <=9)
            {
                Console.Write("El numero que ingresaste es de un dígito");
            }
            else
            {
                Console.Write("El numero que ingresaste es de dos dígitos");
            }
            */

            /* Ejercicio: Estructura condicional notas

            // variables 
            int nota1, nota2, nota3;
            string linea;

            // Imprimir
            Console.Write("Digita nota #1: ");

            //obtener valor
            linea = Console.ReadLine();

            nota1 = int.Parse(linea);

            // Imprimir
            Console.Write("Digita nota #2: ");

            //obtener valor
            linea = Console.ReadLine();

            nota2 = int.Parse(linea);

            // Imprimir
            Console.Write("Digita nota #3: ");

            //obtener valor
            linea = Console.ReadLine();

            nota3 = int.Parse(linea);

            int promedio = ((nota1 + nota2 + nota3) / 3);
            if (promedio>=7)
            {
                Console.Write("Promocionado... Promedio: "+promedio);
            } else
            {
                if (promedio>=4)
                {
                    Console.Write("Regular... Promedio: "+promedio);
                } else
                {
                    Console.Write("Reprobado... Promedio: "+promedio);
                }
            }
            */

            /*
             Ejercicio validad numero

            // variables 
            int num1;
            string linea;

            // Imprimir
            Console.Write("Digita numero 1: ");

            //obtener valor
            linea = Console.ReadLine();

            num1 = int.Parse(linea);

            if (num1 < 0)
            {
                Console.Write("Numero negativo");
               
            } else
            {
                if (num1 > 0)
                {
                    Console.Write("Numero positivo");
                }
                else
                {
                    Console.Write("Null...");
                }
            }
            */

            int  mes;
            string dia, año,linea;

            // Imprimir
            Console.Write("Digita día:");

            //obtener valor
            dia = Console.ReadLine();

           

            // Imprimir
            Console.Write("Digita mes:");

            //obtener valor
            linea = Console.ReadLine();
            mes = int.Parse(linea);


            // Imprimir
            Console.Write("Digita año:");

            //obtener valor
            año = Console.ReadLine();

            /* if del ejercicio fecha trimestre
            if(mes >=1 && mes<=3) {
                Console.Write("Corresponde al primer trimestre.\nFecha: "+dia+"/"+mes+"/"+año);
            }
            else
            {
                Console.Write("NO corresponde al primer trimestre.\nFecha: " + dia + "/" + mes + "/" + año);
            }
            */
            
            if (mes == 12)
            {
                Console.Write("Corresponde a navidad.\nFecha: " + dia + "/" + mes + "/" + año);
            }
            else
            {
                Console.Write("NO corresponde aa navidad.\nFecha: " + dia + "/" + mes + "/" + año);
            }




            Console.ReadKey();

        }
    }
}
