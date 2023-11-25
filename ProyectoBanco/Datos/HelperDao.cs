using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBanco.Datos
{
    public class HelperDao
    {
        private SqlConnection conexion;
        private static HelperDao instancia;
        private  HelperDao()
        {
            conexion = new SqlConnection(Properties.Resources.CadenaConexion);
        }

        public static HelperDao GetInstance()
        {
            if (instancia == null)
            {
                instancia = new HelperDao();
            }
            return instancia;
        }

        public SqlConnection ObtenerConexion()
        {
            return conexion;
        }


        //   READ    Consulta con filtros
        public DataTable Consultar(string nombresp, List<Parametro> list)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombresp;
            foreach (Parametro p in list)
            {
                comando.Parameters.AddWithValue(p.Nombre, p.Valor);
            }
            DataTable tabla = new DataTable();
                
            tabla.Load(comando.ExecuteReader());
            conexion.Close();

            return tabla;
        }

        //Consulta sin filtros
        public DataTable Consultar(string nombresp)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombresp;
            
            DataTable tabla = new DataTable();

            tabla.Load(comando.ExecuteReader());
            conexion.Close();

            return tabla;
        }


        // CREATE Insertar registro 

        public bool InsertarSimple( string nombresp,List<Parametro> list)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = nombresp;
                foreach (Parametro p in list)
                {
                    comando.Parameters.AddWithValue(p.Nombre,p.Valor);
                }
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (conexion != null &&conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            
           
        }


        //INSERTAR CON TRANSACCION

        public bool InsertarConTransacc(string nombrespMaestro,string nombrespDetalle,List<Parametro> list, List<Parametro> lDetalle, string nombresalida,string enlace)
        {
            SqlTransaction t= null;
            bool resultado = true;
            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand(nombrespMaestro, conexion, t);
                comando.CommandType = CommandType.StoredProcedure;
                foreach (Parametro p in list)
                {
                    comando.Parameters.AddWithValue(p.Nombre, p.Valor);
                }

                SqlParameter parametro = new SqlParameter(nombresalida, SqlDbType.Int);
                parametro.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parametro);


                comando.ExecuteNonQuery();

                int nro = (int)parametro.Value;
                SqlCommand cmdDetalle = new SqlCommand(nombrespDetalle,conexion,t);
                cmdDetalle.CommandType = CommandType.StoredProcedure;
                foreach (Parametro p in lDetalle)
                {
                    cmdDetalle.Parameters.AddWithValue(p.Nombre, p.Valor);
                }
                cmdDetalle.Parameters.AddWithValue(enlace, nro);

                cmdDetalle.ExecuteNonQuery();

                t.Commit();
            }
            catch (Exception)
            {
                if (t != null)
                    t.Rollback();
                
                resultado=false;
              
            }
            finally
            {
                if(conexion!=null && conexion.State==ConnectionState.Open)
                    conexion.Close();
            }
            return resultado;
        }


        public bool Borrar(List<Parametro> list, string nombreSp)
        {
            bool resultado = true;
            conexion.Open();
            try
            {
                SqlCommand comando = new SqlCommand(nombreSp, conexion);
                comando.CommandType = CommandType.StoredProcedure;
                foreach (Parametro p in list)
                {
                    comando.Parameters.AddWithValue(p.Nombre, p.Valor);
                }
                comando.ExecuteNonQuery();


            }
            catch (Exception)
            {

                resultado = false;
            }
            finally
            {
                if(conexion != null && conexion.State==ConnectionState.Open)
                    conexion.Close();
            }


            return resultado;

        }





    }
}
