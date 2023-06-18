using System;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {            
            int contadorPositivos = 0;
            int contadorNegativos = 0;

            Console.WriteLine("Ingresa los números (ingresa 0 para salir):");

            int numero;

            do
            {
                Console.Write("Número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero > 0) contadorPositivos++;             
                else if (numero < 0) contadorNegativos++;
                
            } while (numero != 0);

            Console.WriteLine($"Contador de números positivos: {contadorPositivos}");
            Console.WriteLine($"Contador de números negativos: {contadorNegativos}");         
        }
    }
}
