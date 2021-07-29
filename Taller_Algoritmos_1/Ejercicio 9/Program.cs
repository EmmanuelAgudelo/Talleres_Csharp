using System;

namespace algoritmos
{
    class Program
    {
        public static void calcularGanancia()
        {
            System.Console.WriteLine("digite su sueldo base");
            int sueldoBase = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite el valor de la primera venta");
            float venta1 = int.Parse(Console.ReadLine());

            double comision1 = venta1 * 0.1;
            System.Console.WriteLine("digite el valor de la segunda venta");
            int venta2 = int.Parse(Console.ReadLine());

            double comision2 = venta1 * 0.1;
            System.Console.WriteLine("digite el valor de la tercera venta");
            int venta3 = int.Parse(Console.ReadLine());

            double comision3 = venta1 * 0.1;

            double pagoTotal = sueldoBase + comision1 + comision2 + comision3;
            System.Console.WriteLine(
       "El valor de su primera comision es: " + comision1 + ", el de se segunda comision es: " + comision2 +
            "y el de su tercera comision es: " + comision3);
            System.Console.WriteLine("El pago total es: " + pagoTotal);
        }
        static void Main(string[] args)
        {
            calcularGanancia();
        }
    }
}
