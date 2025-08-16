using System.Security.Cryptography.X509Certificates;

namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroEstudiantes = 0;
            int calificacion = 0;
            string nombre;
            int calificacionMayor = 0;
            int calificacionMenor = 0;
            double promedio = 0;

            Console.WriteLine("Cuantos estudiantes ingresara?");
            numeroEstudiantes = Convert.ToInt32(Console.ReadLine());

            List<Estudiante> listaEstudiantes = new List<Estudiante>();
            for (int i = 0; i < numeroEstudiantes; i++)
            {
                Console.WriteLine("Ingrese el nombre y posteriormente la calificacion");
                nombre = Console.ReadLine();
                calificacion = Convert.ToInt32(Console.ReadLine());

                Estudiante estudiante = new Estudiante(nombre, calificacion);

                listaEstudiantes.Add(estudiante);
            }

            Console.Clear();

            calificacionMayor = calcularMayor(listaEstudiantes);
            calificacionMenor = calcularMenor(listaEstudiantes);
            promedio = calcularPromedio(listaEstudiantes);

            Console.WriteLine("Calificacion mayor: " + calificacionMayor);
            Console.WriteLine("Calificacion menor: " + calificacionMenor);
            Console.WriteLine("Promedio: " + promedio);

            imprimirPorCalificacion(listaEstudiantes);

            
        }

        public class Estudiante : IComparable<Estudiante>
        {
            // Atributos
            public string Nombre { get; set; }
            public int Calificacion { get; set; }
            public Estudiante()
            {       
                this.Nombre = "Desconocido";
                this.Calificacion = 0;
            }

            public Estudiante(string nombre, int calificacion)
            {
                this.Nombre = nombre;
                this.Calificacion= calificacion;
            }

            public int CompareTo(Estudiante? other)
            {
                if (other == null) return 1;
                return this.Calificacion.CompareTo(other.Calificacion);
            }
        }

        static public int calcularMayor(List<Estudiante> estudiantes)
        {
            int numeroMayor = 0;

            for (int i = 0; i < estudiantes.Count; i++)
            {
                if (estudiantes[i].Calificacion > numeroMayor)
                {
                    numeroMayor = estudiantes[i].Calificacion;
                }

            }

            return numeroMayor;
        }

        static public int calcularMenor(List<Estudiante> estudiantes)
        {
            int numeroMenor = estudiantes[0].Calificacion;

            for (int i = 1; i < estudiantes.Count; i++)
            {
                if (estudiantes[i].Calificacion < numeroMenor)
                {
                    numeroMenor = estudiantes[i].Calificacion;
                }

            }
                
            return numeroMenor;
        }

        static public double calcularPromedio(List<Estudiante> estudiantes)
        {
            double promedio = 0;
            double suma = 0;

            for (int i = 0;i < estudiantes.Count;i++)
            {
                suma += estudiantes[i].Calificacion;
            }

            promedio = suma / estudiantes.Count;

            return promedio;
        }
        
        static public void imprimirPorCalificacion(List<Estudiante> estudiantes)
        {
            estudiantes.Sort();

            Console.WriteLine("Ordenados por calificacion:");
            foreach (Estudiante obj in estudiantes)
            {
                Console.WriteLine("Nombre: " + obj.Nombre);
                Console.WriteLine("Calificacion: " + obj.Calificacion);
            }
        }
    }
}
