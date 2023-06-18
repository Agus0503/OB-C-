using System;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            int numeroIngresado = int.Parse(Console.ReadLine());
            int i = 0;

            while (i < 10)
            {
                i++;
                Console.WriteLine($"{numeroIngresado} * {i} = " + numeroIngresado*i);
            }

        }
    }
}
