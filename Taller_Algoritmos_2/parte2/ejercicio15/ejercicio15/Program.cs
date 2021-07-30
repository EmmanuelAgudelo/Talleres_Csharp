using System;

namespace ejercicio15
{
    class Program
    {
        static double calcularDescuento(double total)
        {
            double resultado;

            if (total >= 200000) resultado = (total - total * 0.17);
            else resultado = (total - total * 0.05);

            return resultado;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor de la compra: ");
            double resultado = calcularDescuento(double.Parse(Console.ReadLine()));
            Console.WriteLine("El total a pagar es: " + resultado);

        }
    }
}
