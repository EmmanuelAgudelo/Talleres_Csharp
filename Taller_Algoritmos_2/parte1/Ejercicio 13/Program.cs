using System;

namespace algoritmos
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Console.WriteLine("digite el valor de la computadora");
            int valorComputadora = int.Parse(Console.ReadLine());
            int iva = (int)(valorComputadora * 0.19);
            valorComputadora += iva;
            if (valorComputadora > 1000000)
            {
                int descuento = (int)(valorComputadora * 0.10);
                valorComputadora = valorComputadora - descuento;
            }

            System.Console.WriteLine("el valor de la computadora es: " + valorComputadora);
        }
    }
}
