using System;

namespace algoritmos
{
    class Program
    {
        public static void calcularTiempoRecorrido()
        {
            System.Console.WriteLine("digite la distancia que va a recorrer");
            int altura = int.Parse(Console.ReadLine());
            int tiempo = parseInt((altura * 5) / 7);

            System.Console.WriteLine("La cantidad de tiempo que le tomara recorrer " + altura + " metros es: " + tiempo + "horas");
        }
        static void Main(string[] args)
        {
            calcularTiempoRecorrido();
        }
    }
}
