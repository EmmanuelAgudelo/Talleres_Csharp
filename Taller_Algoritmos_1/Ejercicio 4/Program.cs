using System;

namespace algoritmos
{
    class Program
    {
        public static void notaFinal()
        {
            System.Console.WriteLine("digite la primera nota");
            float nota1 = float.Parse(Console.ReadLine());
            nota1 = nota1 * 0.20;
            System.Console.WriteLine("digite la segunda nota");
            float nota2 = float.Parse(Console.ReadLine());
            nota1 = nota1 * 0.30;
            System.Console.WriteLine("digite la tercera nota");
            float nota3 = float.Parse(Console.ReadLine());
            nota1 = nota1 * 0.50;
            float notaDefinitiva = nota1 + nota2 + nota3;
            System.Console.WriteLine("la nota definitiva es: " + notaDefinitiva);
        }
        static void Main(string[] args)
        {
            notaFinal();
        }
    }
}
