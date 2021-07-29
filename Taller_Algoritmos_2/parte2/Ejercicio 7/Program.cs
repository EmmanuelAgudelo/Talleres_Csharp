using System;

namespace Ejercicio_7
/*
7.	Leer un número e imprimir un mensaje si es par o impar.
*/
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite el número que desea saber si es par o no: ");
            var num = int.Parse(Console.ReadLine());

            if ((num % 2)== 0) {
                System.Console.WriteLine("El número es par.");
            } else {
                System.Console.WriteLine("El número es impar.");
            }
        }
    }
}
