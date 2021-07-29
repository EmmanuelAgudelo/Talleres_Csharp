using System;

namespace Ejercicio1
/*
1.	Hacer un algoritmo que imprima el nombre de un artículo, clave, precio original y su precio con descuento. 
El descuento lo hace en base a la clave, si la clave es 01 el descuento es del 10% y si la clave es 02 
el descuento es del 20% (solo existen dos claves).
*/
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite el nombre del producto: ");
            String name_Prod = (Console.ReadLine());
            System.Console.WriteLine("Clave del producto: ");
            int clave = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Precio del producto: ");
            double precio_p = double.Parse(Console.ReadLine());

            if (clave == 01){
                //Descuento del 10%
                double descuento = precio_p * 0.10;
                double valorFinal = precio_p - descuento;
                System.Console.WriteLine("Nombre Artículo: " + name_Prod);
                System.Console.WriteLine("Clave: "+clave);
                System.Console.WriteLine("Precio Artículo: "+precio_p);
                System.Console.WriteLine("Precio Artículo con descuento: "+valorFinal);
            } else if (clave == 02){
                //Descuento del 20%
                double descuento = precio_p * 0.20;
                double valorFinal = precio_p - descuento;
                System.Console.WriteLine("Nombre Artículo: " + name_Prod);
                System.Console.WriteLine("Clave: "+clave);
                System.Console.WriteLine("Precio Artículo: "+precio_p);
                System.Console.WriteLine("Precio Artículo con descuento: "+valorFinal);
            } else{
                System.Console.WriteLine("Nombre Artículo: " + name_Prod);
                System.Console.WriteLine("Clave: "+clave);
                System.Console.WriteLine("Precio Artículo: "+precio_p);
            }           
        }
    }
}
