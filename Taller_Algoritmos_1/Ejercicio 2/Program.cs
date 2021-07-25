using System;

namespace algoritmos
{
    class Program
    {
        public static void operaciones()
        {
            System.Console.WriteLine("digite un número");
            int numero1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite otro número");
            int numero2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("la suma de ambos números es: " + (numero1 + numero2));
            System.Console.WriteLine("la resta de ambos números es: " + (numero1 - numero2));
            System.Console.WriteLine("la multiplicación de ambos números es: " + (numero1 * numero2));
            System.Console.WriteLine("la divbisión de ambos números es: " + (numero1 / numero2));
        }
        static void Main(string[] args)
        {
            operaciones();
        }
    }
}
