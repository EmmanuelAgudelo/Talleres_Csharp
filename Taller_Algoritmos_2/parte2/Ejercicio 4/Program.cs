using System;

namespace Ejercicio_4
/*
4.	Hacer un algoritmo que lea dos números y los imprima en orden ascendente.
*/
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite el primer número: ");
            int num1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 < num2){
                System.Console.WriteLine("el orden ascendente es: "+ num1 + " - "+ num2);
            } else if (num2 < num1){
                System.Console.WriteLine("el orden ascendente es: "+ num2 + " - "+ num1);
            } else {
                System.Console.WriteLine("Digite dos número diferentes para organizarlos.");
            }
    
        }
    }
}
