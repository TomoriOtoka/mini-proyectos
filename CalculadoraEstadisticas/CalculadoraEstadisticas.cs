using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

namespace CalculadoraEstadisticas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lee n variables del usuario, muestra el valor maximo, minimo y promedio
            int n = 0;
            int numeroMaximo = 0;
            int numeroMinimo = 0;
            double promedio = 0;
            int numeroIngresado = 0;
            double suma = 0;

            Console.WriteLine("Ingrese la cantidad de numeros");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Ingrese los numeros");
            numeroIngresado = Convert.ToInt32(Console.ReadLine());

            numeroMaximo = numeroIngresado;
            numeroMinimo = numeroIngresado;
            suma += numeroIngresado;

            for (int i = 0; i < n - 1; i++)
            {
                numeroIngresado = Convert.ToInt32((Console.ReadLine()));

                if (numeroIngresado > numeroMaximo)
                {
                    numeroMaximo = numeroIngresado;
                }
                if (numeroIngresado < numeroMinimo)
                {
                    numeroMinimo = numeroIngresado;
                }

                suma += numeroIngresado;
            }

            promedio = suma / n;

            Console.Clear();
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Numero Maximo: " + numeroMaximo);
            Console.WriteLine("Numero Minimo: " + numeroMinimo);
        }
    }
}
