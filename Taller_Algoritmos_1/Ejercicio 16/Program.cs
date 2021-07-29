using System;

namespace algoritmos
{
    class Program
    {
        public static void calcularRecaudo()
        {
            System.Console.WriteLine("digite el recaudo total");
            int recaudo = int.Parse(Console.ReadLine());
            double dineroConductor = recaudo * 0.19;

            System.Console.WriteLine("El dinero ganado por el conductor es: " + dineroConductor);
        }
        static void Main(string[] args)
        {
            calcularRecaudo();
        }
    }
}
