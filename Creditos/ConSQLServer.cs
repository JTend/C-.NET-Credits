using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Creditos
{
    public class ConSQLServer
    {
        private SqlConnection CON;
        private SqlDataAdapter DA;
        private DataSet DS;
        private DataTableReader DR;

        private String Servidor;
        private String BaseD;
        private String Usuario;
        private String Password;

        public ConSQLServer()
        {
            Servidor = "";
            BaseD = "";
            Usuario = "";
            Password = "";
        }

        public ConSQLServer(SqlConnection C)
        {
            CON = C;
            CON.Open();
        }

        public ConSQLServer(String Server, String DataBase, String User, String Pwd)
        {
            CON = new SqlConnection("server=" + Server + ";database=" + DataBase + ";Uid=" + User + ";Pwd=" + Pwd + ";");
            CON.Open();
        }

        public void Cerrar()
        {
            CON.Close();
        }

        public DataTable Consulta(String SQLQuery)
        {
            DA = new SqlDataAdapter(SQLQuery, CON);
            DS = new DataSet();
            DA.Fill(DS);
            DR = DS.Tables[0].CreateDataReader();
            return DS.Tables[0];
        }

        public Boolean HayRegistros()
        {
            return DR.HasRows;
        }

        public Boolean Siguiente()
        {
            return DR.Read();
        }

        public String Campo(int id)
        {
            return DR.GetValue(id).ToString();
        }

        public void Sentencia(String SQLQuery)
        {
            DA = new SqlDataAdapter();
            DA.UpdateCommand = new SqlCommand(SQLQuery, CON);
            DA.UpdateCommand.ExecuteNonQuery();
        }

        public SqlConnection getCON()
        {
            return CON;
        }
    }
}
