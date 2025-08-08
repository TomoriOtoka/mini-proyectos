namespace VerificadorTexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Verifica si empieza con mayuscula y termina con puntuacion

            string textoIngresado;
            bool empiezaEnMayuscula = false;
            bool terminaEnPunto = false;
            // Ingreso de texto (string)
            Console.WriteLine("El texto ingresado debe empezar en mayusculas y terminar en puntuacion");
            textoIngresado = Console.ReadLine();

            // Verficar si empieza con mayuscula
            if (char.IsUpper(textoIngresado[0]))
            {
                empiezaEnMayuscula = true;
            }

            // Verificar si termina con un punto
            if (char.IsPunctuation(textoIngresado[textoIngresado.Length - 1]))
            {
                terminaEnPunto = true;
            }

            // Imprimir resultado
            if (empiezaEnMayuscula && terminaEnPunto)
            {
                Console.WriteLine("Aprobado");
            }
            else
            {
                Console.WriteLine("No aprobado");
            }
        }
    }
}
