using System;

namespace algoritmos
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite un número");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                System.Console.WriteLine("el número es par");
            }
            else
            {
                System.Console.WriteLine("El número no es par");
            }
        }
    }
}
