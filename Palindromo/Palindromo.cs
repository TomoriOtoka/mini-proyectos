using System;
using System.ComponentModel.Design;

namespace Palindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
            string texto = "";
            texto = Console.ReadLine();

            texto = texto.ToLower();
            
            string textoRevertido = "";

            for (int i = texto.Length - 1; i >= 0; i--)
            {
                textoRevertido += texto[i];
            }

            if (String.Equals(texto, textoRevertido))
            {
                Console.WriteLine("Es palindromo");
            }
            else
            {
                Console.WriteLine("No es palindromo");
            }
        }
    }
}
