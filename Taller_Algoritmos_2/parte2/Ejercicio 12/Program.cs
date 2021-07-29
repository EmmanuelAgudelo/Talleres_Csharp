// 12.	Elaborar un algoritmo que permita calcular el valor total a pagar en una papelería teniendo en cuenta que, si lleva 5 cuadernos o más, se le cobrarán $2.000 por cada uno, mientras que, si lleva menos, se le cobrarán $2.500 por cada uno.

using System;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite la cantidad de cuadernos que desea llevar: ");
            int cantidadCuadernos = int.Parse(Console.ReadLine());

            int precioCuadernos = 0;

            if (cantidadCuadernos >= 5)
            {
                precioCuadernos = cantidadCuadernos * 2000;
                System.Console.WriteLine("El precio de los cuadernos es de: " + precioCuadernos);
            }
            else
            {
                precioCuadernos = cantidadCuadernos * 2500;
                System.Console.WriteLine("El precio de los cuadernos es de: " + precioCuadernos);
            }
        }
    }
}
