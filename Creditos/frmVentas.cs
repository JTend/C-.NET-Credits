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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void dgProductos_Resize(object sender, EventArgs e)
        {
            dgProductos.Columns[0].Width = (int)(dgProductos.Width * 0.15);
            dgProductos.Columns[1].Width = (int)(dgProductos.Width * 0.40);
            dgProductos.Columns[2].Width = (int)(dgProductos.Width * 0.10);
            dgProductos.Columns[3].Width = (int)(dgProductos.Width * 0.15);
            dgProductos.Columns[4].Width = (int)(dgProductos.Width * 0.15);
        }

        private void frmVentas_Shown(object sender, EventArgs e)
        {
            cmbTipo.SelectedIndex = 0;
            lblFormula.Text = "0X" + (char)(178) + " + 10X + 0";
            CargarCreditos();
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else if (Char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void CargarCreditos()
        {
            String ConsultaSQL = "select C.idcredito as Codigo, Cl.nombre as Cliente, C.Estado as Estado " +
                "from credito as C join cliente as Cl on C.idcliente = Cl.idcliente ";
            if(radNuevo.Checked)
            {
                ConsultaSQL = ConsultaSQL + "where estado = 1";
            }
            else if(radRevis.Checked)
            {
                ConsultaSQL = ConsultaSQL + "where estado = 2";
            }
            else if (radNegad.Checked)
            {
                ConsultaSQL = ConsultaSQL + "where estado = 0";
            }
            else if (radAprob.Checked)
            {
                ConsultaSQL = ConsultaSQL + "where estado = 3";
            }
            else if (radEntregado.Checked)
            {
                ConsultaSQL = ConsultaSQL + "where estado = 4";
            }
            ConsultaSQL = ConsultaSQL + " and ((C.idcredito like '%"+ txtBuscar.Text + "%') or (Cl.idcliente like '%" + txtBuscar.Text + "%'))";
            ConsultaSQL = ConsultaSQL + " order by C.idcredito desc";
            dgCreditos.DataSource = Login.MyS.ConsultaTabla(ConsultaSQL);
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {

        }

        private void TxtCedula_TextChanged(object sender, EventArgs e)
        {
            Login.CSQ.Consulta("select descrip, direc1, telef from saclie where codclie = '" + TxtCedula.Text + "'");
            if (Login.CSQ.Siguiente())
            {
                LblNombre.Text = Login.CSQ.Campo(0);
                LblDireccion.Text = Login.CSQ.Campo(1);
                LblTelefono.Text = Login.CSQ.Campo(2);

            }
            else
            {
                LblNombre.Text = "";
                LblDireccion.Text = "";
                LblTelefono.Text = "";
            }
        }

        private void LblTelefono_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel5.Enabled = false;
            button1.Enabled = true;
            button3.Enabled = true;
            //Login.MyS.Consulta("select auto_increment from information_schema.tables " +
            //    "where table_name = 'credito' and table_schema = credito");
            //if(Login.MyS.Siguiente())
            //{

            //}
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarCreditos();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FrmProductos().ShowDialog(this);
            if(FrmProductos.Seleccionado != "")
            {
                Login.CSQ.Consulta("select codprod, descrip, precio1 from saprod where codprod = '" 
                    + FrmProductos.Seleccionado + "'");
                if(Login.CSQ.Siguiente())
                {
                    double D;
                    Double.TryParse(Login.CSQ.Campo(2), out D);
                    dgProductos.Rows.Add(Login.CSQ.Campo(0), Login.CSQ.Campo(1), FrmProductos.Cantidad, Login.CSQ.Campo(2), (FrmProductos.Cantidad * D));
                }
            }
        }

        private void radNuevo_CheckedChanged(object sender, EventArgs e)
        {
            CargarCreditos();
        }

        private void radRevis_CheckedChanged(object sender, EventArgs e)
        {
            CargarCreditos();
        }

        private void radNegad_CheckedChanged(object sender, EventArgs e)
        {
            CargarCreditos();
        }

        private void radAprob_CheckedChanged(object sender, EventArgs e)
        {
            CargarCreditos();
        }

        private void radEntregado_CheckedChanged(object sender, EventArgs e)
        {
            CargarCreditos();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgCreditos.Rows.Clear();
        }
    }
}
