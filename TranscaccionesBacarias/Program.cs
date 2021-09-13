using System;
using System.Runtime;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranscaccionesBacarias
{
    class Program
    {
       static void Main(string[] args)
        {

            Transcaciones();
            Console.ReadKey();
        }
        public static void Transcaciones()
        {
            StarCuenta.cuentas = new List<Cuenta>();
            Cuenta cuenta1 = new Cuenta(14210, 4854, "Danny", "Sevilla", DateTime.Now, "Activo", 5000);
            Cuenta cuenta2 = new Cuenta(19441, 5050, "Maycoll", "Jaramillo", DateTime.Now, "Activo", 2000);

            decimal movimientoSaldo = 0;
            int opcion = 1;
            bool respuesta = true;
            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("             ╔═══════════════════════════════════════════════════════════╗");
                Console.WriteLine("             ║ ** Bienvenido a tu Sistema de Banca en linea Preferido ** ║");
                Console.WriteLine("             ╚═══════════════════════════════════════════════════════════╝");
                Console.WriteLine();
                Console.WriteLine("╔════════════════════╦════════════════════╦══════════════════════╦══════════╦═══════════════╗");
                Console.WriteLine("║[1].Ingresar Dinero ║[2].Retirar Dinero  ║[3].Transferir Dinero ║[4].Salir ║[5].Ver Cuentas║");
                Console.WriteLine("╚════════════════════╩════════════════════╩══════════════════════╩══════════╩═══════════════╝");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    
                    case 1:
                            Console.Clear();
                            Console.WriteLine("             ╔═══════════════════════════════════════════════════════════╗");
                            Console.WriteLine("             ║ ** Bienvenido a tu Sistema de Banca en linea Preferido ** ║");
                            Console.WriteLine("             ╚═══════════════════════════════════════════════════════════╝");
                            Console.WriteLine();
                        
                        Console.Write("[Ingrese su pin]: ");
                        int auxpin1 = int.Parse(Console.ReadLine());
                        if (cuenta1.Pin == auxpin1)
                            {
                            Console.Write("[Digite la cantidad de dinero a depositar]:");
                            movimientoSaldo = decimal.Parse(Console.ReadLine());
                            cuenta1.ingresarDinero(movimientoSaldo);
                            Console.Clear();
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Deposito realizado con exito en la Cuenta "+cuenta1.NumeroDeCuenta+" del Propietario "+cuenta1.Nombre +" "+ cuenta1.Apellido);
                            Console.ReadKey();
                            break;
                            }
                        if (cuenta2.Pin == auxpin1)
                            {
                                Console.Write("[Digite la cantidad de dinero a depositar]:");
                                movimientoSaldo = decimal.Parse(Console.ReadLine());
                                cuenta2.ingresarDinero(movimientoSaldo);
                            Console.Clear();
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Deposito realizado con exito en la Cuenta " + cuenta2.NumeroDeCuenta + " del Propietario " + cuenta2.Nombre + " " + cuenta2.Apellido);
                            Console.ReadKey();
                            break;
                            }
                        if (cuenta1.Pin != auxpin1 || cuenta2.Pin != auxpin1)
                        {
                            Console.WriteLine("Pin incorrecto! :(");
                            Console.ReadKey();
                        }                           
                        break;

                    case 2:
                            Console.Clear();
                            Console.WriteLine("             ╔═══════════════════════════════════════════════════════════╗");
                            Console.WriteLine("             ║ ** Bienvenido a tu Sistema de Banca en linea Preferido ** ║");
                            Console.WriteLine("             ╚═══════════════════════════════════════════════════════════╝");
                            Console.WriteLine();
                           
                            Console.Write("[Ingrese su pin]: ");
                            int auxpin2 = int.Parse(Console.ReadLine());
                            if (cuenta1.Pin == auxpin2)
                            {
                                Console.Write("[Digite la cantidad de dinero a retirar]:");
                                movimientoSaldo = decimal.Parse(Console.ReadLine());
                                cuenta1.RetirarDinero(movimientoSaldo);
                            Console.Clear();
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Retiro realizado con exito en la Cuenta " + cuenta1.NumeroDeCuenta + " del Propietario " + cuenta1.Nombre + " " + cuenta1.Apellido);
                            Console.ReadKey();
                            break;
                            }
                            if (cuenta2.Pin == auxpin2)
                            {
                                Console.Write("[Digite la cantidad de dinero a retirar]:");
                                movimientoSaldo = decimal.Parse(Console.ReadLine());
                                cuenta2.RetirarDinero(movimientoSaldo);
                            Console.Clear();
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Retiro realizado con exito en la Cuenta " + cuenta2.NumeroDeCuenta + " del Propietario " + cuenta2.Nombre + " " + cuenta2.Apellido);
                            Console.ReadKey();
                            break;
                            }
                            if (cuenta1.Pin != auxpin2 || cuenta2.Pin != auxpin2)
                            {
                                Console.WriteLine("Pin incorrecto! :(");
                                Console.ReadKey();
                            }
                        break;

                    case 3:
                            Console.Clear();
                            Console.WriteLine("             ╔═══════════════════════════════════════════════════════════╗");
                            Console.WriteLine("             ║ ** Bienvenido a tu Sistema de Banca en linea Preferido ** ║");
                            Console.WriteLine("             ╚═══════════════════════════════════════════════════════════╝");
                            Console.WriteLine();
                           
                            Console.Write("[Ingrese su pin]: ");
                            int auxpin3 = int.Parse(Console.ReadLine());
                            if (cuenta1.Pin == auxpin3)
                            {
                                Console.Write("[Digite la cantidad de dinero a transferir]:");
                                movimientoSaldo = decimal.Parse(Console.ReadLine());
                                cuenta2.ingresarDinero(cuenta1.tranferirDinero(movimientoSaldo));
                            Console.Clear();
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Tranferencia realizada con exito en la Cuenta " + cuenta2.NumeroDeCuenta + " del Propietario " + cuenta2.Nombre + " " + cuenta2.Apellido);
                            Console.ReadKey();
                            break;
                            }
                            if (cuenta2.Pin == auxpin3)
                            {
                                Console.Write("[Digite la cantidad de dinero a tranferir]:");
                                movimientoSaldo = decimal.Parse(Console.ReadLine());
                                cuenta1.ingresarDinero(cuenta2.tranferirDinero(movimientoSaldo));
                            Console.Clear();
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Tranferencia realizada con exito en la Cuenta " + cuenta1.NumeroDeCuenta + " del Propietario " + cuenta1.Nombre + " " + cuenta1.Apellido);
                            Console.ReadKey();
                            break;
                            }
                            if (cuenta1.Pin != auxpin3 || cuenta2.Pin != auxpin3)
                            {
                                Console.WriteLine("Pin incorrecto! :(");
                                Console.ReadKey();
                            }
                        break;

                    case 4: Environment.Exit(0);
                        break;

                    case 5:
                        
                            Console.WriteLine("[Numero de cuenta]: " + cuenta1.NumeroDeCuenta);
                            Console.WriteLine("[Propietario]: " + cuenta1.Nombre + " " + cuenta1.Apellido);
                            Console.WriteLine("[Saldo]: " + cuenta1.Saldo);
                            Console.WriteLine("[Estado]: " + cuenta1.Estado);
                            Console.WriteLine("\n");
                            Console.WriteLine("[Numero de cuenta]: " + cuenta2.NumeroDeCuenta);
                            Console.WriteLine("[Propietario]: " + cuenta2.Nombre + " " + cuenta2.Apellido);
                            Console.WriteLine("[Saldo]: " + cuenta2.Saldo);
                            Console.WriteLine("[Estado]: " + cuenta2.Estado);
                            Console.ReadKey();
                        break;

                    default:                        
                            Console.WriteLine("opcion invalida");
                        break;
                        

                }
             
                    respuesta = false;
            } while (opcion>=0 || opcion <=6 );


        }
    }
}
