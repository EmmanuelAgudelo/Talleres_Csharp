using System;

namespace algoritmos
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Console.WriteLine("digite el valor de la compra");
            int valorCompra = int.Parse(Console.ReadLine());

            if (valorCompra > 100000)
            {
                int descuento = (int)(valorCompra * 0.20);
                valorCompra = valorCompra - descuento;
            }
            System.Console.WriteLine("el valor de la compra es:" + valorCompra);
        }
    }
}
