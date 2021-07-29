using System;

namespace algoritmos
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Console.WriteLine("digite un número");
            float numero = float.Parse(Console.ReadLine());
            if (numero < 0)
            {
                System.Console.WriteLine("el numero es negativo");
            }
        }
    }
}
