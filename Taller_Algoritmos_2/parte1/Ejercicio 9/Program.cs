using System;

namespace algoritmos
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Console.WriteLine("digite un numero");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 5 == 0)
            {
                System.Console.WriteLine("el número es múltiplo de 5");
            }
        }
    }
}
