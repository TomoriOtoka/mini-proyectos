namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Programa de FizzBuzz
             * Imprime los numeros del 1 al 100
             * Si el numero es divisible por 3, imprime Fizz
             * Si el nuemro es divisible por 5, imprime Buzz
             * Si es por ambos, imprime ambos
             */

            int divisibleParaTres = 0;
            int divisibleParaCinco = 0;
            for (int i = 0; i <= 100; i++)
            {
                Console.Write(i + " ");

                divisibleParaTres = i % 3;
                divisibleParaCinco = i % 5;

                if (divisibleParaTres == 0)
                {
                    Console.Write("Fizz");
                }
                if (divisibleParaCinco == 0)
                {
                    Console.Write("Buzz");
                }

                Console.WriteLine(" \n");
                
            }
        }
    }
}
