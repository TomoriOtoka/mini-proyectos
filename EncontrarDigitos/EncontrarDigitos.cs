namespace EncontrarDigitos
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            string textoIngresado;
            textoIngresado = Console.ReadLine();

            int resultado;
            resultado = ContarDigitos(textoIngresado);

            Console.WriteLine(resultado);

            
        }

        public static int ContarDigitos(string texto)
        {
            int numeroDeDigitos = 0;
            foreach (char i in texto)
            {
                if (char.IsDigit(i))
                {
                    numeroDeDigitos++;
                }
            }

            return numeroDeDigitos;
        }
    }
}
