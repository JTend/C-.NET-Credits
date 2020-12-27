using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Creditos
{
    public class ConAccess
    {
        private OleDbConnection CON;
        private OleDbDataAdapter DA;
        private DataSet DS;
        private DataTableReader DR;

        public ConAccess()
        {
            CON = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
                + Application.StartupPath 
                +"\\Admin.accdb;Persist Security Info=True;Jet OLEDB:Database Password=scicocy01012010");
            try
            {
                CON.Open();

            }
            catch(Exception E)
            {
                MessageBox.Show("Error leyendo la configuración.\n" + E.Message);
                Application.Exit();
            }
        }
        public DataTable Consulta(String SQLQuery)
        {
            DA = new OleDbDataAdapter(SQLQuery, CON);
            DS = new DataSet("Resultado");
            DA.Fill(DS);
            DR = DS.Tables[0].CreateDataReader();
            return DS.Tables[0];
        }
        public Boolean HayRegistros()
        {
            return DR.HasRows;
        }        
        public int Registros()
        {
            return DS.Tables[0].Rows.Count;
        }
        public Boolean Siguiente()
        {
            return DR.Read();
        }
        public String Campo(int ID)
        {
            return DR.GetValue(ID).ToString();
        }
        public void Sentencia(String SQLQuery)
        {
            try
            {
                OleDbCommand COM = new OleDbCommand(SQLQuery, CON);
                COM.ExecuteNonQuery();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message + "\n" + SQLQuery);
                Application.Exit();
            }
        }
    }
}
