using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Ejercicio #1
namespace ContadorNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaracion contadores
            int contadorNotasMayores = 0;
            int contadorNotasMenores = 0;

            // solicitar las 10 notas
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Ingrese la nota del alumno: " +i);
                double nota = double.Parse(Console.ReadLine());

                // validar si la nota es mayor a 7 e incrementar el contador segun el caso
                if (nota >= 7)
                {
                    contadorNotasMayores++;
                }
                else
                {
                    contadorNotasMenores++;
                }
            }

            Console.WriteLine($"Hay "+contadorNotasMayores +" alumnos con notas mayores o iguales a 7.");
            Console.WriteLine($"Hay "+contadorNotasMenores +" alumnos con notas menores a 7.");
            Console.ReadKey();
        }
    }
}
*/
/*
 * Ejercicio #2
namespace AlturaPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            // pedir la cantidad de personas, para despues segun la entrada recorrer con for
            Console.Write("Ingrese la cantidad de personas: ");
            int nPersonas = int.Parse(Console.ReadLine());

            double suma = 0;

            for (int i = 1; i <= nPersonas; i++)
            {
                Console.Write($"Ingrese la altura de la persona "+i+" en metros: ");
                double altura = double.Parse(Console.ReadLine());

                // suma + la altura ingresada
                suma += altura;
            }
            // calcular promedio
            double promedioAltura = suma / nPersonas;

            // resultado
            Console.WriteLine($"La altura promedio de las "+nPersonas+" personas es de "+promedioAltura+" metros.");
            Console.ReadKey();
        }
    }
}
*/
/*
Ejercicio #3
namespace SueldosEmpresa
{
    class Program
    {
        static void Main(string[] args)
        {
            // solicitar cantidad de empleados
            Console.Write("Ingrese la cantidad de empleados: ");
            int nEmpleado = int.Parse(Console.ReadLine());

            // variables
            double sueldoTotal = 0;
            int contadorEmpleadosMenores = 0;
            int contadorEmpleadosMayores = 0;

            for (int i = 1; i <= nEmpleado; i++)
            {
                Console.Write($"Ingrese el sueldo del empleado: "+i);
                double sueldo = double.Parse(Console.ReadLine());

                // ir sumando la cantidad de sueldos ingresados
                sueldoTotal += sueldo;


                // validar segun las condiciones dadas y luego incrementar el contador
                if (sueldo >= 100 && sueldo <= 300)
                {
                    contadorEmpleadosMenores++;
                }
                else if (sueldo > 300 && sueldo <= 500)
                {
                    contadorEmpleadosMayores++;
                }
                // validar, llegando al caso que se ingrese un sueldo diferente al solicitado en el ejercicio
                else
                {
                    Console.WriteLine("El sueldo ingresado es incorrecto. Debe estar entre $100 y $500.");
                    i--;
                }
            }

            // Imprimir resultados
            Console.WriteLine("La empresa tiene " + contadorEmpleadosMayores + "  empleados con sueldo de más de $300.");
            Console.WriteLine("La empresa tiene "+ contadorEmpleadosMenores +" empleados con sueldo entre $100 y $300.");
            Console.WriteLine("La empresa gasta un total de " +sueldoTotal+ " en sueldos al personal.");
            Console.ReadKey();
        }
    }
}

*/


 // Ejercicio #4
namespace SerieNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarar valor inicial
            int numero = 11;

            // for que recorre hasta el 25, segun dado el ejercicio
            for (int i = 1; i <= 25; i++)
            {
                // imprimir a cada vuelta del for
                Console.Write(numero + " ");
                // sumar en la secuencia
                numero += 11;
            }

            Console.ReadKey();
        }
    }
}



/*
namespace MultiplosOcho
{
    class Program
    {
        static void Main(string[] args)
        {
            // ciclo for para recorrer del 1 al 500
            for (int i = 1; i <= 500; i++)
            {
                // por cada número recorrido se saca el modulo y si es igual a 0, se imprime el numero en pantalla
                if (i % 8 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.ReadKey();
        }
    }
}
*/

/*
 * Ejercicio #6
namespace ComparacionListas
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarar arrays e inicializar con 15, segun lo solicitado en el ejercicio
            int[] listaUno = new int[15];
            int[] listaDos = new int[15];
            int sumaListaUno = 0;
            int sumaListaDos = 0;

            // Llenar lista 1
            Console.WriteLine("Ingrese los 15 valores de la primera lista:");
            for (int i = 0; i < 15; i++)
            {
                // pedir cada uno de los valores
                Console.WriteLine("Valor #"+(i+1));
                
                //covertir la entrada y asignar valores
                listaUno[i] = Convert.ToInt32(Console.ReadLine());
                sumaListaUno += listaUno[i];
            }

           
            // Llenar lista 2
            Console.WriteLine("Ingrese los 15 valores de la segunda lista:");
            for (int i = 0; i < 15; i++)
            {
                // pedir cada uno de los valores
                Console.WriteLine("Valor # " + (i+1));

                //covertir la entrada y asignar valores
                listaDos[i] = Convert.ToInt32(Console.ReadLine());
                sumaListaDos += listaDos[i];
            }

            // Comparación de las sumas de cada uno de los valores de las listas, e imprimir segun cumpla la condición
            if (sumaListaUno > sumaListaDos)
            {
                Console.WriteLine("\nLa lista 1 mayor: "+sumaListaUno);
            }
            else if (sumaListaDos > sumaListaUno)
            {
                Console.WriteLine("\nLa lista 2 mayor: " + sumaListaDos);
            }
            else
            {
                Console.WriteLine("\nLas listas tienen valores acumulados iguales.");
            }

            Console.ReadKey();
        }
    }
}

*/
 /*
 * Ejercicio #

namespace ContarParesImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaracion de las variables
            int nNumeros, valor, contadorPares = 0, contadorImpares = 0;

            Console.Write("Ingrese la cantidad de números que desea ingresar: ");
            nNumeros = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= nNumeros; i++)
            {
                Console.WriteLine("Ingrese el valor: "+i);
                valor = Convert.ToInt32(Console.ReadLine());

                // validar con el modulo y si es igual a 0 es par y si no impar, y aumentar los contadores segun la condicion
                if (valor % 2 == 0)
                {
                    contadorPares++;
                }
                else
                {
                    contadorImpares++;
                }
            }

            Console.WriteLine("La cantidad de números pares es: "+ contadorPares);
            Console.WriteLine("La cantidad de números impares es: " + contadorImpares);

            Console.ReadKey();
        }
    }
}
*/
