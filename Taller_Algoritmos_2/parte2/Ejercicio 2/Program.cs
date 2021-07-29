using System;

namespace Ejercicio2
/*
2.	Hacer un algoritmo que calcule el total a pagar por la compra de camisas. Si se compran tres camisas o 
más se aplica un descuento del 20% sobre el total de la compra y si son menos de tres camisas un descuento  
del 10%
*/
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("¿Cuántas camisas desea regitrar?");
            int productos = int.Parse(Console.ReadLine());
            int i = 0;
            double  totalCamisas = 0; 
            double descuento= 0;
            double precioFinal;

            while (productos > i){               
                System.Console.WriteLine("Digite el precio de la camisa "+(i+1)+":");
                Double precioCamisa = double.Parse(Console.ReadLine());
                totalCamisas += precioCamisa;
                i++;
            }

            if (productos >= 3){
                descuento = totalCamisas * 0.20;
                precioFinal = totalCamisas - descuento;
                System.Console.WriteLine("Total de camisas: " + productos);
                System.Console.WriteLine("Valor sin descuento: "+ totalCamisas);
                System.Console.WriteLine("Valor con descuento: "+ precioFinal);
            } else{
                descuento = totalCamisas * 0.10;
                precioFinal = totalCamisas - descuento;
                System.Console.WriteLine("Total de camisas: " + productos);
                System.Console.WriteLine("Valor sin descuento: "+ totalCamisas);
                System.Console.WriteLine("Valor con descuento: "+ precioFinal);
            }
            
        }
    }
}
