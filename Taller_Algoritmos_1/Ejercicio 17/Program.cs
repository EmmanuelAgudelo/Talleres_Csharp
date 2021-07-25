using System;

namespace algoritmos
{
    class Program
    {
        public static void calcularSalarioTotal()
        {
            System.Console.WriteLine("digite su salario");
            int salario = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite su ahorro");
            int ahorro = int.Parse(Console.ReadLine());
            int eps = salario * 0.125;
            int fondoPension = salario * 0.19;
            int salarioTotal = salario - ahorro - eps - fondoPension;

            System.Console.WriteLine("su salario base es: " + salario + ", su ahorro mensual programado es: " + ahorro + ", el valor a dar por aporte a salud es: " + eps + ", el valor a dar para el fondo de pensión es: " + fondoPension +
            "y el total a recibir es: " + salarioTotal);
        }
        static void Main(string[] args)
        {
            calcularSalarioTotal();
        }
    }
}
