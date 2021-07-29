using System;

namespace algoritmos
{
    class Program
    {
        public static void calcularPrecioNeto()
        {
            System.Console.WriteLine("digite el valor por unidad del producto");
            int precioUnitario = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite la cantidad que va a llevar del producto");
            int cantidadProducto = int.Parse(Console.ReadLine());
            int subtotal = precioUnitario * cantidadProducto;
            double iva = subtotal * 0.19;
            double precioNeto = subtotal + iva;

            System.Console.WriteLine("el precio por unidad de este producto es: " + precioUnitario + ", la cantidad a llevar de este producto es: " + cantidadProducto + ", el subtotal es: " + subtotal + ", el monto del iva es: " + iva +
            "y el precio neto es: " + precioNeto);
        }
        static void Main(string[] args)
        {
            calcularPrecioNeto();
        }
    }
}
