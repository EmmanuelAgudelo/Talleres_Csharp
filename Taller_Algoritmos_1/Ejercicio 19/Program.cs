using System;

namespace algoritmos
{
    class Program
    {
        public static void calcularpromedioFinal()
        {
            System.Console.WriteLine("digite su nombre");
            String nombre = Console.ReadLine();
            System.Console.WriteLine("digite su primera nota");
            float nota1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("digite su segunda nota");
            float nota2 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("digite su tercera nota");
            float nota3 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("digite su cuarta nota");
            float nota4 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("digite su quinta nota");
            float nota5 = float.Parse(Console.ReadLine());

            float sumaNotas = nota1 + nota2 + nota3 + nota4 + nota5;
            float promedio = somaNotas / 5;

            System.Console.WriteLine("digite su programa de formación");
            String programa = Console.ReadLine();
            System.Console.WriteLine("digite su ficha");
            String ficha = Console.ReadLine();
            System.Console.WriteLine(nombre + ", inscrito en el programa: " + programa + "con ficha: " + ficha + "su nota promedio final es: " + promedio);

        }
        static void Main(string[] args)
        {
            calcularpromedioFinal();
        }
    }
}
