using System;

namespace algoritmos
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Console.WriteLine("digite un numero");
            int numero1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite otro numero");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                System.Console.WriteLine("La suma de los dos números es: " + (numero1 + numero2));
            }
        }
    }
}
