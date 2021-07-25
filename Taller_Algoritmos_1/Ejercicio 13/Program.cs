using System;

namespace algoritmos
{
    class Program
    {
        public static void calcularSalario()
        {
            System.Console.WriteLine("digite las horas trabajadas");
            int horasTrabajadas = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite el valor por hora");
            int valorHora = int.Parse(Console.ReadLine());
            int salario = horasTrabajadas * valorHora;
            System.Console.WriteLine("su salario total es: " + salario);
        }
        static void Main(string[] args)
        {
            calcularSalario();
        }
    }
}
