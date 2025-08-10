namespace ContadorVocal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cuenta cuantas vocales tiene una cadena de texto

            string textoIngresado;
            int contadorA = 0;
            int contadorE = 0;
            int contadorI = 0;
            int contadorO = 0;
            int contadorU = 0;

            Console.WriteLine("Ingrese el texto");
            textoIngresado = Console.ReadLine();
            Console.Clear();
            
            for (int i = 0; i < textoIngresado.Length; i++)
            {
                switch (char.ToLower(textoIngresado[i]))
                {
                    case 'a':
                        contadorA++;
                        break;
                    case 'e':
                        contadorE++;
                        break;
                    case 'i':
                        contadorI++;
                        break;
                    case 'o':
                        contadorO++;
                        break;
                    case 'u':
                        contadorU++;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("A: " + contadorA);
            Console.WriteLine("E: " + contadorE);
            Console.WriteLine("I: " + contadorI);
            Console.WriteLine("O: " + contadorO);
            Console.WriteLine("U: " + contadorU);
        }
    }
}
