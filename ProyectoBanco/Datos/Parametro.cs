using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBanco.Datos
{
    public class Parametro
    {
        public string Nombre { get; set; }

        public Object Valor { get; set; }

        public Parametro(string n, Object v)
        {
            Nombre= n; 
            
            Valor = v;
        }


    }
}
