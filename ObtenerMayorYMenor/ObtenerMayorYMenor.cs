namespace ObtenerMayorYMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Obtiene los valores mayores y menores de una array de 5 enteros
            int[] enteros = new int[5];

            string numeroIngresadoStr = "";
            int numeroIngresado;
            bool NumeroValido = true;

            Console.WriteLine("Ingrese 5 enteros");

            for (int i = 0; i < 5; i++)
            {
                NumeroValido = true;
                while (NumeroValido)
                {
                    numeroIngresadoStr = Console.ReadLine();

                    NumeroValido = VerificarNumero(numeroIngresadoStr);
                }

                numeroIngresado = Convert.ToInt32(numeroIngresadoStr);
                enteros[i] = numeroIngresado;
            }

            int[] resultado = new int[2] { enteros[0], enteros[0] };

            for (int i = 0; i < enteros.Length; i++)
            {
                if (enteros[i] > resultado[0])
                {
                    resultado[0] = enteros[i];
                }
                else if (enteros[i] < resultado[1])
                {
                    resultado[1] = enteros[i];
                }
            }

            Console.WriteLine("Numero mayor: " + resultado[0]);
            Console.WriteLine("Numero menor: " + resultado[1]);
        }
        private static bool VerificarNumero(string numero1)
        {
            if (!int.TryParse(numero1, out int resultado))
            {
                Console.WriteLine("No valido");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
