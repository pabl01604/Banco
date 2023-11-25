using ProyectoBanco.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBanco.Datos.Interfaz
{
    internal interface IClienteDao
    {
        //CREATE
        bool CrearCliente(Cliente oCliente);

        bool CrearMaestro(Cliente oCliente);
        //READ
        List<Cliente> ObtenerCliente();

        List<Cliente> ObtenerClienteXFiltro(List<Parametro> lista);

        //UPDATE

        bool ActualizarCliente(Cliente oCliente);

        //DELETE

        bool BorrarCliente(int id);





    }
}
