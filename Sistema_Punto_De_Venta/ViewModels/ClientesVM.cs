using LinqToDB;
using Models.Conexion;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModels.Library;

namespace ViewModels
{
    public class ClientesVM : Conexion
    {
        private List<TextBox> _lstClientesTexbox;
        private List<Label> _lstClientesLabel;
        private TextBoxEvent oEvento;
        private string _accion = "insert";
        private PictureBox _imagePictureBox;
        private CheckBox _checkBoxCredito;
        private Bitmap _imageBitmap;

        public ClientesVM(object[] objetos, List<TextBox> lstClientesTexbox, List<Label> lstClientesLabel)
        {
            _lstClientesTexbox = lstClientesTexbox;
            _lstClientesLabel = lstClientesLabel;
            _imagePictureBox = (PictureBox)objetos[0];
            _checkBoxCredito = (CheckBox)objetos[1];
            _imageBitmap = (Bitmap)objetos[2];
            oEvento = new TextBoxEvent();
        }

        public void guardarCliente()
        {
            for (int i = 0; i < _lstClientesTexbox.Count; i++)
            {
                if (_lstClientesTexbox[i].Text.Equals(""))
                {
                    _lstClientesLabel[i].Text = "Este campo es requerido";
                    _lstClientesLabel[i].ForeColor = Color.Red;
                    _lstClientesTexbox[i].Focus();
                    i = _lstClientesTexbox.Count + 1;
                }

                if (_lstClientesLabel[i].Text.Equals("Email"))
                {
                    if (!oEvento.comprobarFormatoEmail(_lstClientesTexbox[i].Text))
                    {
                        _lstClientesLabel[i].Text = "Email invalido";
                        _lstClientesLabel[i].ForeColor = Color.Red;
                        _lstClientesTexbox[i].Focus();
                        i = _lstClientesTexbox.Count + 1;
                    }
                }







            }
            //Busca que el ID y el email no esten en la base de datos asignados a ningun otro cliente
            var cliente1 = TClientes.Where(p => p.Nid.Equals(_lstClientesTexbox[0].Text)).ToList();
            var cliente2 = TClientes.Where(p => p.Email.Equals(_lstClientesTexbox[3].Text)).ToList();
            var lista = cliente1.Union(cliente2).ToList();
            //Selecciona la accion que va a ejecutar segun la variable accion
            switch (_accion)
            {
                case "insert":
                    if (lista.Count.Equals(0))
                    {
                        SaveData();
                    }
                    else
                    {
                        if (lista[0].Nid.Equals(_lstClientesTexbox[0].Text))
                        {
                            _lstClientesLabel[0].Text = "El nid ya esta registrado";
                            _lstClientesLabel[0].ForeColor = Color.Red;
                            _lstClientesTexbox[0].Focus();
                        }

                        if (lista[0].Email.Equals(_lstClientesTexbox[3].Text))
                        {
                            _lstClientesLabel[3].Text = "El email ya esta registrado";
                            _lstClientesLabel[3].ForeColor = Color.Red;
                            _lstClientesTexbox[3].Focus();
                        }
                    }
                    break;
            }

        }

        private void SaveData()
        {
            //Funcines de la libreria linq2db
            BeginTransactionAsync();
            try
            {
                var srcImage = Objects.uploadimage.ResizeImage(_imagePictureBox.Image, 90, 80);
                var image = Objects.uploadimage.ImageToByte(srcImage);

                switch (_accion)
                {
                    case "insert":
                        TClientes.Value(c => c.Nid, _lstClientesTexbox[0].Text)
                            .Value(u => u.Nombre, _lstClientesTexbox[1].Text)
                            .Value(u => u.Apellido, _lstClientesTexbox[2].Text)
                            .Value(u => u.Email, _lstClientesTexbox[3].Text)
                            .Value(u => u.Telefono, _lstClientesTexbox[4].Text)
                            .Value(u => u.Direccion, _lstClientesTexbox[5].Text)
                            .Value(u => u.Credito, _checkBoxCredito.Checked)
                            .Value(u => u.Fecha, DateTime.Now.ToString("dd/MM/yyy"))
                            .Value(u => u.Imagen, image)
                            .Insert();

                        var cliente = TClientes.ToList().Last();

                        TReportes_clientes.Value(u => u.UltimoPago, 0)
                            .Value(u => u.FechaPago, "--/--/--")
                            .Value(u => u.DeudaActual, 0)
                            .Value(u => u.FechaDeuda, "--/--/--")
                            .Value(u => u.Ticket, "0000000000")
                            .Value(u => u.FechaLimite, "--/--/--")
                            .Value(u => u.IdCliente, cliente.IdCliente)
                            .Insert();
                        break;
                }
                CommitTransaction();
                restablecer();
            }
            catch (Exception ex)
            {
                RollbackTransaction();
                MessageBox.Show(ex.Message);
            }
        }

        public void restablecer()
        {
            _accion = "insert";
            _imagePictureBox.Image = _imageBitmap;
            _lstClientesTexbox[0].Text = "";
            _lstClientesTexbox[1].Text = "";
            _lstClientesTexbox[2].Text = "";
            _lstClientesTexbox[3].Text = "";
            _lstClientesTexbox[4].Text = "";
            _lstClientesTexbox[5].Text = "";
            _checkBoxCredito.Checked = false;
            _lstClientesLabel[0].Text = "Nid";
            _lstClientesLabel[0].ForeColor = Color.LightSlateGray;
            _lstClientesLabel[1].Text = "Nombre";
            _lstClientesLabel[1].ForeColor = Color.LightSlateGray;
            _lstClientesLabel[2].Text = "Apellido";
            _lstClientesLabel[2].ForeColor = Color.LightSlateGray;
            _lstClientesLabel[3].Text = "Email";
            _lstClientesLabel[3].ForeColor = Color.LightSlateGray;
            _lstClientesLabel[4].Text = "Telefono";
            _lstClientesLabel[4].ForeColor = Color.LightSlateGray;
            _lstClientesLabel[5].Text = "Direccion";
            _lstClientesLabel[5].ForeColor = Color.LightSlateGray;
        }
    }
}
