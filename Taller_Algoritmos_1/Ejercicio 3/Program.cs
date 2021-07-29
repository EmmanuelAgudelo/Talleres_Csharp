using System;

namespace algoritmos
{
    class Program
    {
        public static void promedioNotas()
        {
            System.Console.WriteLine("digite la primera nota");
            float nota1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("digite la segunda nota");
            float nota2 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("digite la tercera nota");
            float nota3 = float.Parse(Console.ReadLine());
            float notaDefinitiva = (nota1 + nota2 + nota3) / 3;
            System.Console.WriteLine("la nota definitiva es: " + notaDefinitiva);
        }
        static void Main(string[] args)
        {
            promedioNotas();
        }
    }
}
