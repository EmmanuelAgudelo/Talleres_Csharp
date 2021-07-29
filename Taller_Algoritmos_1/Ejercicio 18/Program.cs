using System;

namespace algoritmos
{
    class Program
    {
        public static void calcularCuotas()
        {
            System.Console.WriteLine("digite el valor de su matricula");
            int matricula = int.Parse(Console.ReadLine());

            double cuota1 = matricula * 0.4;
            double cuota2 = matricula * 0.25;
            double cuota3 = matricula * 0.2;
            double cuota4 = matricula * 0.15;

            ;
            System.Console.WriteLine("el valor de su primera cuota es: " + cuota1 + ", el valor de su segunda cuota es: " + cuota2 + ", el valor de su tercara cuota es: " + cuota3 + "y el valor de su cuarta cuota es: " + cuota4);
        }
        static void Main(string[] args)
        {
            calcularCuotas();
        }
    }
}
