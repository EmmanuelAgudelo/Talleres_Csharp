using System;

namespace algoritmos
{
    class Program
    {
        public static void valorTotal()
        {
            System.Console.WriteLine("digite el valor de la compra");

            double compra = int.Parse(Console.ReadLine());
            double descuento = compra * 0.1;
            compra = compra - descuento;
            double iva = compra * 0.19;
            compra = compra + iva;
            System.Console.WriteLine("El valor total de la compra es: " + compra);
        }
        static void Main(string[] args)
        {
            valorTotal();
        }
    }
}
