using System;

namespace algoritmos
{
    class Program
    {
        public static void calcularCompra()
        {
            System.Console.WriteLine("digite el valor de la compra");
            double compra = int.Parse(Console.ReadLine());
            double descuento = compra * 0.15;
            compra = compra - descuento;
            System.Console.WriteLine("El valor total de la compra con el descuento es: " + compra);
        }
        static void Main(string[] args)
        {
            calcularCompra();
        }
    }
}
