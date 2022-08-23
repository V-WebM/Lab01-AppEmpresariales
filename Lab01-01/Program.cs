using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Resta de dos números");
                Console.WriteLine("[3] Multiplicacion de dos números");
                Console.WriteLine("[4] Division de dos números");
                Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[6] Imprimir los 10 primeros numeros primos");
                Console.WriteLine("[7] Conversion de Temperatura");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int s1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int s2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", s1, s2, Suma(s1, s2));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el primer número");
                        int r1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int r2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La Resta de {0} y {1} es {2}", r1, r2, Resta(r1, r2));
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int m1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int m2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La Multiplicacion de {0} y {1} es {2}", m1, m2, Multiplicacion(m1, m2));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int d1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int d2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La Division de {0} y {1} es {2}", d1, d2, Division(d1, d2));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.Clear();
                        Console.Title = "Convertir Temperaturas";
                        string opcion2;
                        do
                        {
                            Console.WriteLine("[1] Convertir de Celsius a Fanhrenheit");
                            Console.WriteLine("[2] Convertir de Fanhrenheit a Celsius");
                            opcion2 = Console.ReadLine();
                            switch (opcion2)
                            {
                                case "1":
                                    Console.WriteLine("Ingrese la Temperatura en Celsius :");
                                    int c = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine(c + " Celsius Fahrenheit es : "+ F(c));
                                    Console.ReadKey();
                                    break;

                                case "2":
                                    Console.WriteLine("Ingrese la Temperatura en Fahrenheit :");
                                    int f = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine(f +" Fahrenheit a Celsius es : " + C(f));
                                    Console.ReadKey();
                                    break;
                            }

                        } while (!opcion.Equals("0"));
                        break;



                }
            } while (!opcion.Equals("0"));

        }


        static int Suma(int s1, int s2)
        {
            return s1 + s2;
        }
        static int Resta(int r1, int r2)
        {
            return r1 - r2;
        }
        static int Multiplicacion(int m1, int m2)
        {
            return m1 * m2;
        }
        static int Division(int d1, int d2)
        {
            return d1 / d2;
        }

        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }

        static double F(int c)
        {
            return ( ( c * 9 ) / 5 ) + 32;
        }

        static double C(int f) {

            return ( ( f - 32 ) * 5 ) / 9;

        }

    }
}
