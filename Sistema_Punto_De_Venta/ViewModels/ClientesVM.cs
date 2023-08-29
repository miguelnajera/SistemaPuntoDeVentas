using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewModels
{
    public class ClientesVM
    {
        private List<TextBox> _lstClientesTexbox;
        private List<Label> _lstClientesLabel;

        public ClientesVM(List<TextBox> lstClientesTexbox, List<Label> lstClientesLabel)
        {
            _lstClientesTexbox = lstClientesTexbox;
            _lstClientesLabel = lstClientesLabel;
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
            }
            
        }
    }
}
