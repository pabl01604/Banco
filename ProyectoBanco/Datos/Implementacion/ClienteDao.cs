using ProyectoBanco.Datos.Interfaz;
using ProyectoBanco.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBanco.Datos.Implementacion
{
    internal class ClienteDao : IClienteDao
    {
        public bool ActualizarCliente(Cliente oCliente)
        {
            List<Parametro> lParametro = new List<Parametro>();
            lParametro.Add(new Parametro("@Id_cliente", oCliente.Id_Cliente));
            lParametro.Add(new Parametro("@dni", oCliente.Dni));
            lParametro.Add(new Parametro("@nombre", oCliente.Nombre));
            lParametro.Add(new Parametro("@apellido", oCliente.Apellido));


            bool resultado = HelperDao.GetInstance().InsertarSimple("SP_MODIFICAR_CLIENTE", lParametro);
            return resultado;
        }

        public bool BorrarCliente(int id)
        {
            throw new NotImplementedException();
        }


        //ESTE METODO ES POR SI DAMOS DE ALTA UN CLIENTE DESDE SOPORTE
        public bool CrearCliente(Cliente oCliente)
        {
            List<Parametro> lParametro = new List<Parametro>();
            lParametro.Add(new Parametro("@dni",oCliente.Dni));
            lParametro.Add(new Parametro("@nombre",oCliente.Nombre));
            lParametro.Add(new Parametro("@apellido",oCliente.Apellido));

            bool resultado = HelperDao.GetInstance().InsertarSimple("SP_INSERTAR_CLIENTE", lParametro);
            return resultado;
        }

        //ESTE METODO ES POR SI QUEREMOS CREAR CLIENTE DESDE LA TABLA MAESTRO-DETALLE
        public bool CrearMaestro(Cliente oCliente)
        {
            List<Parametro> lParametro = new List<Parametro>();
            lParametro.Add(new Parametro("@dni", oCliente.Dni));
            lParametro.Add(new Parametro("@nombre", oCliente.Nombre));
            lParametro.Add(new Parametro("@apellido", oCliente.Apellido));

            List<Parametro> lParamDet = new List<Parametro>();


            foreach (Cuenta c in oCliente.lCuenta)
            {
                lParamDet.Add(new Parametro("@id_tipo", c.OTipo.Id_Tipo));
                lParamDet.Add(new Parametro("@saldo", c.Saldo));
                lParamDet.Add(new Parametro("@ultimo_mov", c.UltMov));
                lParamDet.Add(new Parametro("@fecha_ult_mov", c.FechaUltMov));
            }


            bool resultado = HelperDao.GetInstance().InsertarConTransacc("SP_INSERTAR_MAESTRO", 
                "SP_INSERTAR_DETALLE", lParametro, lParamDet, "@cliente_nro", "@id_cliente");
            return resultado;
        }



        //PARA TABLA SOPORTE
        public List<Cliente> ObtenerCliente()
        {
            DataTable tabla = HelperDao.GetInstance().Consultar("SP_CONSULTAR_CLIENTES");
            List<Cliente> lClientes = new List<Cliente>();

            foreach (DataRow fila in tabla.Rows)
            {
                Cliente c = new Cliente();
                c.Apellido = fila["apellido"].ToString();
                c.Nombre = fila["nombre"].ToString();
                c.Dni = fila["dni"].ToString();
                lClientes.Add(c);
            }

            return lClientes;
        }

        public List<Cliente> ObtenerClienteXFiltro(List<Parametro> lista)
        {
            DataTable tabla = HelperDao.GetInstance().Consultar("SP_CONSULTAR_CLIENTES");
            List<Cliente> lClientes = new List<Cliente>();

            foreach (DataRow fila in tabla.Rows)
            {
                Cliente c = new Cliente();
                c.Apellido = fila["apellido"].ToString();
                c.Nombre = fila["nombre"].ToString();
                c.Dni = fila["dni"].ToString();
                lClientes.Add(c);
            }

            return lClientes;
        }
    }
}
