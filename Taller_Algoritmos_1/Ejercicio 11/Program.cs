using System;

namespace algoritmos
{
    class Program
    {
        public static void calcularNota()
        {
            System.Console.WriteLine("digite la calificación de sus notas parciales");
            float notasParciales = float.Parse(Console.ReadLine());
            notasParciales = notasParciales * 0.55;
            System.Console.WriteLine("digitr la calificacion de su examen final");
            float examenFinal = float.Parse(Console.ReadLine());
            examenFinal = examenFinal * 0.3;
            System.Console.WriteLine("digite la calificación de su trabajo final");
            float trabajoFinal = float.Parse(Console.ReadLine());
            trabajoFinal = trabajoFinal * 0.15;

            float notaFinal = notasParciales + examenFinal + trabajoFinal;

            System.Console.WriteLine("`su nota final es: " + notaFinal);
        }
        static void Main(string[] args)
        {
            calcularNota();
        }
    }
}
