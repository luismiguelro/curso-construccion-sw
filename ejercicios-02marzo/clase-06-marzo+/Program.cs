using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_06_marzo_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //EJEMPLO CLASE 1

            // variables
            string linea;
            int valor;

            do
            {
                // solicitar digito y realizar parseo
                Console.WriteLine("Digite un numero entre 0 y 999");
                linea= Console.ReadLine();
                valor = int.Parse(linea);

                // validar si tiene 3 digitos
                if (valor >=100 && valor <=999)
                {

                    Console.WriteLine($"Tiene 3 digitos: {valor}\n");

                } else
                    // validar si tiene 2 digitos

                    if (valor >=10 && valor<100){
                    Console.WriteLine($"Tiene 2 digitos: {valor}\n");

                } else
                    // validar si tiene 1 digito

                    if (valor < 10)
                {
                    Console.WriteLine($"Tiene un solo digito: {valor}\n");

                }
                // mensaje por si se ingresa un numero mayor a 999
                else
                {
                    Console.WriteLine($"{valor}: Fuera de rango...\n");
                }

            } while (valor != 0);
            */

            /* Ejemplo 2

            // variables
            string linea;
            int suma=0, promedio=0, contador = 0;
            int valor;
            do
            {


                // solicitar digito y realizar parseo

                
                Console.WriteLine($"Digite la nota #{contador}");
                linea = Console.ReadLine();
                valor = int.Parse(linea);

                if (valor != 0)
                {
                    suma = suma + valor;
                    contador++;
                }
            } while(valor !=0);
            if (contador != 0)
            {
                promedio= suma/contador;
                Console.WriteLine($"Promedio{promedio}\n");
            }
            else
            {
                Console.WriteLine("No se ingresaron valores");
            }

           */
            /*

            // Ejemplo 3
            string linea;
            int suma = 0, promedio = 0, contador = 0;
            int valor;
            do
            {


                // solicitar digito y realizar parseo


                Console.WriteLine($"Digite la nota #{(contador+1)}");
                linea = Console.ReadLine();
                valor = int.Parse(linea);

                // condicion segun requerido el ejercicio
                if (valor != 0 && valor != 9999)
                {
                    suma = suma + valor;
                    contador++;
                }
            } while (valor != 0 && valor != 9999);

            // validar si el contadoe es diferente de 0 y realizar calculo promedio
                if (contador != 0)
                {
                    promedio = suma / contador;
                

                // validar si el promedio es mayor o menor que 01
                    if ( promedio >= 0)
                    {
                    Console.WriteLine($"Acumulado es:{suma}");
                    Console.WriteLine($"Valor POSITIVO...");
                    }

                    else
                    {
                    Console.WriteLine($"Acumulado es:{suma}");
                    Console.WriteLine("Valor NEGATIVO...");

                }
                }
                else
                {
                    Console.WriteLine("No se ingresaron valores");
                }
            */
                Console.ReadKey();

        }
    }
}
