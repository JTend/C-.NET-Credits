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
    public partial class frmSumario : Form
    {
        public frmSumario()
        {
            InitializeComponent();
        }

        private void frmSumario_Resize(object sender, EventArgs e)
        {
            panel1.Width = (int)(panInfo.Width / 3);
            panel2.Width = (int)(panInfo.Width / 3);
            panel3.Width = (int)(panInfo.Width / 3);
        }
    }
}
