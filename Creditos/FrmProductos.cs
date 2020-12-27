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
    public partial class FrmProductos : Form
    {
        public static String Seleccionado;
        public static int Cantidad;

        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            Seleccionado = "";
            dgProductos.DataSource = Login.CSQ.Consulta("select codprod, descrip, existen, precio1 " +
                "from saprod where existen > 0 and descrip like '%" + txtBuscar.Text + "%'");
        }

        private void btnSel_Click(object sender, EventArgs e)
        {
            Seleccionado = dgProductos.SelectedRows[0].Cells[0].Value.ToString();
            Cantidad = (int)udCant.Value;
            this.Close();
        }

        private void dgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSel.Enabled = true;
        }
    }
}
