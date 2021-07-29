using System;

namespace algoritmos
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Console.WriteLine("digite su primera nota");
            float nota1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("digite su segunda nota");
            float nota2 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("digite su tercera nota");
            float nota3 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("digite su cuarta nota");
            float nota4 = float.Parse(Console.ReadLine());
            float promedio = (nota1 + nota2 + nota3 + nota1) / 4;
            if (promedio < 3.5)
            {
                System.Console.WriteLine("reporbaste la materia");
            }
        }
    }
}
