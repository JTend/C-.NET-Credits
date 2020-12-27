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
    public partial class frmParam : Form
    {
        public frmParam()
        {
            InitializeComponent();
        }

        private void frmParam_Shown(object sender, EventArgs e)
        {
            dgCats.DataSource = Login.MyS.ConsultaTabla("select idtipo, descripcion from tipocredito order by idtipo");

        }

        private void dgCats_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Login.MyS.Consulta("select parama, paramb, paramc, maxc, minc from tipocredito where idtipo = " + dgCats.SelectedRows[0].Cells[0].Value);
            if (Login.MyS.Siguiente())
            {
                numA.Value = Int32.Parse(Login.MyS.Campo(0));
                numB.Value = Int32.Parse(Login.MyS.Campo(1));
                numC.Value = Int32.Parse(Login.MyS.Campo(2));
                nuMax.Value = Int32.Parse(Login.MyS.Campo(3));
                nuMax.Value = Int32.Parse(Login.MyS.Campo(4));
            }
        }
    }
}
