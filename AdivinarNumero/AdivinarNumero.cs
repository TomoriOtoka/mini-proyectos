using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdivinarNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Juego de adivinar un numero entre 1 al 100
            // Intentos: 7

            // Declarar variables
            int numeroSecreto = 0;
            int numeroIngresado;
            int numeroVidas = 7;
            bool numeroAdivinado = false;

            // Generar un numero aleatorio del 1 al 100
            Random Aleatorio = new Random();
            numeroSecreto = Aleatorio.Next(1, 100);

            // Ingresar texto usuario
            
            while (numeroVidas > 0 && !numeroAdivinado)
            {
                Console.WriteLine("Adivine un numero del 1 al 100");
                Console.WriteLine("Numero de vidas restantes: " + numeroVidas);
                numeroIngresado = Convert.ToInt32(Console.ReadLine());

                // Conducir logica
                if (numeroIngresado < numeroSecreto)
                {
                    Console.WriteLine("Numero ingresado muy bajo!");
                    numeroVidas--;
                }
                else if (numeroIngresado > numeroSecreto)
                {
                    Console.WriteLine("Numero ingresado muy alto!");
                    numeroVidas--;
                }
                else
                {
                    numeroAdivinado = true;
                }

            }

            Console.Clear();

            if (numeroAdivinado)
            {
                Console.WriteLine("Ha ganado!");
            }
            else
            {
                Console.WriteLine("Perdio!");
                Console.WriteLine("El numero era " + numeroSecreto);
            }
        }
    }
}
