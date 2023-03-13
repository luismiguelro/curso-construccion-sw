using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_13_marzo
{
    /* Ejercicio 1
    class PruebaVector
    {
        //arreglo
        private int[] sueldos;

        // cargar información
        public void Cargar()
        {
            sueldos= new int[5];
            for(int f=0; f<5; f++)
            {
                Console.WriteLine($"Ingrese salario #{(f + 1)}");
                sueldos[f] = int.Parse(Console.ReadLine());
            }
        }

        // imprimir información
        public void Imprimir()
        {
            //recorrer
            for (int f = 0; f < 5; f++)


            {
                Console.WriteLine($"Sueldo#{(f+1)}: {sueldos[f]}");

            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            PruebaVector pruebaVector = new PruebaVector();
            pruebaVector.Cargar();
            pruebaVector.Imprimir();
        }
    }
    */
    class VectorAltura
    {
        //arreglo
        private float[] altura;

        // cargar información
        public void Cargar()
        {
            altura = new float[5];
            for (int f = 0; f < 5; f++)
            {
                Console.WriteLine($"Ingrese altura de persona #{(f + 1)}");
                altura[f] = float.Parse(Console.ReadLine());
            }
        }
        public void Promedio()
        {
            // variables
            float promedioSuma = 0;
            float promedio = 0;
            int altasPromedio = 0;
            int bajasPromedio= 0;

            // recorrer
            for (int f = 0; f < 5; f++)
            {
                promedioSuma += altura[f];
            }

            // obtener promedio
            promedio= promedioSuma/altura.Length;

            // validar personas altas/bajas que el promedio
            for (int f = 0; f < 5; f++)
            {
                if (altura[f]>promedio) { 
                {
                        altasPromedio++;
                } else
                    {
                        bajasPromedio++;
                    }
            }  
        }
            Console.WriteLine($"Promedio {promedio}\nPersona mas altas que el promedio: {altasPromedio}\nPersona mas altas que el promedio: {bajasPromedio}");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            VectorAltura va = new VectorAltura();
            va.Cargar();
            va.Promedio();
        }
    }
