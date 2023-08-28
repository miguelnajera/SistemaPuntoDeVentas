using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModels.Library;

namespace Sistema_Punto_De_Venta
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }       
        
        #region CodigoClientes
        private void btnClientes_Click(object sender, EventArgs e)
        {
            tabControlPrincipal.SelectedIndex = 1;
        }


        //Evento para cargar foto de cliente
        private void pbFotoCliente_Click(object sender, EventArgs e)
        {
            Objects.uploadimage.CargarImagen(pbFotoCliente);
        }


        //Eventos Campo de Texto ID Cliente
        private void txtIDCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtIDCliente.Text.Equals(""))
            {
                lblIDCliente.ForeColor = Color.LightSlateGray;
            }
            else
            {
                lblIDCliente.ForeColor= Color.Green;
            }
        }

        private void txtIDCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objects.txtEventos.numberKeyPress(e);
        }

        //Eventos Campo de Texto Nombre Cliente
        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreCliente.Text.Equals(""))
            {
                lblNombreCliente.ForeColor = Color.LightSlateGray;
            }
            else
            {
                lblNombreCliente.ForeColor = Color.Green;
            }
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objects.txtEventos.textKeyPress(e);
        }

        //Eventos Campo de Texto Apellido Cliente

        private void txtApellidosCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtApellidosCliente.Text.Equals(""))
            {
                lblApellidoCliente.ForeColor = Color.LightSlateGray;
            }
            else
            {
                lblApellidoCliente.ForeColor = Color.Green;
            }
        }

        private void txtApellidosCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objects.txtEventos.textKeyPress(e);
        }

        //Eventos Campo de Texto Email Cliente

        private void txtEmailCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtEmailCliente.Text.Equals(""))
            {
                lblEmailCliente.ForeColor = Color.LightSlateGray;
            }
            else
            {
                lblEmailCliente.ForeColor = Color.Green;
            }

        }

        //Eventos Campo de Texto Telefono Cliente
        private void txtTelefonoCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefonoCliente.Text.Equals(""))
            {
                lblTelefonoCliente.ForeColor = Color.LightSlateGray;
            }
            else
            {
                lblTelefonoCliente.ForeColor = Color.Green;
            }
        }

        private void txtTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objects.txtEventos.numberKeyPress(e);
        }

        //Eventos Campo de Texto Direccion Cliente
        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            if (txtDireccion.Text.Equals(""))
            {
                lblDireccionCliente.ForeColor = Color.LightSlateGray;
            }
            else
            {
                lblDireccionCliente.ForeColor = Color.Green;
            }

        }





        #endregion


    }
}
