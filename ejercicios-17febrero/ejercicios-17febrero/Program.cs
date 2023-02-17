using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_17febrero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("-------------- EJERCICIO 1 --------------");

            // Variables y obtener datos
            
            Console.WriteLine("Digita numero 1: ");
            int num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digita numero 2: ");
            int num2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digita numero 3: ");
            int num3 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digita numero 4: ");
            int num4 = Convert.ToInt16(Console.ReadLine());

            // calcular suma
            int suma = num1 + num2 + num3 + num4;
            double promedio = suma / 4;

            Console.WriteLine("*********RESULTADO*********\n-Suma: " + suma + "\n-Promedio: " + promedio+ "\n***************************\n");

            Console.WriteLine("-------------- EJERCICIO 2 --------------");

            //obtener nombre
            Console.WriteLine("Digita nombre del articulo");
            string nombreArticulo = Convert.ToString(Console.ReadLine());

            //obtener precio
            Console.WriteLine("Digita el precio para el articulo: "+ nombreArticulo);
            int precio = Convert.ToInt16(Console.ReadLine());

            //obtener cantidad
            Console.WriteLine("Digita la cantidad a llevar");
            int cantidad = Convert.ToInt16(Console.ReadLine());

            //imprimir resultado con total a pagar

            Console.WriteLine("-Articulo: "+nombreArticulo+"\n-Precio: " + precio+"\n-Cantidad: "+cantidad+"\nTOTAL A PAGAR: "+ (precio*cantidad)+ "\n************************************");

           
            // para que no se cierre en la ejecución
            Console.ReadKey();
        }
    }
}
