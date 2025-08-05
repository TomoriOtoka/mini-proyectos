namespace Contactos__Clases_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crea contactos a partir de clases
            Contacto Contacto1 = new Contacto("Bridget", "0964100835", "kuroide@gmail.com");
            Contacto Contacto2 = new Contacto("Valentino", "0987159870", "tomori@gmail.com");

            Contacto1.MostrarInfo();
            Contacto2.MostrarInfo();
        }

        class Contacto
        {
            public string Nombre;
            public string Telefono;
            public string Correo;

            public Contacto(string nombre, string telefono, string correo)
            {
                Nombre = nombre;
                Telefono = telefono;
                Correo = correo;
            }

            public void MostrarInfo()
            {
                Console.WriteLine(Nombre);
                Console.WriteLine(Telefono);
                Console.WriteLine(Correo);
            }
        }
    }
}
