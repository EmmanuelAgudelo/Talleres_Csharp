using System;

namespace Switch_For
{
    class Program
    {


        static void Main(string[] args)
        {

            int respuesta = 0;

            System.Console.Write("1. Ejercicio 1\n2. Ejercicio 2\n3. Ejercicio 3\n4. Ejercicio 4\n5. Salir del programa\nElija una opción para ejecutar: ");
            respuesta = int.Parse(Console.ReadLine());

            Boolean iniciar = true;

            while (iniciar)
            {

                switch (respuesta)
                {
                    case 1:
                        Ejercicio_1();
                        break;
                    case 2:
                        Ejercicio_2();
                        break;
                    case 3:
                        Ejercicio_3();
                        break;
                    case 4:
                        Ejercicio_4();
                        break;
                    case 5:
                        System.Console.WriteLine("\nSaliendo del programa.....");
                        iniciar = false;
                        break;

                    default:
                        System.Console.WriteLine("\n++++++Introduce una opción correcta++++++\n");
                        break;
                }

                if (iniciar)
                {
                    System.Console.Write("\n\n1. Ejercicio 1\n2. Ejercicio 2\n3. Ejercicio 3\n4. Ejercicio 4\n5. Salir del programa\nElija un ejercicio para ejecutar: ");
                    respuesta = int.Parse(Console.ReadLine());
                }

            }
        }



        // 1.	Realizar un programa que nos pida un número n, y nos diga cuantos números hay entre 1 y n que son primos.
        public static void Ejercicio_1()
        {
            int contador = 0;

            System.Console.Write("\n-----------Números primos-----------\nDigite un número: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                if (!((i % 2) == 0))
                {
                    contador++;
                }

            }
            System.Console.WriteLine("\nHay " + contador + " números impares entre el 1 y el " + numero);
        }


        // 2.	Pedir un número N, introducir N sueldos, y mostrar el sueldo máximo.
        public static void Ejercicio_2()
        {

            System.Console.Write("\n-----------Sueldo mayor-----------\nIngrese el número de suledos que desea introducir: ");
            int numSueldos = int.Parse(Console.ReadLine());

            int[] sueldos = new int[numSueldos];

            for (int i = 0; i < numSueldos; i++)
            {
                System.Console.Write("\nIngrese el sueldo " + (i + 1) + ": ");
                sueldos[i] = int.Parse(Console.ReadLine());
            }

            int mayor = 0, menor = 0;
            mayor = menor = sueldos[0];

            for (int i = 0; i < sueldos.Length; i++)
            {
                if (sueldos[i] > mayor)
                {
                    mayor = sueldos[i];
                }
            }

            System.Console.WriteLine("\n----El sueldo mayor es: " + mayor);
        }



        public static void Ejercicio_3()
        {

            int num = 0, unidad = 0, decena = 0;
            String uni = "", sobreD = "", dec = "";

            System.Console.Write("\n--------De número a texto-------\nIngresa un numero: ");
            num = int.Parse(Console.ReadLine());

            decena = num / 10;
            unidad = (num % 10) / 1;

            if (unidad == 1)
                uni = "uno";
            else if (unidad == 2)
                uni = "dos";
            else if (unidad == 3)
                uni = "tres";
            else if (unidad == 4)
                uni = "cuatro";
            else if (unidad == 5)
                uni = "cinco";
            else if (unidad == 6)
                uni = "seis";
            else if (unidad == 7)
                uni = "siete";
            else if (unidad == 8)
                uni = "ocho";
            else if (unidad == 9)
                uni = "nueve";

            if (decena == 1 && unidad == 0)
                sobreD = "diez";
            else if (decena == 1 && unidad == 1)
                sobreD = "once";
            else if (decena == 1 && unidad == 2)
                sobreD = "doce";
            else if (decena == 1 && unidad == 3)
                sobreD = "trece";
            else if (decena == 1 && unidad == 4)
                sobreD = "catorce";
            else if (decena == 1 && unidad == 5)
                sobreD = "quince";
            else if (decena == 1 && unidad == 6)
                sobreD = "dieciseis";
            else if (decena == 1 && unidad == 7)
                sobreD = "diecisiete";
            else if (decena == 1 && unidad == 8)
                sobreD = "dieciocho";
            else if (decena == 1 && unidad == 9)
                sobreD = "diecinueve";

            if (decena == 2)
                dec = "veinte";
            else if (decena == 3)
                dec = "treinta";
            else if (decena == 4)
                dec = "cuarenta";
            else if (decena == 5)
                dec = "cincuenta";
            else if (decena == 6)
                dec = "sesenta";
            else if (decena == 7)
                dec = "setenta";
            else if (decena == 8)
                dec = "ochenta";
            else if (decena == 9)
                dec = "noventa";

            if (num < 10)
                System.Console.WriteLine("\nEl numero es: " + uni);
            else if (num < 20)
                System.Console.WriteLine("\nEl numero es: " + sobreD);
            else if (num < 100)
            {
                if (num % 10 == 0)
                {
                    System.Console.WriteLine("\nEl numero es: " + dec);
                }
                else
                {
                    System.Console.WriteLine("\nEl numero es: " + dec + " y " + uni + "\n");
                }
            }
        }



        // 4.	Pedir al usuario que ingrese una letra cualquiera del abecedario y mostrar por consola si se trata de un vocal o una consonante.
        public static void Ejercicio_4()
        {
            string letra = "";

            System.Console.Write("\n----------Identificador de letra----------\nDijite una letra del abecedario: ");
            letra = Console.ReadLine();

            if (letra.Equals("a", StringComparison.InvariantCultureIgnoreCase) || letra.Equals("e", StringComparison.InvariantCultureIgnoreCase) || letra.Equals("i", StringComparison.InvariantCultureIgnoreCase) || letra.Equals("o", StringComparison.InvariantCultureIgnoreCase) || letra.Equals("u", StringComparison.InvariantCultureIgnoreCase))
            {
                System.Console.WriteLine("La letra es una vocal");
            }
            else
            {
                System.Console.WriteLine("La letra es una consonante");
            }

        }
    }
}
