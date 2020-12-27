using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Creditos
{
    public class ConMySQL
    {
        private MySqlConnection CON;
        private MySqlDataAdapter DA;
        private DataSet DS;
        private MySqlDataReader DR;
        
        public ConMySQL(String Server, String DataBase, String User, String Pwd)
        {
            MySqlConnectionStringBuilder Str = new MySqlConnectionStringBuilder();
            Str.Server = Server;
            Str.Database = DataBase;
            Str.UserID = User;
            Str.Password = Pwd;
            CON = new MySqlConnection(Str.ToString());
            CON.Open();
        }

        public void Cerrar()
        {
            CON.Close();
        }

        public void Consulta(String SQLQuery)
        {
                MySqlCommand Query = CON.CreateCommand();
                Query.CommandText = SQLQuery;
                DR = Query.ExecuteReader();
        }

        public DataTable ConsultaTabla(String SQLQuery)
        {
            MySqlCommand Query = CON.CreateCommand();
            Query.CommandText = SQLQuery;
            DR = Query.ExecuteReader();
            DataTable Tabla = new DataTable();
            Tabla.Load(DR);
            return Tabla;
        }

        public Boolean HayRegistros()
        {
            return DR.HasRows;
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
            if (DR.IsClosed)
            {
                DA = new MySqlDataAdapter
                {
                    UpdateCommand = new MySqlCommand(SQLQuery, CON)
                };
                DA.UpdateCommand.ExecuteNonQuery();
            }
            else
            {
                DR.Close();
                DA = new MySqlDataAdapter
                {
                    UpdateCommand = new MySqlCommand(SQLQuery, CON)
                };
                DA.UpdateCommand.ExecuteNonQuery();
            }
        }

        public MySqlConnection getCON()
        {
            return CON;
        }
    }
}
