using System;

namespace ejercicio13
{
    class Program
    {
        static void calcularPagos(double ingresos, double valorVivienda)
        {
            double cuotaInicial = 0, cuotasMensuales = 0;

            if (ingresos >= 1200000)
            {
                cuotaInicial = (valorVivienda * 0.15);
                cuotasMensuales = (((valorVivienda * 0.85) / 120) * 1.02);
            } else
            {
                cuotaInicial = (valorVivienda * 0.30);
                cuotasMensuales = (((valorVivienda * 0.70) / 84) * 1.01);
            }

            Console.WriteLine("La cuota inicial es de: " + cuotaInicial + "\n" +
                "Las cuotas mensuales serán de: " + cuotasMensuales);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Inserte los ingresos mensuales");
            double ingresos = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserte el valor de la vivienda");
            double valorVivienda = double.Parse(Console.ReadLine());

            calcularPagos(ingresos, valorVivienda);

        }
    }
}
