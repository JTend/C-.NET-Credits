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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        
        private void panSup_Resize(object sender, EventArgs e)
        {
            dgUsuarios.Columns[0].Width = (int)(dgUsuarios.Width * 0.15);
            dgUsuarios.Columns[1].Width = (int)(dgUsuarios.Width * 0.65);
            dgUsuarios.Columns[2].Width = (int)(dgUsuarios.Width * 0.15);
            panel13.Width = (int)(panel7.Width / 2);
            panel14.Width = (int)(panel7.Width / 2);
        }

        private void frmUsuarios_Shown(object sender, EventArgs e)
        {
            if (this.panOpciones.Controls.Count > 0)
                this.panOpciones.Controls.RemoveAt(0);
            frmMenuinf Mnu = new frmMenuinf();
            Mnu.TopLevel = false;
            Mnu.Dock = DockStyle.Fill;
            this.panOpciones.Controls.Add(Mnu);
            this.panOpciones.Tag = Mnu;
            Mnu.Show();

            dgUsuarios.Rows.Add("16197633", "Jose Tendero", "Activo");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                checkBox1.Text = "Activo";
            else
                checkBox1.Text = "Bloqueado";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar);
        }
    }
}
