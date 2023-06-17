using System;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime horaActual = DateTime.Now;
            string hora = horaActual.ToString("HH:mm:ss");
            Console.WriteLine("Hora actual: " + hora);
        }
    }
}
