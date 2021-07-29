using System;

namespace algoritmos
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Console.WriteLine("digite el valor del producto");
            int valor = int.Parse(Console.ReadLine());
            if (valor > 1000000)
            {
                int iva = (int)(valor * 0.19);
                int descuento = (int)(valor * 0.10);
                valor = valor + iva;
                valor = valor - descuento;
            }

            System.Console.WriteLine("el valor total de la compra es:" + valor);
        }
    }
}
