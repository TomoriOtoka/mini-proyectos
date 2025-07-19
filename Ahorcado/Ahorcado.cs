using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace Ahorcado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] palabras = new string[10] 
            { "rene", "pachay", "meth", "abel", "elhuevo", "damidiangelo", "valentoide", "mizucinco",
            "mikulover", "machinegunkiss"};

            // Genera un numero aleatorio menor que 10
            Random Aleatorio = new Random();
            int indiceAleatorio = Aleatorio.Next(10);
            
            // Elige una palabra aleatoria usando el numero generado
            string palabra = palabras[indiceAleatorio];
            int vidasMax = 5;
            int vidasRestantes = vidasMax;

            List<char> letrasAdivinadas = new List<char>();

            bool partidaGanada = false;

            // Ciclo principal del juego
            while (vidasRestantes > 0 && !partidaGanada)
            { 
                foreach (char letra in palabra)
                {
                    if (letrasAdivinadas.Contains(letra))
                    {
                        Console.Write(letra);
                    }
                    else
                    {
                        Console.Write("_");
                    }
                }

                Console.WriteLine("\nAdivina la palabra");
                Console.WriteLine("Vidas restantes = " + vidasRestantes);

                char letraAdivinada = Convert.ToChar(Console.ReadLine());
                

                if (palabra.Contains(letraAdivinada) && !letrasAdivinadas.Contains(letraAdivinada))
                {
                    Console.WriteLine("Correcto");
                }
                else
                {
                    Console.WriteLine("Incorrecto");
                    vidasRestantes--;
                }

                letrasAdivinadas.Add(letraAdivinada);

                bool palabraCompletada = true;

                // Verifica si todas las letras han sido adivinadas
                foreach (char letra in palabra)
                {
                    if (!letrasAdivinadas.Contains(letra))
                    {
                        palabraCompletada = false;
                    }
                }

                Console.Clear();
                partidaGanada = palabraCompletada;
            }

            Console.Clear();

            if (partidaGanada)
            {
                Console.WriteLine("Ganaste!");
            }
            else
            {
                Console.WriteLine("Perdiste :p");
            }

        }
    }
}
