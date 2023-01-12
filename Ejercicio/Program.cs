using System;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1 - Sumatoria");

            Console.WriteLine("Ingrese Primer numero");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Segundo numero");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Tercero numero");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado de la suma es " + functionSuma(num1, num2, num3));
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Ejercicio 2 - Clase Coche");

            Coche cochecito = new Coche();
            cochecito.IncrementoPuertas();
            cochecito.IncrementoPuertas();
            cochecito.IncrementoPuertas();
            cochecito.IncrementoPuertas();

            Console.WriteLine("El número de puertas que tiene  el carro es: " + cochecito.TotalPuertas());


            Console.ReadKey();
        }

        static int functionSuma(int a, int b, int c)
        {
            int resultado = a + b + c;
            return resultado;
        }

        public class Coche
        {
            int puertas = 0;

            public int IncrementoPuertas()
            {
                puertas++;
                return puertas=+puertas;
            }

            public int TotalPuertas()
            {
                return puertas;
            }
        }
    }
}
