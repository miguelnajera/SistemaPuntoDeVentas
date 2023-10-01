namespace Sistema_Punto_De_Venta
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlPrincipal = new System.Windows.Forms.TabControl();
            this.tabVentasMainForm = new System.Windows.Forms.TabPage();
            this.tabClientesMainForm = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabRegistroClientes = new System.Windows.Forms.TabPage();
            this.btnCancelarFormulario = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccionCliente = new System.Windows.Forms.Label();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.lblTelefonoCliente = new System.Windows.Forms.Label();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.txtApellidosCliente = new System.Windows.Forms.TextBox();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.lblIDCliente = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbFotoCliente = new System.Windows.Forms.PictureBox();
            this.tabCreditoClientes = new System.Windows.Forms.TabPage();
            this.tabReportesClientes = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClientes = new System.Windows.Forms.Button();
            this.chkCredito = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControlPrincipal.SuspendLayout();
            this.tabClientesMainForm.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabRegistroClientes.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoCliente)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Blue;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-4, -9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_Punto_De_Venta.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(10, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(160, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema Punto de Ventas";
            // 
            // tabControlPrincipal
            // 
            this.tabControlPrincipal.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlPrincipal.Controls.Add(this.tabVentasMainForm);
            this.tabControlPrincipal.Controls.Add(this.tabClientesMainForm);
            this.tabControlPrincipal.Location = new System.Drawing.Point(-4, 124);
            this.tabControlPrincipal.Multiline = true;
            this.tabControlPrincipal.Name = "tabControlPrincipal";
            this.tabControlPrincipal.SelectedIndex = 0;
            this.tabControlPrincipal.Size = new System.Drawing.Size(718, 573);
            this.tabControlPrincipal.TabIndex = 1;
            // 
            // tabVentasMainForm
            // 
            this.tabVentasMainForm.Location = new System.Drawing.Point(4, 4);
            this.tabVentasMainForm.Name = "tabVentasMainForm";
            this.tabVentasMainForm.Padding = new System.Windows.Forms.Padding(3);
            this.tabVentasMainForm.Size = new System.Drawing.Size(710, 547);
            this.tabVentasMainForm.TabIndex = 0;
            this.tabVentasMainForm.Text = "Ventas";
            this.tabVentasMainForm.UseVisualStyleBackColor = true;
            // 
            // tabClientesMainForm
            // 
            this.tabClientesMainForm.Controls.Add(this.groupBox4);
            this.tabClientesMainForm.Controls.Add(this.groupBox3);
            this.tabClientesMainForm.Location = new System.Drawing.Point(4, 4);
            this.tabClientesMainForm.Name = "tabClientesMainForm";
            this.tabClientesMainForm.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientesMainForm.Size = new System.Drawing.Size(710, 547);
            this.tabClientesMainForm.TabIndex = 1;
            this.tabClientesMainForm.Text = "Clientes";
            this.tabClientesMainForm.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Location = new System.Drawing.Point(287, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(418, 538);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.tabControl2);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 538);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl2.Controls.Add(this.tabRegistroClientes);
            this.tabControl2.Controls.Add(this.tabCreditoClientes);
            this.tabControl2.Controls.Add(this.tabReportesClientes);
            this.tabControl2.Location = new System.Drawing.Point(3, 13);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(269, 519);
            this.tabControl2.TabIndex = 0;
            // 
            // tabRegistroClientes
            // 
            this.tabRegistroClientes.Controls.Add(this.chkCredito);
            this.tabRegistroClientes.Controls.Add(this.btnCancelarFormulario);
            this.tabRegistroClientes.Controls.Add(this.btnAgregarCliente);
            this.tabRegistroClientes.Controls.Add(this.txtDireccion);
            this.tabRegistroClientes.Controls.Add(this.lblDireccionCliente);
            this.tabRegistroClientes.Controls.Add(this.txtTelefonoCliente);
            this.tabRegistroClientes.Controls.Add(this.lblTelefonoCliente);
            this.tabRegistroClientes.Controls.Add(this.txtEmailCliente);
            this.tabRegistroClientes.Controls.Add(this.lblEmailCliente);
            this.tabRegistroClientes.Controls.Add(this.txtApellidosCliente);
            this.tabRegistroClientes.Controls.Add(this.lblApellidoCliente);
            this.tabRegistroClientes.Controls.Add(this.txtNombreCliente);
            this.tabRegistroClientes.Controls.Add(this.lblNombreCliente);
            this.tabRegistroClientes.Controls.Add(this.txtIDCliente);
            this.tabRegistroClientes.Controls.Add(this.lblIDCliente);
            this.tabRegistroClientes.Controls.Add(this.groupBox5);
            this.tabRegistroClientes.Location = new System.Drawing.Point(4, 22);
            this.tabRegistroClientes.Name = "tabRegistroClientes";
            this.tabRegistroClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistroClientes.Size = new System.Drawing.Size(261, 493);
            this.tabRegistroClientes.TabIndex = 0;
            this.tabRegistroClientes.Text = "Registro Clientes";
            this.tabRegistroClientes.UseVisualStyleBackColor = true;
            // 
            // btnCancelarFormulario
            // 
            this.btnCancelarFormulario.BackgroundImage = global::Sistema_Punto_De_Venta.Properties.Resources.icono_cancelar2_48x48;
            this.btnCancelarFormulario.FlatAppearance.BorderSize = 0;
            this.btnCancelarFormulario.Location = new System.Drawing.Point(112, 317);
            this.btnCancelarFormulario.Name = "btnCancelarFormulario";
            this.btnCancelarFormulario.Size = new System.Drawing.Size(49, 48);
            this.btnCancelarFormulario.TabIndex = 14;
            this.btnCancelarFormulario.UseVisualStyleBackColor = true;
            this.btnCancelarFormulario.Click += new System.EventHandler(this.btnCancelarFormulario_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackgroundImage = global::Sistema_Punto_De_Venta.Properties.Resources.icono_add_cliente_48x48;
            this.btnAgregarCliente.FlatAppearance.BorderSize = 0;
            this.btnAgregarCliente.Location = new System.Drawing.Point(47, 317);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(49, 48);
            this.btnAgregarCliente.TabIndex = 13;
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(123, 242);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 7;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // lblDireccionCliente
            // 
            this.lblDireccionCliente.AutoSize = true;
            this.lblDireccionCliente.Location = new System.Drawing.Point(123, 225);
            this.lblDireccionCliente.Name = "lblDireccionCliente";
            this.lblDireccionCliente.Size = new System.Drawing.Size(52, 13);
            this.lblDireccionCliente.TabIndex = 11;
            this.lblDireccionCliente.Text = "Direccion";
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Location = new System.Drawing.Point(7, 242);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoCliente.TabIndex = 6;
            this.txtTelefonoCliente.TextChanged += new System.EventHandler(this.txtTelefonoCliente_TextChanged);
            this.txtTelefonoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoCliente_KeyPress);
            // 
            // lblTelefonoCliente
            // 
            this.lblTelefonoCliente.AutoSize = true;
            this.lblTelefonoCliente.Location = new System.Drawing.Point(7, 225);
            this.lblTelefonoCliente.Name = "lblTelefonoCliente";
            this.lblTelefonoCliente.Size = new System.Drawing.Size(49, 13);
            this.lblTelefonoCliente.TabIndex = 9;
            this.lblTelefonoCliente.Text = "Telefono";
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(123, 201);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(100, 20);
            this.txtEmailCliente.TabIndex = 5;
            this.txtEmailCliente.TextChanged += new System.EventHandler(this.txtEmailCliente_TextChanged);
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Location = new System.Drawing.Point(123, 184);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(32, 13);
            this.lblEmailCliente.TabIndex = 7;
            this.lblEmailCliente.Text = "Email";
            // 
            // txtApellidosCliente
            // 
            this.txtApellidosCliente.Location = new System.Drawing.Point(7, 201);
            this.txtApellidosCliente.Name = "txtApellidosCliente";
            this.txtApellidosCliente.Size = new System.Drawing.Size(100, 20);
            this.txtApellidosCliente.TabIndex = 4;
            this.txtApellidosCliente.TextChanged += new System.EventHandler(this.txtApellidosCliente_TextChanged);
            this.txtApellidosCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidosCliente_KeyPress);
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.Location = new System.Drawing.Point(7, 184);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(49, 13);
            this.lblApellidoCliente.TabIndex = 5;
            this.lblApellidoCliente.Text = "Apellidos";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(123, 157);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCliente.TabIndex = 3;
            this.txtNombreCliente.TextChanged += new System.EventHandler(this.txtNombreCliente_TextChanged);
            this.txtNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCliente_KeyPress);
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(123, 140);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(44, 13);
            this.lblNombreCliente.TabIndex = 3;
            this.lblNombreCliente.Text = "Nombre";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Location = new System.Drawing.Point(7, 157);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIDCliente.TabIndex = 2;
            this.txtIDCliente.TextChanged += new System.EventHandler(this.txtIDCliente_TextChanged);
            this.txtIDCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDCliente_KeyPress);
            // 
            // lblIDCliente
            // 
            this.lblIDCliente.AutoSize = true;
            this.lblIDCliente.Location = new System.Drawing.Point(7, 140);
            this.lblIDCliente.Name = "lblIDCliente";
            this.lblIDCliente.Size = new System.Drawing.Size(18, 13);
            this.lblIDCliente.TabIndex = 1;
            this.lblIDCliente.Text = "ID";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.pbFotoCliente);
            this.groupBox5.Location = new System.Drawing.Point(47, 17);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(165, 112);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Informacion Cliente";
            // 
            // pbFotoCliente
            // 
            this.pbFotoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFotoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFotoCliente.Location = new System.Drawing.Point(36, 28);
            this.pbFotoCliente.Name = "pbFotoCliente";
            this.pbFotoCliente.Size = new System.Drawing.Size(90, 80);
            this.pbFotoCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoCliente.TabIndex = 0;
            this.pbFotoCliente.TabStop = false;
            this.pbFotoCliente.Click += new System.EventHandler(this.pbFotoCliente_Click);
            // 
            // tabCreditoClientes
            // 
            this.tabCreditoClientes.Location = new System.Drawing.Point(4, 22);
            this.tabCreditoClientes.Name = "tabCreditoClientes";
            this.tabCreditoClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreditoClientes.Size = new System.Drawing.Size(261, 493);
            this.tabCreditoClientes.TabIndex = 1;
            this.tabCreditoClientes.Text = "Credito";
            this.tabCreditoClientes.UseVisualStyleBackColor = true;
            // 
            // tabReportesClientes
            // 
            this.tabReportesClientes.Location = new System.Drawing.Point(4, 22);
            this.tabReportesClientes.Name = "tabReportesClientes";
            this.tabReportesClientes.Size = new System.Drawing.Size(261, 493);
            this.tabReportesClientes.TabIndex = 2;
            this.tabReportesClientes.Text = "Reportes Clientes";
            this.tabReportesClientes.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnClientes);
            this.groupBox2.Location = new System.Drawing.Point(2, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(712, 60);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnClientes
            // 
            this.btnClientes.BackgroundImage = global::Sistema_Punto_De_Venta.Properties.Resources.icono_clientes_48x48;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Location = new System.Drawing.Point(7, 9);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(55, 45);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // chkCredito
            // 
            this.chkCredito.AutoSize = true;
            this.chkCredito.Location = new System.Drawing.Point(7, 273);
            this.chkCredito.Name = "chkCredito";
            this.chkCredito.Size = new System.Drawing.Size(89, 17);
            this.chkCredito.TabIndex = 15;
            this.chkCredito.Text = "Tiene Credito";
            this.chkCredito.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(717, 709);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControlPrincipal);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Punto de Venta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControlPrincipal.ResumeLayout(false);
            this.tabClientesMainForm.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabRegistroClientes.ResumeLayout(false);
            this.tabRegistroClientes.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoCliente)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlPrincipal;
        private System.Windows.Forms.TabPage tabVentasMainForm;
        private System.Windows.Forms.TabPage tabClientesMainForm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabRegistroClientes;
        private System.Windows.Forms.TabPage tabCreditoClientes;
        private System.Windows.Forms.TabPage tabReportesClientes;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbFotoCliente;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.Label lblTelefonoCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.TextBox txtApellidosCliente;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.Label lblIDCliente;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccionCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelarFormulario;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.CheckBox chkCredito;
    }
}

