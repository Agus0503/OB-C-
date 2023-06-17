using System;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("Ingrese edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("¿Sabe programar? (Sí/No): ");
            string sabeProgramar = Console.ReadLine();

            string mensaje = "Hola " + nombre + " " + apellido;

            mensaje += " Tenes " + edad + " años";

            if (sabeProgramar.ToLower() == "si")
            {
                mensaje += " y sabes programar.";
            }
            else
            {
                mensaje += " y no sabes programar.";
            }

            Console.WriteLine(mensaje);
        }
    }
}
