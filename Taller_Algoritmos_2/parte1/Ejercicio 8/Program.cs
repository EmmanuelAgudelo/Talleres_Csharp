using System;

namespace algoritmos
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Console.WriteLine("digite la cantidad de dinero que tiene invertida en el banco");
            int capital = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite la cantidad el porcentaj de intereses que genera en el banco");
            int porcentajeIntereses = (int.Parse(Console.ReadLine())) / 100;
            int intereses = (int)(capital * porcentajeIntereses);

            if (intereses < 7000)
            {
                capital += (int)(intereses);
            }

            System.Console.WriteLine("su capital es:" + capital);
        }
    }
}
