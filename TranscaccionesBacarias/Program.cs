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
            Cuenta cuenta1 = new Cuenta(14210, 4854, "Danniel", "Paniagua ", DateTime.Now, "Activo", 5000);
            Cuenta cuenta2 = new Cuenta(19441, 5050, "Maycoll", "Jaramillo", DateTime.Now, "Activo", 2000);

            decimal movimientoSaldo = 0;
            int opcion = 1;
     
            do
            {
                Console.Clear();
                StarCuenta.BienvenidoMenu();
                opcion = int.Parse(Console.ReadLine());
                
                switch (opcion)
                {
                    
                    case 1:
                            Console.Clear();
                            StarCuenta.Bienvenido();
                        
                        Console.Write("[Ingrese su pin]: ");
                        int auxpin1 = int.Parse(Console.ReadLine());
                        if (cuenta1.Pin == auxpin1)
                            {
                            Console.Write("[Digite la cantidad de dinero a depositar]:");
                            movimientoSaldo = decimal.Parse(Console.ReadLine());

                            Console.Clear();
                            Console.WriteLine("\n\n");
                            if (cuenta1.verificarCuenta(movimientoSaldo) == 1)
                            {
                                cuenta1.ingresarDinero(movimientoSaldo);
                                Console.WriteLine("Deposito de C$[" + movimientoSaldo + "] realizado con exito en la Cuenta " + cuenta1.Propietario());
                            }
                            else
                            {
                                Console.WriteLine("Dato Invalido! :(");
                            }
                                                      
                            Console.ReadKey();
                            break;
                            }
                        if (cuenta2.Pin == auxpin1)
                            {
                                Console.Write("[Digite la cantidad de dinero a depositar]:");
                                movimientoSaldo = decimal.Parse(Console.ReadLine());
                                
                            Console.Clear();
                            Console.WriteLine("\n\n");
                            if (cuenta2.verificarCuenta(movimientoSaldo) == 1)
                            {
                                cuenta2.ingresarDinero(movimientoSaldo);
                                Console.WriteLine("Deposito de C$[" + movimientoSaldo + "] realizado con exito en la Cuenta " + cuenta2.Propietario());
                            }
                            else
                            {
                                Console.WriteLine("Dato Invalido! :(");
                            }
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
                            StarCuenta.Bienvenido();

                        Console.Write("[Ingrese su pin]: ");
                            int auxpin2 = int.Parse(Console.ReadLine());
                            if (cuenta1.Pin == auxpin2)
                            {
                                Console.Write("[Digite la cantidad de dinero a retirar]:");
                                movimientoSaldo = decimal.Parse(Console.ReadLine());
                                
                            Console.Clear();
                            Console.WriteLine("\n\n");
                            if (cuenta1.verificarCuenta(movimientoSaldo) == 1)
                            {
                                cuenta1.RetirarDinero(movimientoSaldo);
                                Console.WriteLine("Retiro de C$[" + movimientoSaldo + "] realizado con exito en la Cuenta " + cuenta1.Propietario());
                            }
                            else
                            {
                                Console.WriteLine("No posee fondos suficientes! o dato introducido incorrecto :(");
                            }
                            Console.ReadKey();
                            break;
                            }
                            if (cuenta2.Pin == auxpin2)
                            {
                                Console.Write("[Digite la cantidad de dinero a retirar]:");
                                movimientoSaldo = decimal.Parse(Console.ReadLine());
                                
                            Console.Clear();
                            Console.WriteLine("\n\n");
                            if (cuenta2.verificarCuenta(movimientoSaldo) == 1)
                            {
                                cuenta2.RetirarDinero(movimientoSaldo);
                                Console.WriteLine("Retiro de C$[" + movimientoSaldo + "] realizado con exito en la Cuenta " + cuenta2.Propietario());
                            }
                            else
                            {
                                Console.WriteLine("No posee fondos suficientes! o dato introducido incorrecto :(");
                            }
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
                            StarCuenta.Bienvenido();

                        Console.Write("[Ingrese su pin]: ");
                            int auxpin3 = int.Parse(Console.ReadLine());
                            if (cuenta1.Pin == auxpin3)
                            {
                                Console.Write("[Digite la cantidad de dinero a transferir]:");
                                movimientoSaldo = decimal.Parse(Console.ReadLine());
                                
                            Console.Clear();
                            Console.WriteLine("\n\n");
                            if (cuenta1.verificarCuenta(movimientoSaldo) == 1)
                            {
                                cuenta2.ingresarDinero(cuenta1.tranferirDinero(movimientoSaldo));
                                Console.WriteLine("Transferencia de C$[" + movimientoSaldo + "] realizado con exito en la Cuenta " + cuenta2.Propietario());
                            }
                            else
                            {
                                Console.WriteLine("No posee fondos suficientes para realizar la tranferencia! o dato introducido incorrecto :(");
                            }
                            Console.ReadKey();
                            break;
                            }
                            if (cuenta2.Pin == auxpin3)
                            {
                                Console.Write("[Digite la cantidad de dinero a tranferir]:");
                                movimientoSaldo = decimal.Parse(Console.ReadLine());
                                
                            Console.Clear();
                            Console.WriteLine("\n\n");
                            if(cuenta2.verificarCuenta(movimientoSaldo) == 1)
                            {
                                cuenta1.ingresarDinero(cuenta2.tranferirDinero(movimientoSaldo));
                                Console.WriteLine("Transferencia de C$[" + movimientoSaldo + "] realizado con exito en la Cuenta " + cuenta1.Propietario());
                            }
                            else
                            {
                                Console.WriteLine("No posee fondos suficientes para realizar la tranferencia! o dato introducido incorrecto :(");
                            }
                            
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
                        Console.WriteLine(cuenta1.DatosCuenta());
                        Console.WriteLine(cuenta2.DatosCuenta());
                        Console.ReadKey();
                        break;

                    default:                        
                            Console.WriteLine("opcion invalida! :(");
                        break;                       
                }
            } while (opcion>=0 || opcion <=6 );
        }
    }
}
