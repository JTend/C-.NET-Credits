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
    public partial class Tablero : Form
    {
        public Tablero()
        {
            InitializeComponent();
        }

        private void Tablero_Shown(object sender, EventArgs e)
        {
            radSumario_Click(this, e);
        }
        
        private void radSumario_Click(object sender, EventArgs e)
        {
            if (this.panOpciones.Controls.Count > 0)
                this.panOpciones.Controls.RemoveAt(0);
            frmMenuinf Mnu = new frmMenuinf();
            Mnu.TopLevel = false;
            Mnu.Dock = DockStyle.Fill;
            this.panOpciones.Controls.Add(Mnu);
            this.panOpciones.Tag = Mnu;
            Mnu.Show();

            if (this.panInfo.Controls.Count > 0)
                this.panInfo.Controls.RemoveAt(0);
            frmSumario Inf = new frmSumario();
            Inf.TopLevel = false;
            Inf.Dock = DockStyle.Fill;
            this.panInfo.Controls.Add(Inf);
            this.panInfo.Tag = Inf;
            Inf.Show();
        }
    }
}
