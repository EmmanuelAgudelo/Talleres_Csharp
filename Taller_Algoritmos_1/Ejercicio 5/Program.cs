using System;

namespace algoritmos
{
    class Program
    {
        public static void calcularVelocidad()
        {
            System.Console.WriteLine("digite la distancia recorrida");
            float distancia = float.Parse(Console.ReadLine());
            System.Console.WriteLine("digite el tiempo en el que recorrió dicha distancia");
            float tiempo = float.Parse(Console.ReadLine());
            float velocidad = distancia / tiempo;
            System.Console.WriteLine("la velocidad a la que se desplazaba era: " + velocidad + "k/h");
        }
        static void Main(string[] args)
        {
            calcularVelocidad();
        }
    }
}
