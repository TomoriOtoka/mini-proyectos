using System.ComponentModel.Design;

namespace CalculadoraPromedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculadora de promedio de calificaciones usando listas y metodos

            List<int> calificaciones = new List<int>();
   
            string calificacionIngresada;
            Console.WriteLine("Ingrese calificaciones. Escriba \"listo\" para finalizar");
            while (true)
            {
                calificacionIngresada = Console.ReadLine();

                if (int.TryParse(calificacionIngresada, out int resultado))
                {
                    calificaciones.Add(resultado);
                }
                else if (calificacionIngresada == "listo")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("No valido");
                }
            }

            CalcularPromedio(calificaciones);
        }

        private static void CalcularPromedio(List<int> calificaciones)
        {
            double suma = 0;
            double promedio = 0;
            foreach (int i in calificaciones)
            {
                suma += i;
            }

            int cantidadCalificaciones = calificaciones.Count();

            promedio = suma / cantidadCalificaciones;

            promedio = Math.Round(promedio, 2);

            Console.WriteLine(promedio);
        }
    }
}
