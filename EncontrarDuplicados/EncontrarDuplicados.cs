namespace EncontrarDuplicados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Encuentra el numero de duplicados dentro de un array de 5 enteros
            int[] enteros = new int[5];

                string numeroIngresadoStr = "";
                int numeroIngresado;
                bool NumeroValido = true;

                Console.WriteLine("Ingrese 5 enteros");

                for (int i = 0; i < 5; i++)
                {
                    NumeroValido = true;
                    while(NumeroValido)
                    {
                        numeroIngresadoStr = Console.ReadLine();

                        NumeroValido = VerificarNumero(numeroIngresadoStr);
                    }
                
                    numeroIngresado = Convert.ToInt32(numeroIngresadoStr);
                    enteros[i] = numeroIngresado;
                }
           
            HashSet<int> numerosDuplicados = new HashSet<int>();

            int numeroDeDuplicados = 0;

            foreach (int i in enteros)
            {

                if (numerosDuplicados.Contains(i))
                {
                    numeroDeDuplicados++;
                }
                else
                {
                    numerosDuplicados.Add(i);
                }
            }

            Console.Clear();
            Console.WriteLine("Numero de duplicados: " + numeroDeDuplicados);
            
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
