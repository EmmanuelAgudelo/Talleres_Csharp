// 11.	Una empresa desea hacer una compra de varias piezas de la misma clase a una fábrica. La empresa, dependiendo del valor de la compra, decidirá la forma en que le pagará al fabricante. Si el valor de la compra excede o es igual a $5.000.000, la empresa tendrá la capacidad de pagar con recursos propios el 55% del valor de la compra, pedirá prestado a un banco el 30% y el resto lo pagará solicitando un crédito al fabricante. Si el monto total de la compra no excede de $5.000.000, la empresa tendrá la capacidad de pagar con recursos propios un 70% y el 30% restante, lo pagará solicitando un crédito al fabricante. El fabricante cobra un 15% de interés sobre la cantidad que le pague a crédito.

using System;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite el valor de su compra: ");
            int valorCompra = int.Parse(Console.ReadLine());

            double recursosEmpresa = 0, prestamoBanco = 0, creditoFabricante = 0, interesesFabricante = 0;


            if (valorCompra >= 5000000)
            {
                recursosEmpresa = valorCompra * 0.55;
                prestamoBanco = valorCompra * 0.3;
                creditoFabricante = valorCompra - (recursosEmpresa + prestamoBanco);
                interesesFabricante = creditoFabricante * 0.15;

                System.Console.WriteLine("\nEl pago se hará de la siguiente forma:\n\n---La empresa pagará: " + recursosEmpresa + "\n---El prestamo del banco será de: " + prestamoBanco + "\n---Créditos del fabricante: " + creditoFabricante + "\n---Intereses de los creditos del fabicante: " + interesesFabricante);
            }
            else
            {
                recursosEmpresa = valorCompra * 0.7;
                creditoFabricante = valorCompra * 0.3;
                interesesFabricante = creditoFabricante * 0.15;

                System.Console.WriteLine("\nEl pago se hará de la siguiente forma:\n---La empresa pagará: " + recursosEmpresa + "\n---Créditos del fabricante: " + creditoFabricante + "\n---Intereses de los creditos del fabicante: " + interesesFabricante);
            }
        }
    }
}
