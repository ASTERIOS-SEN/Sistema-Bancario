using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranscaccionesBacarias
{
    public class StarCuenta:Cuenta
    {
        public static List<Cuenta> cuentas { get; set; }
        public static void Bienvenido()
        {
            Console.WriteLine("             ╔═══════════════════════════════════════════════════════════╗");
            Console.WriteLine("             ║ ** Bienvenido a tu Sistema de Banca en linea Preferido ** ║");
            Console.WriteLine("             ╚═══════════════════════════════════════════════════════════╝");
            Console.WriteLine();
        }
        public static void BienvenidoMenu()
        {
            Console.WriteLine();
            Console.WriteLine("             ╔═══════════════════════════════════════════════════════════╗");
            Console.WriteLine("             ║ ** Bienvenido a tu Sistema de Banca en linea Preferido ** ║");
            Console.WriteLine("             ╚═══════════════════════════════════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine("╔════════════════════╦════════════════════╦══════════════════════╦══════════╦═══════════════╗");
            Console.WriteLine("║[1].Ingresar Dinero ║[2].Retirar Dinero  ║[3].Transferir Dinero ║[4].Salir ║[5].Ver Cuentas║");
            Console.WriteLine("╚════════════════════╩════════════════════╩══════════════════════╩══════════╩═══════════════╝");
            
        }
    }
}
