using System;

namespace algoritmos
{
    class Program
    {
        public static void calcularSegundos()
        {
            System.Console.WriteLine("digite las horas");
            int horas = int.Parse(Console.ReadLine());
            horas = horas * 3600;
            System.Console.WriteLine("digite los minutos");
            int minutos = int.Parse(Console.ReadLine());
            minutos = minutos * 60;
            System.Console.WriteLine("digite los segundos");
            int segundos = int.Parse(Console.ReadLine());

            int segundosTotales = horas + minutos + segundos;
            System.Console.WriteLine("El tiempo en segundos es: " + segundosTotales);
        }
        static void Main(string[] args)
        {
            calcularSegundos();
        }
    }
}
