using System;

namespace Ejercicio_3
/*
3.	Elabore un algoritmo que lea un número y si este es mayor o igual a 10 devuelva el triple de este de lo contrario la cuarta parte de este.
*/
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            System.Console.WriteLine("Digite un número: ");
            int num = int.Parse(Console.ReadLine());

            if (num >= 10){
                result = Math.Pow(num,3);
                System.Console.WriteLine("El resultado: " + result);
            } else{
                result = (num * 1) / 4f;
                System.Console.WriteLine("El resultado: " + result);
            }
        }
    }
}
