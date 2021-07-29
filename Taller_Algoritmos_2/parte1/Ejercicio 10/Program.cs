using System;

namespace algoritmos
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Console.WriteLine("digite su edad");
            int edad = int.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                System.Console.WriteLine("eres mayor de edad");
            }
        }
    }
}
