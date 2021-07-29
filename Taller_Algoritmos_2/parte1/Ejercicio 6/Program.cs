using System;

namespace algoritmos
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Console.WriteLine("digite su salario");
            float salario = float.Parse(Console.ReadLine());
            if (salario > 2000000)
            {
                float retencion = (float)(salario * 0.10);
                salario = salario - retencion;

            }

            System.Console.WriteLine("su salario es:" + salario);
        }

    }
}
