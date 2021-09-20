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
            Transcaciones();//Transacciones Bancarias
            Console.ReadKey();
        }
        public static void Transcaciones()
        {
            // Inicializar Cuentas Bancarias
            StarCuenta.cuentas = new List<Cuenta>();
            Cuenta cuenta1 = new Cuenta(14210, 4854, "Danniel", "Paniagua ", DateTime.Now, "Activo", 5000);
            Cuenta cuenta2 = new Cuenta(19441, 5050, "Maycoll", "Jaramillo", DateTime.Now, "Activo", 2000);

            //Variables de apoyo a las Tranferencias
            decimal movimientoSaldo = 0;
            int opcion = 0;
            int auxNumCuenta = 0;
            int auxpin1 = 0;
            int error = 0;


            do
            {
                Console.Clear();
                
                try//validacion de opcion
                {
                    StarCuenta.BienvenidoMenu();
                    opcion = int.Parse(Console.ReadLine());
                }
                catch(FormatException e)
                {
                    Console.WriteLine("Error! "+e.Message);
                    Console.WriteLine("Favor ingresar una opcion valida :)");
                    Console.ReadKey();
                }
                
                
                switch (opcion)
                {
                    
                    case 1:// Transacaciones de Deposito a la cuenta
                            Console.Clear();
                            StarCuenta.Bienvenido();
                        try
                        {
                            Console.Write("[Ingrese su Numero de cuenta]: ");
                            auxNumCuenta = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Error! " + e.Message);
                            Console.ReadKey();
                        }
                        try
                        {
                         Console.Write("[Ingrese su pin]: ");
                         auxpin1 = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Error! " + e.Message);
                            Console.ReadKey();
                        }
                                                
                        if (cuenta1.NumeroDeCuenta == auxNumCuenta && cuenta1.Pin == auxpin1)
                            {                           
                            try
                            {
                                Console.Write("[Digite la cantidad de dinero a depositar]:");
                                movimientoSaldo = decimal.Parse(Console.ReadLine());
                            }
                            catch(FormatException e)
                            {
                                Console.WriteLine("Error! " + e.Message);
                                Console.ReadKey();
                                break;
                            }
                            
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
                        if (cuenta2.NumeroDeCuenta ==auxNumCuenta && cuenta2.Pin == auxpin1)
                            {
                            try
                            {
                                Console.Write("[Digite la cantidad de dinero a depositar]:");
                                movimientoSaldo = decimal.Parse(Console.ReadLine());
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("Error! " + e.Message);
                                Console.ReadKey();
                                break;
                            }
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
                        if (cuenta1.NumeroDeCuenta != auxNumCuenta ||cuenta1.Pin != auxpin1 || cuenta2.NumeroDeCuenta != auxNumCuenta ||cuenta2.Pin != auxpin1 )
                        {
                            Console.WriteLine("Numero de Cuenta o Pin incorrecto! :(");
                            Console.ReadKey();
                        }                        
                        break;

                    case 2: //Transcacciones de Retiro en la cuenta
                            Console.Clear();
                            StarCuenta.Bienvenido();
                        try
                        {
                            Console.Write("[Ingrese su Numero de cuenta]: ");
                            auxNumCuenta = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Error! " + e.Message);
                            Console.ReadKey();
                        }
                        try
                        {
                            Console.Write("[Ingrese su pin]: ");
                            auxpin1 = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Error! " + e.Message);
                            Console.ReadKey();
                        }
                            if (cuenta1.NumeroDeCuenta == auxNumCuenta && cuenta1.Pin == auxpin1)
                            {
                            try
                            {
                                Console.Write("[Digite la cantidad de dinero a retirar]:");
                                movimientoSaldo = decimal.Parse(Console.ReadLine());
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("Error! " + e.Message);
                                Console.ReadKey();
                                break;
                            }
                                
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
                            if (cuenta2.NumeroDeCuenta == auxNumCuenta && cuenta2.Pin == auxpin1)
                            {
                            try
                            {
                                Console.Write("[Digite la cantidad de dinero a retirar]:");
                                movimientoSaldo = decimal.Parse(Console.ReadLine());
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("Error! " + e.Message);
                                Console.ReadKey();
                                break;
                            }

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
                        if (cuenta1.NumeroDeCuenta != auxNumCuenta || cuenta1.Pin != auxpin1 || cuenta2.NumeroDeCuenta != auxNumCuenta || cuenta2.Pin != auxpin1)
                        {
                            Console.WriteLine("Numero de Cuenta o Pin incorrecto! :(");
                            Console.ReadKey();
                        }
                        break;

                    case 3: // Transacciones de Tranfericia de una cuenta a otra
                            Console.Clear();
                            StarCuenta.Bienvenido();
                        try
                        {
                            Console.Write("[Ingrese su Numero de cuenta]: ");
                            auxNumCuenta = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Error! " + e.Message);
                            Console.ReadKey();
                        }
                        try
                        {
                            Console.Write("[Ingrese su pin]: ");
                            auxpin1 = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Error! " + e.Message);
                            Console.ReadKey();
                        }

                        if (cuenta1.NumeroDeCuenta == auxNumCuenta && cuenta1.Pin == auxpin1)
                            {
                            try
                            {
                                Console.Write("[Ingrese el Numero de cuenta a trasferir]: ");
                                auxNumCuenta = int.Parse(Console.ReadLine());
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("Error! " + e.Message);
                                Console.WriteLine("Por favor verifique y vuelva intentarlo!");
                                error++;
                                Console.ReadKey();
                                break;
                                
                            }
                            if (auxNumCuenta != cuenta2.NumeroDeCuenta && error == 0)
                            {
                                Console.WriteLine("El numero de cuenta es Incorrecto o la Cuenta no Existe!");
                                Console.WriteLine("Por favor verifique y vuelva intentarlo!");
                                Console.ReadKey();
                                break;
                            }
                            try
                            {
                                Console.Write("[Digite la cantidad de dinero a Transferir]:");
                                movimientoSaldo = decimal.Parse(Console.ReadLine());
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("Error! " + e.Message);
                                Console.ReadKey();
                                break;
                            }
                                                            
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
                            if (cuenta2.NumeroDeCuenta == auxNumCuenta && cuenta2.Pin == auxpin1)
                            {
                            try
                            {
                                Console.Write("[Ingrese el Numero de cuenta a Transferir]: ");
                                auxNumCuenta = int.Parse(Console.ReadLine());
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("Error! " + e.Message);
                                Console.WriteLine("Por favor verifique y vuelva intentarlo!");
                                error++;
                                Console.ReadKey();
                                break;

                            }
                            if (auxNumCuenta != cuenta1.NumeroDeCuenta && error == 0)
                            {
                                Console.WriteLine("El numero de cuenta es Incorrecto o la Cuenta no Existe!");
                                Console.WriteLine("Por favor verifique y vuelva intentarlo!");
                                Console.ReadKey();
                                break;
                            }
                            try
                            {
                                Console.Write("[Digite la cantidad de dinero a Transferir]:");
                                movimientoSaldo = decimal.Parse(Console.ReadLine());
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("Error! " + e.Message);
                                Console.ReadKey();
                                break;
                            }

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
                        if (cuenta1.NumeroDeCuenta != auxNumCuenta || cuenta1.Pin != auxpin1 || cuenta2.NumeroDeCuenta != auxNumCuenta || cuenta2.Pin != auxpin1)
                        {
                            Console.WriteLine("Numero de Cuenta o Pin incorrecto! :(");
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
            } while (opcion>=1 || opcion <=5 );
        }
    }
}
