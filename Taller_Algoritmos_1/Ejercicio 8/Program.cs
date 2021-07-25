using System;

namespace algoritmos
{
    class Program
    {
        public static void calcularGanancia()
        {
            System.Console.WriteLine("digite el capital invertido");
            float capital = float.Parse(Console.ReadLine());
            float ganancia = capital * 0.02;
            System.Console.WriteLine("La ganancia genera es:" + ganancia);
        }
        static void Main(string[] args)
        {
            calcularGanancia();
        }
    }
}
