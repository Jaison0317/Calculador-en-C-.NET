using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("*                     Bienvenido al Programa  x82                           *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("                       Menu de Opciones                                      ");
            Console.WriteLine("                                                                             ");
            Console.WriteLine("                    1 - Suma                                                 ");
            Console.WriteLine("                    2 - Resta                                                ");
            Console.WriteLine("                    3 - Multiplicacion                                       ");
            Console.WriteLine("                    4 -  Division                                            ");
            Console.WriteLine("                    5 - Calcular la hipotenusa");
            Console.WriteLine("                    6 - Calcular el Area de un Triangulo                     ");
            Console.WriteLine("                    7 - Salir");
            Console.WriteLine("                     8 - Suma de numeros   ");


              Console.Read();
            Console.WriteLine("Que desea hacer?");
            string resp = null;
            resp = Console.ReadLine();
            //Console.WriteLine("Que desea hacer?");
            string seleccionar = Convert.ToString(resp);
            Console.WriteLine("Digite dos numeros para efectuar la operacion seleccionada");
            Console.WriteLine("Numero 1: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero 2: ");
            int numero2 = int.Parse(Console.ReadLine());
            int Altura = 0;
            int Base = 0;

            switch (seleccionar)
            {

                case "1":
                   
                    Console.WriteLine("El resultado de la suma es: ");
                    int R = numero1 + numero2;
                    Console.WriteLine(R);
                    break;

                case "2":
                    Console.WriteLine("El resultado de la resta es: ");
                    R = numero1 - numero2;
                    Console.WriteLine(R);
                    break;

                case "3":
                    Console.WriteLine("El resultado de la multiplicacion es: ");
                    R = numero1 * numero2;
                    Console.WriteLine(R);
                    break;

                case "4":
                    Console.WriteLine("El resultado de la division es: ");
                    R = numero1 / numero2;
                    Console.WriteLine(R);
                    break;

                case "5":
                    Console.WriteLine("La hipotenusa de un triangulo rectangulo es: ");
                    R = ((numero1 * numero1) + (numero2 * numero2));
                    double Hip = Math.Sqrt(R);
                    Console.WriteLine(Hip);
                    break;

                case "6":
                    Console.WriteLine("El Area de un Triangulo es: ");
                    R = (numero1 * numero2)/ 2;
                    Console.WriteLine(R);
                    break;

                case "7":
                    for (int i = 0; i < numero1; i++)
                    {
                        Console.WriteLine(i);
                    }


                    break;
            }
        }
    }
}
