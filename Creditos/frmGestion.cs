using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creditos
{
    public partial class frmGestion : Form
    {
        public frmGestion()
        {
            InitializeComponent();
        }

        private void frmGestion_Shown(object sender, EventArgs e)
        {
            cmbTipo.SelectedIndex = 0;
            lblFormula.Text = "0X" + (char)(178) + " + 10X + 0";
        }

        private void dgProductos_Resize(object sender, EventArgs e)
        {
            dgProductos.Columns[0].Width = (int)(dgProductos.Width * 0.15);
            dgProductos.Columns[1].Width = (int)(dgProductos.Width * 0.40);
            dgProductos.Columns[2].Width = (int)(dgProductos.Width * 0.10);
            dgProductos.Columns[3].Width = (int)(dgProductos.Width * 0.15);
            dgProductos.Columns[4].Width = (int)(dgProductos.Width * 0.15);
        }

        private void frmGestion_Load(object sender, EventArgs e)
        {
            dgCreditos.DataSource = Login.MyS.ConsultaTabla(
                "select C.idcredito as Codigo, Cl.nombre as Cliente, C.Estado as Estado " +
                "from credito as C join cliente as Cl on C.idcliente = Cl.idcliente " +
                "order by fechac desc");
        }
    }
}
