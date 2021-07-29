using System;

namespace algoritmos
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Console.WriteLine("digite un número");
            int numero1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite otro número");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                System.Console.WriteLine("la suma de los dos números es: " + (numero1 + numero2));
            }
        }
    }
}
