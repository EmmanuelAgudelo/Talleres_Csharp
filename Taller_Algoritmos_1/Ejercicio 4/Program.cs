using System;

namespace algoritmos
{
    class Program
    {
        public static void notaFinal()
        {
            System.Console.WriteLine("digite la primera nota");
            double nota1 = float.Parse(Console.ReadLine());
            nota1 = nota1 * 0.20;
            System.Console.WriteLine("digite la segunda nota");
            double nota2 = float.Parse(Console.ReadLine());
            nota2 = nota2 * 0.30;
            System.Console.WriteLine("digite la tercera nota");
            double nota3 = float.Parse(Console.ReadLine());
            nota3 = nota3 * 0.50;
            double notaDefinitiva = nota1 + nota2 + nota3;
            System.Console.WriteLine("la nota definitiva es: " + notaDefinitiva);
        }
        static void Main(string[] args)
        {
            notaFinal();
        }
    }
}
