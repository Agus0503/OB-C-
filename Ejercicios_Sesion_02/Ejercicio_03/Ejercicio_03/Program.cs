/*Ejercicio 3

Operadores Determina los operadores para verificar las siguientes condiciones:

Un número es mayor o igual a 18

Un char es ‘a’

Se cumplen dos conciones a la vez (ambas verdaderas)

Se cumple una de dos condiciones a la vez (una true y otra false*/
using System;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Numero mayor o igual a 18
            int num = 20;

            if (num >= 18)
            {
                Console.WriteLine("Se cumple la condicion");
            }

            //Char == 'a' 
            char caracter = 'a';

            if (caracter == 'a')
            {
                Console.WriteLine("Se cumple la igualdad");
            }

            //Dos condiciones verdaderas
            int num2 = 20;
            int num3 = 30;

            if (num2 > 10 && num3 > 20)
            {
                Console.WriteLine("Ambas condiciones son verdaderas");
            }

            //Una de dos condiciones (true y false)
            int num4 = 35;
            int num5 = 24;

            if (num4 > 30 || num5 < 20)
            {
                Console.WriteLine("Una de las dos condiciones se cumple");
            }
        }
    }
}
