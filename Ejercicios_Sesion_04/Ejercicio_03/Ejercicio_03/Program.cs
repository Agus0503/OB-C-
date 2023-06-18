using System;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el ancho: ");
            int ancho = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el alto: ");
            int alto = int.Parse(Console.ReadLine());

            Console.Write("Ingrese 1 para relleno o 0 para no relleno: ");
            int relleno = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de rectángulos o cuadrados a dibujar: ");
            int cantidad = int.Parse(Console.ReadLine());

            for (int k = 0; k < cantidad; k++)
            {
                Console.WriteLine("Salida:");

                if (ancho == alto)
                {
                    // Dibujar cuadrado
                    for (int i = 0; i < alto; i++)
                    {
                        for (int j = 0; j < ancho; j++)
                        {
                            if (relleno == 1 || i == 0 || i == alto - 1 || j == 0 || j == ancho - 1) Console.Write("*");
                                                                                     
                            else Console.Write(" ");                            
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    // Dibujar rectángulo
                    for (int i = 0; i < alto; i++)
                    {
                        for (int j = 0; j < ancho; j++)
                        {
                            if (relleno == 1 || i == 0 || i == alto - 1 || j == 0 || j == ancho - 1) Console.Write("*");
                            
                            else Console.Write(" ");
                            
                        }
                        Console.WriteLine();
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
