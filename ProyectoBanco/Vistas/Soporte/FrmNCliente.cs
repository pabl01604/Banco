using ProyectoBanco.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBanco.Vistas.Soporte
{
    public partial class FrmNCliente : Form
    {
        Cliente nuevo;  
        public FrmNCliente(Estado estado)
        {
            InitializeComponent();
            nuevo = new Cliente();
            oEstado = estado;
        }
        public FrmNCliente(Estado estado,Cliente oCli)
        {
            InitializeComponent();
            nuevo = oCli;
            oEstado = estado;
        }


        public enum Estado
        {
            Nuevo,
            Existente
        }

        Estado oEstado;


        //Botón Salir
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea cancelar la creacion de un nuevo cliente?", "CANCELAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
        //Botón Aceptar 
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Validacion

            if (Validar())
            {
                Cliente c = new Cliente();
                c.Nombre = txtNombre.Text;
                c.Apellido = txtApellido.Text;
                c.Dni = txtDni.Text;
            }



        }
        //Metodos auxiliares a Aceptar  
        private bool Validar()
        {
            if(string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un Nombre");
                return false;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Debe ingresar un Apellido");
                return false;
            }
            if (string.IsNullOrEmpty(txtDni.Text))
            {
                MessageBox.Show("Debe ingresar un DNI");
                return false;
            }
            //if(oEstado == Estado.Nuevo)
            //{ Esto es para verificar si existe un cliente con el mismo dni

            //}

            return true;
        }
        
        private void FrmNCliente_Load(object sender, EventArgs e)
        {
            if (oEstado == Estado.Nuevo)
            {
                Limpiar();
            }
            else if (oEstado == Estado.Existente)
            {
                txtNombre.Text =nuevo.Nombre;
                txtApellido.Text =nuevo.Apellido;
                txtDni.Text =nuevo.Dni;
            }
        }

        private void Limpiar()
        {
            txtApellido.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDni.Text = string.Empty;
        }
    }
}
