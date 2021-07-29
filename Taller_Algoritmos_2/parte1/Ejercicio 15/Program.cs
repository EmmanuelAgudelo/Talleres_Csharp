using System;

namespace algoritmos
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Console.WriteLine("digite un numero");
            int numero = int.Parse(Console.ReadLine());
            if (numero > 10)
            {
                int numeroCubo = numero * numero * numero;
                System.Console.WriteLine("el cubo del numero es: " + numeroCubo);
            }
        }
    }
}
