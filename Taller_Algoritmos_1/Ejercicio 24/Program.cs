using System;

namespace algoritmos
{
    class Program
    {
        public static void calcularIntereses()
        {
            System.Console.WriteLine("digite el monto del prestamo");
            int montoPrestamo = int.Parse(Console.ReadLine());
            double interesesAnuales = montoPrestamo * 0.05;
            double interesMensual = interesesAnuales * 0.12;
            double primerMes = interesesAnuales * 0.12;
            double firstYear = interesMensual * 12;
            double trimestre = interesMensual * 9;
            double total = montoPrestamo + interesesAnuales * 5;

            System.Console.WriteLine("El monto del prestamo es: " + montoPrestamo + ", en el primer año se pagaron " + firstYear + " de intereses, en el tercer trimestre del año se pagaron " + trimestre + " de intereses, en el primer mes se pagaron " + primerMes + " de interes, y el valor a pagar del prestamo incluyendo los interes es: " + total
    );
        }
        static void Main(string[] args)
        {
            calcularIntereses();
        }
    }
}
