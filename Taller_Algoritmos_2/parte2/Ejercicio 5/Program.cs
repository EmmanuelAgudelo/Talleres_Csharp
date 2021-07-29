using System;

namespace Ejercicio_5
/* 
5.	Determinar el precio de un pasaje de ida y vuelta por avión, conociendo la distancia a recorrer y sabiendo que que esta es superior a 1.000 km, la línea aérea le hace un descuento del 30%. El precio por kilómetro es de $150.
*/
{
    class Program
    {
        static void Main(string[] args)
        {
            Double pagoInicial, descuento, pagoFinal;

            System.Console.WriteLine("Digite la distancia en kilometros a recorrer, para determinar el precio de su pasaje: ");
            double numKm = double.Parse(Console.ReadLine());

            if (numKm >= 1000){
                pagoInicial = numKm * 150;
                descuento = pagoInicial * 0.30;
                pagoFinal = pagoInicial - descuento;

                System.Console.WriteLine("El valor de su viaje es: " + pagoInicial);
                System.Console.WriteLine("Descuento: "+ pagoFinal);
            } else{
                pagoInicial = numKm * 150;
                descuento = 0;
                pagoFinal = pagoInicial - descuento;

                System.Console.WriteLine("El valor de su viaje es: $" + pagoInicial);
                System.Console.WriteLine("Descuento: $"+ pagoFinal);
            }
        }
    }
}
