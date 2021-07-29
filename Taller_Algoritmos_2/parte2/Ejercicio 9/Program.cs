using System;

namespace Ejercicio_9
/*
9.	Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente manera: 
Si trabaja 40 horas o menos, se le paga a $10.000 la hora
Si trabaja más de 40 horas, se le paga $10.000 por cada una de las primeras 40 horas y $15.000 por cada una de las horas extras.

*/
{
    class Program
    {
        static void Main(string[] args)
        {
            double Salario = 0, valorHExtra = 0;
            int horasExtras = 0;

            System.Console.WriteLine("Digite su número de horas trabajadas esta semana, para conocer su salario semanal: ");
            var numHoras =  int.Parse(Console.ReadLine());

            if (numHoras <= 40){
                Salario = numHoras * 10000;
                System.Console.WriteLine("Su salario semanal es: " + Salario);
            } else {
                horasExtras = numHoras - 40;
                valorHExtra = horasExtras * 15000;
                Salario = (numHoras * 10000) + valorHExtra;
                System.Console.WriteLine("Valor de horas extras: "+ valorHExtra);
                System.Console.WriteLine("Su salario semanal es: " + Salario);
            }
        }
    }
}
