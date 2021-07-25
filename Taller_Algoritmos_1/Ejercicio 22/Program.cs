using System;

namespace algoritmos
{
    class Program
    {
        public static void calcularTiempoValdes()
        {
            System.Console.WriteLine("¿Quiere digitar el tamaño de los valdes?");
            String pregunta = Console.ReadLine();

            if (pregunta.Equals("si"))
            {
                int size1 = 1;
                System.Console.WriteLine("digite el tamaño del valde");
                int size2 = int.Parse(Console.ReadLine());
                System.Console.WriteLine("digite el tamaño del otro valde");
                int size3 = int.Parse(Console.ReadLine());
                int valde1 = 90;
                int valde2 = valde1 * size2;
                int valde3 = valde1 * size3;
                System.Console.WriteLine("El valde de " + size1 + " litro se demora en llenar " + valde1 + " minutos, el valde de " + size2 + " litros se demora en llenar " + valde2 + " minutos y el valde de" + size3 + " litros se demora en llenar " + valde3 + "minutos");
            }
            else
            {
                int size1 = 1;
                int size2 = 3;
                int size3 = 5;

                int valde1 = 90;
                int valde2 = valde1 * size2;
                int valde3 = valde1 * size3;

                System.Console.WriteLine("El valde de " + size1 + " litro se demora en llenar " + valde1 + " minutos, el valde de " + size2 + " litros se demora en llenar " + valde2 + " minutos y el valde de" + size3 + " litros se demora en llenar " + valde3 + "minutos");

            }
            static void Main(string[] args)
            {
                calcularTiempoValdes();
            }
        }
    }
}
