using System;

namespace calculadorajhon
{
    internal class Program
    {
        public static double sumar(double x, double y)
        {
            return x + y;
        }
        
        public static double restar(double x, double y)
        {
            return x - y;
        }
        
        public static double mult(double x, double y)
        {
            return x * y;
        }
        
        public static double dividir(double x, double y)
        {
            return x / y;
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("CALCULADORA DE JHON :')");
            double num1, num2;
            Console.Write("introduzca un numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("*");
            Console.WriteLine("/");
            Console.Write("introduzca un operador: ");
            string operador = Console.ReadLine();
            Console.Write("introduzca un segundo numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            if (operador == "+")
            {
                Console.WriteLine("su resultado es igual a: " + sumar(num1, num2));
            }
            
            else if (operador == "-")
            {
                Console.WriteLine("su resultado es igual a: " + restar(num1, num2));
            }
            
            else if (operador == "*")
            {
                Console.WriteLine("su resultado es igual a: " + mult(num1, num2));
            }
            
            else if (operador == "/")
            {
                Console.WriteLine("su resultado es igual a: " + dividir(num1, num2));
            }

            else
            {
                Console.WriteLine("algo salio mal");
            }

            Console.ReadKey();
        }
    }
}