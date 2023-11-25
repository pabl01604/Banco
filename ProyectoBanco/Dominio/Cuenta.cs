using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBanco.Dominio
{
    public class Cuenta
    {
        public int Cbu { get; set; }


        public decimal Saldo { get; set; }


        public TipoDeCuenta OTipo { get; set; }

        public decimal UltMov { get; set; }

        public DateTime FechaAltaMov { get; set; }
        public DateTime FechaUltMov { get; set; }

        public Cuenta()
        {
            Cbu =0 ;
            Saldo=0 ;
            OTipo= null;
            UltMov=0 ;
            FechaAltaMov= DateTime.Today;
            FechaUltMov= DateTime.Today;
            
        }

        public Cuenta(int cbu, decimal s, TipoDeCuenta tipo, decimal ult, DateTime alta, DateTime ultmov)
        {
            Cbu = cbu;
            Saldo = s;
            OTipo = tipo;
            UltMov = ult;
            FechaAltaMov = alta;
            FechaUltMov = ultmov;
        }

        public override string ToString()
        {
            return OTipo.Nombre + " - " + Cbu + " - " + Saldo; 
        }

    }
}
