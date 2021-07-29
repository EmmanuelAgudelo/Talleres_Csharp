using System;

namespace algoritmos
{
    class Program
    {
        public static void calcularEdad()
        {
            System.Console.WriteLine("digite el nombre del aprendiz");
            String nombre = Console.ReadLine();
            System.Console.WriteLine("digite la fecha de nacimiento del aprendiz asi xxxx/xx/xx");
            DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());
            System.Console.WriteLine("digite la dirección del aprendiz");
            String direccion = Console.ReadLine();
            int edad = DateTime.Today.Year - fechaNacimiento.Year;
            System.Console.WriteLine("el nombre del aprendiz es: " + nombre + " su fecha de nacimiento es: " + fechaNacimiento + " tiene " + edad + " años y su dirección es: " + direccion);

        }
        static void Main(string[] args)
        {
            calcularEdad();
        }
    }
}
