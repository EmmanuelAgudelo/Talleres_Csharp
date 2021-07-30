using System;

namespace ejercicio14
{
    class Program
    {

        static int leerNumero(int n)
        {
            int resultado;

            if ((n % 2) == 0) resultado = (n * n);
            else resultado = (n * 3);

            return resultado;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero para leer: ");
            int resultado = leerNumero(int.Parse(Console.ReadLine()));

            Console.WriteLine("El resultado es: " + resultado);

        }
    }
}
