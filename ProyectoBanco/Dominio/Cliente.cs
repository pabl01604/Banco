using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBanco.Dominio
{
    public class Cliente
    {
        public int Id_Cliente { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Dni { get; set; }

        public List<Cuenta> lCuenta { get; set; }


        public Cliente()
        {
            Id_Cliente = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            Dni = string.Empty;
        }

        public Cliente(int id, string nom, string ape, string dni)
        {
            Id_Cliente = id;
            Nombre = nom;
            Apellido = ape;
            Dni = dni;
        }

        public void AgregarCuenta(Cuenta c)
        {
            lCuenta.Add(c);
        }

        public void QuitarCuenta(int id)
        {
            lCuenta.RemoveAt(id);
        }

        public override string ToString()
        {
            return Apellido+", " +Nombre;
        }


    }
}
