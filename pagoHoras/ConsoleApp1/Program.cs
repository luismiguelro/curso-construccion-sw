/* Librerias para la creacion de apps de consola*/
using System;
using System.Collections.Generic;
using System.Linq; // a nivel bd
using System.Text;
using System.Threading.Tasks; // tareas a programar


namespace pagoHoras
{
    internal class Program
    {
        // clase principal
        static void Main(string[] args)
        {
            // variables: al ser consola por defecto lo toma como string
            int horasTrabajadas;
            float costoHora, sueldo;

            string linea;

            // Imprimir
            Console.Write("Digita las horas trabajadas: ");

            //obtener valor
            linea = Console.ReadLine();

            // realizar parseo
            horasTrabajadas = int.Parse(linea);

            Console.Write("Digita el valor de la hora: ");
            linea = Console.ReadLine();
            costoHora = float.Parse(linea);

            // operacion
            sueldo = horasTrabajadas * costoHora;

            //imprimir line
            Console.WriteLine("Total sueldo a cancelar: "+ sueldo);
        
            // para que no se cierre en la ejecución
            Console.ReadKey();

            
        }
    }
}
