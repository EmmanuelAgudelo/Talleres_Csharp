using System;

namespace algoritmos
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Console.WriteLine("digite un número");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 10)
            {
                System.Console.WriteLine("el triple del numero es: " + (numero * 3));
            }
        }
    }
}
