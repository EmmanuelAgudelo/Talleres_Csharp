using System;

namespace Ejercicio_8
/*
8.	Elaborar un algoritmo que permita calcular el número de pulsaciones que debe tener una persona por cada 10 segundos de ejercicio aeróbico; la fórmula que se aplica cuando el sexo es femenino, es: 
numpulsaciones = (220-edad)/10
y si el sexo es masculino:
numpulsaciones = (210-edad)/10

*/
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPulsaciones = 0;

            System.Console.WriteLine("Para conocer su número de pulsaciones cada 10segundos de ejercicio aeróbico, ingrese. ");
            System.Console.WriteLine("Digite su edad: ");
            var edad = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite 'f' para femenino, y 'm' para masculino.");
            String gen = (Console.ReadLine());

            if (gen.Equals("m", StringComparison.InvariantCultureIgnoreCase)){
                numPulsaciones = (210-edad) / 10;
                System.Console.WriteLine("Su número de pulsaciones por ejercicio aeróbico es: "+ numPulsaciones);
            } else if (gen.Equals("f", StringComparison.InvariantCultureIgnoreCase)){
                numPulsaciones = (220-edad) / 10;
                System.Console.WriteLine("Su número de pulsaciones cada 10segundos por ejercicio aeróbico es: "+ numPulsaciones);
            } else{
                System.Console.WriteLine("Digite un género correcto. Solo existen dos :)");
            }
        }
    }
}
