namespace CalculadoraSimple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculadora usando switch case

            string numero1Str = "0";
            string numero2Str = "0";

            Console.WriteLine("Ingrese dos numeros");

            bool numero1NoValido = true;
            bool numero2NoValido= true;
            while (numero1NoValido)
            {
                numero1Str = Console.ReadLine();

                numero1NoValido = VerificarNumero(numero1Str);
            }

            while (numero2NoValido)
            {
                numero2Str = Console.ReadLine();

                numero2NoValido = VerificarNumero(numero2Str);
            }

            // Convertir de texto a numeros
            double numero1 = Convert.ToInt32(numero1Str);
            double numero2 = Convert.ToInt32(numero2Str);

            
            Console.WriteLine("Ingrese que tipo de operacion desea");
            Console.WriteLine("Puede ingresar +, -, * o / ");
            Console.WriteLine("Escriba cualquier otra cosa para salir");
            string operacionIngresada;
            
            operacionIngresada = Console.ReadLine();

            double resultadoFinal = 0;

            switch (operacionIngresada)
            {
                case "/":
                    resultadoFinal = numero1 / numero2;
                    break;
                case "+":
                    resultadoFinal = numero1 + numero2;
                    break;
                case "*":
                    resultadoFinal = numero1 * numero2;
                    break;
                case "-":
                    resultadoFinal = numero1 - numero2;
                    break;
                default:
                    Console.WriteLine("No válido");
                    break;
            }

            Console.Clear();

            Console.WriteLine("El resultado final es " + resultadoFinal);
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
