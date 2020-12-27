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
    public partial class Login : Form
    {
        public static ConAccess ACC;
        public static ConMySQL MyS;
        public static ConSQLServer CSQ;
        private int Errores;

        public Login()
        {
            InitializeComponent();
            ACC = new ConAccess();
            Errores = 0;
        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if  (e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSymbol(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            MyS.Consulta("select Cedula from usuario where cedula = "+ TxtUsuario.Text +" and clave = '"+ TxtClave.Text +"' and estado = 1");
            if (MyS.Siguiente())
            {
                MyS.Sentencia("update usuario set fechac = now() where cedula = " + MyS.Campo(0));
                new Inicio().Show();
                this.Close();
            }
            else
            {
                Errores += 1;
                if(Errores < 3)
                {
                    MessageBox.Show("Datos inválidos!");
                }
                else
                {
                    MessageBox.Show("Datos inválidos, el proceso será terminado!");
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ACC = new ConAccess();
            ACC.Consulta("select dirip, based, usuario, clave from conex where tipocon = 1");
            if (ACC.Siguiente())
            {
                try
                {
                    MyS = new ConMySQL(ACC.Campo(0), ACC.Campo(1), ACC.Campo(2), ACC.Campo(3));
                }
                catch(Exception E)
                {
                    MessageBox.Show("No se pudo establecer la conexión principal\n" + E.Message);
                    new Conexion().ShowDialog();
                    this.Close();
                }
            }
            ACC.Consulta("select dirip, based, usuario, clave from conex where tipocon = 2");
            if (ACC.Siguiente())
            {
                try
                {
                    CSQ = new ConSQLServer(ACC.Campo(0), ACC.Campo(1), ACC.Campo(2), ACC.Campo(3));
                }
                catch (Exception E)
                {
                    MessageBox.Show("No se pudo establecer la conexión Secundaria\n" + E.Message);
                    Application.Exit();
                }
            }
        }
    }
}
