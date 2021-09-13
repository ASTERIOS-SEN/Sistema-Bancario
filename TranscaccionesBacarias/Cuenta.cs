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
        public void ingresarDinero(decimal saldo)
        {
            this.Saldo += saldo;
        }
        public void RetirarDinero(decimal saldo)
        {
            this.Saldo -= saldo;
        }
        public decimal tranferirDinero(decimal saldo)
        {
            if (saldo >= 0)
            {
                this.Saldo -= saldo;
                return saldo;
            }
            else
                return 0;
            
        }
    }
}
