using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBanco.Dominio
{
    public class TipoDeCuenta
    {
        public int Id_Tipo { get; set; }

        public string Nombre { get; set; }

        public TipoDeCuenta()
        {
            Id_Tipo = 0;
            Nombre = string.Empty;
        }

        TipoDeCuenta(int id, string nom)
        {
            Id_Tipo = id;
            Nombre = nom;
        }

        public override string ToString()
        {
            return Id_Tipo + ", " + Nombre;
        }


    }
}
