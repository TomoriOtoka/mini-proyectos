namespace CuentasBancarias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sistema de cuentas bancarias con clases

            uint numeroDeCuentas = 0;
            double saldo = 0;
            string nombre;

            List<CuentaBancaria> cuentasBancarias = new List<CuentaBancaria>();

            Console.WriteLine("Ingrese el numero de cuentas a crear");
            numeroDeCuentas = Convert.ToUInt32(Console.ReadLine());

            Console.Clear();
            for (int i = 0; i < numeroDeCuentas; i++)
            {
                Console.WriteLine("Ingrese primero nombre y luego el saldo");

                nombre = Console.ReadLine();
                saldo = Convert.ToDouble(Console.ReadLine());

                CuentaBancaria cuenta = new CuentaBancaria(nombre, saldo);

                cuentasBancarias.Add(cuenta);
            }

            int indiceCuenta = 0;
            string eleccion;
            bool salir = false;
            Console.Clear();
            do
            {

                Console.WriteLine("Escriba el indice de la cuenta a cambiar");
                indiceCuenta = Convert.ToInt32(Console.ReadLine());
                if (indiceCuenta <= 0 || indiceCuenta >= cuentasBancarias.Count)
                {
                    Console.WriteLine("Indice invalido.");
                    continue;
                }

                indiceCuenta -= 1;

                Console.WriteLine("Escriba la operacion a realizar");
                Console.WriteLine("Operaciones: depositar, retirar, mostrar");
                Console.WriteLine("Si desea salir, escriba \"salir\" ");

                eleccion = Console.ReadLine();

                int cantidad = 0;
                switch (eleccion)
                {
                    case "depositar":
                        Console.WriteLine("Ingrese la cantidad a depositar");
                        cantidad = Convert.ToInt32(Console.ReadLine());
                        
                        if (!VerificarCantidad(cantidad))
                        {
                            continue;
                        }
                        cuentasBancarias[indiceCuenta].Depositar(cantidad);
                        break;
                    case "retirar":
                        Console.WriteLine("Ingrese la cantidad a retirar");
                        cantidad = Convert.ToInt32(Console.ReadLine());
                        if (!VerificarCantidad(cantidad))
                        {
                            continue;
                        }
                        cuentasBancarias[indiceCuenta].Retirar(cantidad);
                        break;
                    case "mostrar":
                        cuentasBancarias[indiceCuenta].MostrarInformacion();
                        break;
                    case "salir":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("No valido");
                        break;
                }
            }
            while (!salir);
        }

        public class CuentaBancaria
        {
            public string Titular {  get; private set; }
            public double Saldo { get; private set; }

            public CuentaBancaria()
            {
                this.Titular = "N/A";
                this.Saldo = 0;
            }
            public CuentaBancaria(string titular, double saldo)
            {
                this.Titular = titular;
                this.Saldo = saldo;
            }

            public double Depositar(double cantidad)
            {
                this.Saldo += cantidad;

                return this.Saldo;
            }

            public double Retirar(double cantidad)
            {
                if (this.Saldo >= cantidad)
                {
                    this.Saldo -= cantidad;
                }
                else
                {
                    Console.WriteLine("Retiro no posible.");
                }
                return this.Saldo;
            }

            public void MostrarInformacion()
            {
                Console.WriteLine("Titular: " + this.Titular);
                Console.WriteLine("Saldo: " + this.Saldo);
            }
        }

        static bool VerificarCantidad(int cantidad)
        {
            if (cantidad < 0)
            {
                Console.WriteLine("Cantidad no valida");
                return false;
            }

            return true;
        }
    }
}
