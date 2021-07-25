using System;

namespace algoritmos
{
    class Program
    {
        public static void calcularIntereses()
        {
            System.Console.WriteLine("digite el monto del prestamo");
            int montoPrestamo = int.Parse(Console.ReadLine());
            int interesesAnuales = montoPrestamo * 0.05;
            int interesMensual = int.Parse(interesesAnuales * 0.12);
            int primerMes = int.Parse(interesesAnuales * 0.12);
            int firstYear = interesMensual * 12;
            int trimestre = interesMensual * 9;
            int total = montoPrestamo + interesesAnuales * 5;

            System.Console.WriteLine("El monto del prestamo es: " + montoPrestamo + ", en el primer año se pagaron " + firstYear + " de intereses, en el tercer trimestre del año se pagaron " + trimestre + " de intereses, en el primer mes se pagaron " + primerMes + " de interes, y el valor a pagar del prestamo incluyendo los interes es: " + total
    );
        }
        static void Main(string[] args)
        {
            calcularIntereses();
        }
    }
}
