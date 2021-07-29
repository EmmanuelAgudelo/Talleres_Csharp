using System;

namespace algoritmos
{
    class Program
    {
        public static void calcularNota()
        {
            System.Console.WriteLine("digite la calificación de sus notas parciales");
            double notasParciales = float.Parse(Console.ReadLine());
            notasParciales = notasParciales * 0.55;
            System.Console.WriteLine("digite la calificacion de su examen final");
            double examenFinal = float.Parse(Console.ReadLine());
            examenFinal = examenFinal * 0.3;
            System.Console.WriteLine("digite la calificación de su trabajo final");
            double trabajoFinal = float.Parse(Console.ReadLine());
            trabajoFinal = trabajoFinal * 0.15;

            double notaFinal = notasParciales + examenFinal + trabajoFinal;

            System.Console.WriteLine("su nota final es: " + notaFinal);
        }
        static void Main(string[] args)
        {
            calcularNota();
        }
    }
}
