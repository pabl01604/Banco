using ProyectoBanco.Vistas.Maestro;
using ProyectoBanco.Vistas.Soporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoBanco.Vistas.Soporte.FrmNCliente;

namespace ProyectoBanco.Vistas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        //Botón Salir
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que quiere salir del programa?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        //Botón Nuevo Soporte
        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNCliente nuevo = new FrmNCliente(Estado.Nuevo);
            nuevo.ShowDialog();
        }
        //Botón Consultar soporte
        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarC nuevo = new FrmConsultarC();
            nuevo.ShowDialog();
        }

        //Botón Nuevo Maestro

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMaestro nuevo = new FrmMaestro();
            nuevo.ShowDialog();
        }

        //Botón consultar cliente con cuentas
        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultar nuevo = new FrmConsultar();
            nuevo.ShowDialog();
        }
    }
}
