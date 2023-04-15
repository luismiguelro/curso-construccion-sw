using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_14_abril
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ejercicio 1
            int[,] matriz = new int[3, 4];

            // Cargar la matriz pidiendo los valores al usuario
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("Ingrese un valor para la fila {0} y la columna {1}: ", i + 1, j + 1);
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Imprimir la primera fila
            for (int i = 0; i < 4; i++)
            {
                Console.Write(matriz[0, i] + " ");
            }
            Console.WriteLine();

            // Imprimir la última fila
            for (int i = 0; i < 4; i++)
            {
                Console.Write(matriz[2, i] + " ");
            }
            Console.WriteLine();

            // Imprimir la primera columna
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(matriz[i, 0]);
            }

            */
            /*Ejercicio 2: crear una matriz de 2 filas y 5 columnas, realizar la carga de los compoonentes por columnas(es decir, primero ungresar toda la primera columna, la segunda, y asi, imprimir luego la matriz*/

            int[,] matriz = new int[2, 5];

            // Cargar componentes por columna
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.Write("Ingrese un valor para la fila {0} y la columna {1}: ", i + 1, j + 1);
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Imprimir la matriz
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        
    }
}
