using System;

namespace algoritmos
{
    class Program
    {
        public static void valorTotal()
        {
            System.Console.WriteLine("digite el valor de la compra");

            int compra = int.Parse(Console.ReadLine());
            int descuento = compra * 0.1;
            compra = compra - descuento;
            int iva = compra * 0.19;
            compra = compra + iva;
            System.Console.WriteLine("El valor total de la compra es: " + compra);
        }
        static void Main(string[] args)
        {
            valorTotal();
        }
    }
}
