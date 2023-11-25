namespace ProyectoBanco.Vistas
{
    partial class FrmMaestro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboTipoCuenta = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ColTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTipoCuenta
            // 
            this.cboTipoCuenta.FormattingEnabled = true;
            this.cboTipoCuenta.Location = new System.Drawing.Point(27, 111);
            this.cboTipoCuenta.Name = "cboTipoCuenta";
            this.cboTipoCuenta.Size = new System.Drawing.Size(183, 21);
            this.cboTipoCuenta.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Agregue Cliente:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTipo,
            this.ColSaldo,
            this.ColAcciones});
            this.dataGridView1.Location = new System.Drawing.Point(27, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(396, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(372, 23);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.Location = new System.Drawing.Point(24, 79);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(83, 13);
            this.lblTipoCuenta.TabIndex = 5;
            this.lblTipoCuenta.Text = "Tipo de Cuenta:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(234, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(113, 20);
            this.textBox2.TabIndex = 6;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(231, 79);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(37, 13);
            this.lblSaldo.TabIndex = 7;
            this.lblSaldo.Text = "Saldo:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(372, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Cargar";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(76, 317);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(283, 317);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // ColTipo
            // 
            this.ColTipo.HeaderText = "Tipo";
            this.ColTipo.Name = "ColTipo";
            this.ColTipo.ReadOnly = true;
            this.ColTipo.Width = 150;
            // 
            // ColSaldo
            // 
            this.ColSaldo.HeaderText = "Saldo";
            this.ColSaldo.Name = "ColSaldo";
            this.ColSaldo.ReadOnly = true;
            // 
            // ColAcciones
            // 
            this.ColAcciones.HeaderText = "Acciones";
            this.ColAcciones.Name = "ColAcciones";
            this.ColAcciones.ReadOnly = true;
            this.ColAcciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColAcciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColAcciones.Text = "Quitar";
            this.ColAcciones.UseColumnTextForButtonValue = true;
            // 
            // FrmMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 352);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblTipoCuenta);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cboTipoCuenta);
            this.Name = "FrmMaestro";
            this.Text = "Nuevo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTipoCuenta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSaldo;
        private System.Windows.Forms.DataGridViewButtonColumn ColAcciones;
    }
}