using System;

namespace algoritmos
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Console.WriteLine("digite su estatura");
            float estatura = float.Parse(Console.ReadLine());

            if (estatura > 1.70)
            {
                System.Console.WriteLine("eres una persona alta");
            }
        }
    }
}
