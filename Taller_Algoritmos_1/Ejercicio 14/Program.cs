using System;

namespace algoritmos
{
    class Program
    {
        public static void CalcularFactura()
        {
            System.Console.WriteLine("digite el valor del primer articulo");
            int articulo1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite cuantas unidades va a llevar");
            int cantidadArticulo1 = int.Parse(Console.ReadLine());

            System.Console.WriteLine("digite el valor del segundo articulo");
            int articulo2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite cuantas unidades va a llevar");
            int cantidadArticulo2 = int.Parse(Console.ReadLine());

            System.Console.WriteLine("digite el valor del tercero articulo");
            int articulo3 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite cuantas unidades va a llevar");
            int cantidadArticulo3 = int.Parse(Console.ReadLine());

            System.Console.WriteLine("digite el valor del cuarto articulo");
            int articulo4 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite cuantas unidades va a llevar");
            int cantidadArticulo4 = int.Parse(Console.ReadLine());



            articulo1 = articulo1 * cantidadArticulo1;
            articulo2 = articulo2 * cantidadArticulo2;
            articulo3 = articulo3 * cantidadArticulo3;
            articulo4 = articulo4 * cantidadArticulo4;

            int valorFactura = articulo1 + articulo2 + articulo3 + articulo4;

            int iva = valorFactura * 0.19;

            valorFactura = valorFactura + iva;

            System.Console.WriteLine("El valor total a pagar es: " + valorFactura);
        }
        static void Main(string[] args)
        {
            CalcularFactura();
        }
    }
}
