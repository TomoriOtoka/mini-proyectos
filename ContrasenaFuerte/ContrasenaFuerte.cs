namespace ContrasenaFuerte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Determina si una contraseña es fuerte 

            string contrasenaIngresada;
            bool tieneNumero = false;
            bool tieneLetraMayus = false;
            bool tieneLetraMinus = false;

            Console.WriteLine("Ingrese una contraseña");
            Console.WriteLine("Debe tener 8 caracteres, un numero y letras mayusculas y minusculas.");
            contrasenaIngresada = Console.ReadLine();

            int longitud = 0;
            foreach (int i in contrasenaIngresada)
            {
                longitud++;
            }

            for (int i = 0; i < longitud; i++)
            {
                if (char.IsDigit(contrasenaIngresada[i]))
                {
                    tieneNumero = true;
                    break;
                }
            }

            for (int i = 0; i < longitud; i++)
            {
                if (char.IsUpper(contrasenaIngresada[i]))
                {
                    tieneLetraMayus = true;
                    break;
                }
            }

            for (int i = 0; i < longitud; i++)
            {
                if (char.IsLower(contrasenaIngresada[i]))
                {
                    tieneLetraMinus = true;
                    break;
                }
            }

            int longitudMinima = 8;
            if (longitud > longitudMinima && tieneLetraMayus && tieneLetraMinus && tieneNumero)
            {
                Console.WriteLine("Es segura");
            }
            else
            {
                Console.WriteLine("No es segura");
            }
        }
    }
}
