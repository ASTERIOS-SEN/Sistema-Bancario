using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranscaccionesBacarias
{
    public class Cuenta
    {        
        public int NumeroDeCuenta { get; set; }
        public int Pin { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaEmision { get; set; }
        public string Estado { get; set; }
        public decimal Saldo { get; set; }

        public Cuenta()//Inicializar los datos de cuenta.
        {
            this.NumeroDeCuenta = 0000;
            this.Pin = 0000;
            this.Nombre = "";
            this.Apellido = "";
            this.FechaEmision = DateTime.Now;
            this.Estado = "";
            this.Saldo = 0;
        }
        public Cuenta(int NumeroCuenta, int Pin, string Nombre, string Apellido, DateTime FechaEmision, string Estado, decimal saldo)
        {
            this.NumeroDeCuenta = NumeroCuenta;
            this.Pin = Pin;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.FechaEmision = FechaEmision;
            this.Estado = Estado;
            this.Saldo = saldo;
        }
        public decimal ingresarDinero(decimal saldo)
        {
            if (saldo == 0 || saldo < 0)
            {
                return 0;
            }
            else
            {
                this.Saldo += saldo;
                return saldo;
            }
        }
        public decimal RetirarDinero(decimal saldo)
        {
            if (this.Saldo == 0 || this.Saldo < 0)
            {
                return 0;
            }
            if (this.Saldo < saldo)
            {
                return 0;
            }
            else
            {
                this.Saldo -= saldo;
                return saldo;
            }
        }
        public decimal tranferirDinero(decimal saldo)
        {
            if (saldo <= 0 )
            {
                if (this.Saldo < saldo)
                {
                    return 0;
                }
                return 0;
            }
            else
            {
                this.Saldo -= saldo;
                return saldo;
            }
        }
        public decimal verificarCuenta(decimal saldo)
        {
            if (saldo <= 0)
            {
                return 0;
            }
            if (this.Saldo < saldo)
            {
                return 0;
            }
            else
            {
                return 1;
            }

        }

        public string DatosCuenta()
        {
            Console.WriteLine(" ╔═════════════════════════════════════════════════════════════╗");
            Console.WriteLine("  Nº Cuenta: " + NumeroDeCuenta + " Propietario: "+ Nombre +" "+ Apellido + " Saldo: "+ Saldo +"");
            Console.WriteLine(" ╚═════════════════════════════════════════════════════════════╝");
            Console.WriteLine();
            return null;
            
          // Console.WriteLine( );
        }

        public string Propietario()
        {
           return NumeroDeCuenta + " del Propietario: " + Nombre + " " + Apellido;
        }
    }
}
