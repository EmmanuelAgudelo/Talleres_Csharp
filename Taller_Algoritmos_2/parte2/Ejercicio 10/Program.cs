
// 10.	Una persona enferma y cuyo peso es 70 kg, se encuentra en reposo y desea saber cuántas calorías consume su cuerpo durante el tiempo que realice una misma actividad. Las actividades que puede realizar son únicamente dormir o estar sentado. Los datos que tiene son que estando dormido consume 1.08 calorías por minuto y estando sentado en reposo consume 1.66 calorías por minuto.

using System;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Qué actividad desea realizar?\n1. Dormir\n2. Estar sentado\n\nDigite su opción: ");
            int respuesta = int.Parse(Console.ReadLine());

            double caloriasTotales = 0;
            int calorias = 0;

            switch (respuesta)
            {
                case 1:
                    System.Console.Write("Digite la cantidad de minutos que realiza esta actividad: ");
                    calorias = int.Parse(Console.ReadLine());
                    caloriasTotales = calorias * 1.08;
                    System.Console.WriteLine("La cantidad de calorias consumidas es de: " + caloriasTotales);
                    break;
                case 2:
                    System.Console.Write("Digite la cantidad de minutos que realiza esta actividad: ");
                    calorias = int.Parse(Console.ReadLine());
                    caloriasTotales = calorias * 1.66;
                    System.Console.WriteLine("La cantidad de calorias consumidas es de: " + caloriasTotales);
                    break;
                default:
                    System.Console.WriteLine("Digite una opción correcta");
                    break;
            }

        }
    }
}
