using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_13_marzo_V2
{
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
            int bajasPromedio = 0;

            // recorrer
            for (int f = 0; f < 5; f++)
            {
                promedioSuma += altura[f];
            }

            // obtener promedio
            promedio = promedioSuma / altura.Length;

            // validar personas altas/bajas que el promedio
            for (int f = 0; f < 5; f++)
            {
                if (altura[f] > promedio)
                {
                    altasPromedio++;
                }
                else
                {
                    bajasPromedio++;
                }
            }
            //imprimir resultado
            Console.WriteLine($"Promedio:{promedio}\nPersona mas altas que el promedio: {altasPromedio}\nPersona mas bajas que el promedio: {bajasPromedio}");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            // objeto vector altura
            VectorAltura va = new VectorAltura();
            va.Cargar();
            va.Promedio();
        }
    }

}
