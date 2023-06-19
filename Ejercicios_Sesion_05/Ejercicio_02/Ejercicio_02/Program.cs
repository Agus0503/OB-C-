using System;
using System.Collections.Generic;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {                      
            string[] lenguajes = { "C#", "Java", "C++" };
            int i = 1;
            
            foreach(var lenguaje in lenguajes)
            {
                Console.WriteLine($"{i}. {lenguaje}");
                i++;
            }

            Console.WriteLine("Elija un lenguaje: ");
            int opcionElegida = int.Parse(Console.ReadLine());

            switch (opcionElegida)
            {
                case 1:
                    Console.WriteLine("Usted eligio -> C#");
                    break;
                case 2:
                    Console.WriteLine("Usted eligio -> Java");
                    break;
                case 3:
                    Console.WriteLine("Usted eligio -> C++");
                    break;
            }
        }
    }
}
