using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Creditos
{
    public partial class FrmClientes : Form
    {
        public static String Seleccionado;
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            Seleccionado = "";
            dgProductos.DataSource = Login.CSQ.Consulta("select codprod, descrip, existen, precio1 " +
                "from saprod where existen > 0 and descrip like '%"+ txtBuscar.Text +"%'");
        }
    }
}
