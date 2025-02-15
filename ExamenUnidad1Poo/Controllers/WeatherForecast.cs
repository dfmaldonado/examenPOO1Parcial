using Microsoft.AspNetCore.Mvc.Formatters;

namespace ExamenUnidad1Poo.Controllers
{
    public class EsPrimo
    {
        static void main()
        {
            Console.Write("Escriba un numero");
            double NumeroPrimo = Convert.ToDouble(Console.ReadLine());

            if (NumeroPrimo % NumeroPrimo == 0)
            {
                Console.WriteLine("El numero es primo");
            }
            else
            {
                Console.WriteLine("El numero no es primo");
            }
        }

        public class Factorial
        {
            static void Main()
            {
                Console.Write("Ingrese un número para generar su factorial: ");
                double NumeroFactorial = Convert.ToDouble(Console.ReadLine());
                for (int i = 0; i < NumeroFactorial; i++)
                {
                    NumeroFactorial *= i;
                    Console.Write("El resultado del factorial es {NumeroFactorial}");
                }
            }
        }


        public class Fibonacci
        {
            static void main()
            {
                Console.Write("Digite un numero para encontrar su serie fibonacci");
                double NumFibo = Convert.ToDouble(Console.ReadLine());
                while (NumFibo <= 0)
                {
                    NumFibo = 
                }

            }
        }

        public class Vocales
        {
            static void main ()
            {
                Console.WriteLine("Escriba una palabra: ");
                string _CountVocal = Console.ReadLine();
                

            }
        }

        public class Palindromo
        {

        }

    }
}


