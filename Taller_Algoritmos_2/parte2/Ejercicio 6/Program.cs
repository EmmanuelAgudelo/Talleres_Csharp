using System;

namespace Ejercicio_6
/*
6.	Calcular e imprimir el salario de un empleado, teniendo en cuenta que si el salario bruto es igual o superior a $2.000.000, debe hacerse una retención del 10%, si el salario es inferior, la retención será del 3%.
*/
{
    class Program
    {
        static void Main(string[] args)
        {
            double retencion=0, salarioFinal=0;

            System.Console.WriteLine("Digite su salario: ");
            var salarioBruto = double.Parse(Console.ReadLine());

            if (salarioBruto >= 2000000){
                retencion = salarioBruto * 0.30;
                salarioFinal = salarioBruto - retencion;
                System.Console.WriteLine("El salario brutp del trabajador es: "+ salarioBruto);
                System.Console.WriteLine("El salario final trabajador es: "+ salarioFinal);
            } else {
                retencion = salarioBruto * 0.3;
                salarioFinal = salarioBruto - retencion;
                System.Console.WriteLine("El salario brutp del trabajador es: "+ salarioBruto);
                System.Console.WriteLine("El salario final trabajador es: "+ salarioFinal);
            }
        }
    }
}
