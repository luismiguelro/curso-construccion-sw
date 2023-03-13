using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_10marzo_poo
{
     class Triangulo
    {
        //variables
        private int lado1,lado2,lado3;
        public void Inicializar()
        {
            Console.WriteLine("Ingrese lado1");
            lado1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese lado2");
            lado2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese lado3");
            lado3 = int.Parse(Console.ReadLine());
        }
        public void LadoMayor()
        {
            if(lado1>lado2 && lado1 > lado2)
            {
                Console.WriteLine($"Lado mayor es {lado1}");
            } else if(lado2>lado1 && lado2 > lado3)
            {
                Console.WriteLine($"Lado mayor es {lado2}");
            }
            else if (lado3 > lado1 && lado3 > lado2)
            {
                Console.WriteLine($"Lado mayor es {lado3}");
            }
            else
            {
                Console.WriteLine("Es un triangulo equilatero");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();
            triangulo.Inicializar();
            triangulo.LadoMayor();
            
        }
    }
}
