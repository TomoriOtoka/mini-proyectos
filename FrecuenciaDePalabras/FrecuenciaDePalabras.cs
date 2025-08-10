namespace FrecuenciaDePalabras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cuenta la cantidad de palabras en una oracion

            string textoIngresado;

            textoIngresado = Console.ReadLine();
            Console.Clear();

            string[] palabras = textoIngresado.Split();

            Dictionary<string, int> contadorPalabras = new Dictionary<string, int>();

            foreach (string palabra in palabras)
            {
                string palabraMinuscula = palabra.ToLower();
                if (contadorPalabras.ContainsKey(palabraMinuscula))
                {
                    contadorPalabras[palabraMinuscula]++;
                }
                else
                {
                    contadorPalabras[palabraMinuscula] = 1;
                }
            }

            foreach (var par in contadorPalabras)
            {
                Console.WriteLine(par.Key + ": " + par.Value);
            }
        }
    }
}
