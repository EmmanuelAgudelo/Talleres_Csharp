using System;

namespace algoritmos
{
    class Program
    {
        public static void suma()
        {
            System.Console.WriteLine("digite un número");
            int numero1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite otro número");
            int numero2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite otro número");
            int numero3 = int.Parse(Console.ReadLine());
            int suma = numero1 + numero2 + numero3;
            System.Console.WriteLine("la suma de los números es: " + suma);
        }
        static void Main(string[] args)
        {
            suma();
        }
    }
}
