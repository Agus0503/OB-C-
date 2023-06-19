using System;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {            
            double precioSinDescuento = 1500.99;
            
            Console.Write("Ingrese nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese email: ");
            string email = Console.ReadLine();

            Console.Write("Tiene cupon? (Si/No): ");
            string respuesta = Console.ReadLine();

            if(respuesta.ToLower() == "si")
            {
                Console.Write("Ingrese numero de cupon: ");
                int cupon = int.Parse(Console.ReadLine());
                double precioConDescuento = precioSinDescuento - (precioSinDescuento * 0.35);
                Console.WriteLine($"Precio final: {precioConDescuento}");
            }
            else Console.WriteLine($"Precio final: {precioSinDescuento}");

        }
    }
}