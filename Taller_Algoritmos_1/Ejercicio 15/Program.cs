using System;

namespace algoritmos
{
    class Program
    {
        public static void calcularCambio()
        {
            System.Console.WriteLine("digite el valor de la venta");
            int venta = int.Parse(Console.ReadLine());
            int iva = venta * 0.19;
            venta = venta + iva;
            System.Console.WriteLine("El iva del producto equivale a: " + iva + "y el dinero a pagar es: " + venta);
            System.Console.WriteLine("digite el dinero entregado por el cliente");

            int dineroCliente = int.Parse(Console.ReadLine());
            int cambio = dineroCliente - venta;
            System.Console.WriteLine("su cambio es: " + cambio);
        }
        static void Main(string[] args)
        {
            calcularCambio();
        }
    }
}
