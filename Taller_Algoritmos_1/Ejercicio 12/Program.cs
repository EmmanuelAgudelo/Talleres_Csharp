using System;

namespace algoritmos
{
    class Program
    {
        public static void calcularAlumnos()
        {
            System.Console.WriteLine("digite la cantidad de alumnos");
            int cantidadAlumnos = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite la cantidad de hombres en el salón");
            int cantidadHombres = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite la cantidad de mujeres en el salón");
            int cantidadMujeres = int.Parse(Console.ReadLine());

            float porcentajeHombres = (cantidadHombres * 100) / cantidadAlumnos;
            float porcentajeMujeres = (cantidadMujeres * 100) / cantidadAlumnos;

            System.Console.WriteLine("El porcentaje de hombres es: " + porcentajeHombres + "%  y el porcentaje de mujeres es: " + porcentajeMujeres + "%");
        }
        static void Main(string[] args)
        {
            calcularAlumnos();
        }
    }
}
