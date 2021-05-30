using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConexionDB2
{
    class clsLogin
    {
        public string NomUser { get; set; }
        public string Pass { get; set; }

        public clsLogin()
        {

        }

        public clsLogin(string NomUser, string Pass)
        {
            this.NomUser = NomUser;
            this.Pass = Pass;
        }

        public bool VerificarLogin()
        {
            SqlConnection Conexion = new SqlConnection("server=localhost\\SQLEXPRESS;database=ConexionDB2;Integrated Security=true");
            Conexion.Open();

            string UserPass = "select NomUser, Pass from Login1 where NomUser = @NomUser and Pass = @Pass";

            SqlCommand sql = new SqlCommand(UserPass, Conexion);
            sql.Parameters.AddWithValue("NomUser", this.NomUser);
            sql.Parameters.AddWithValue("Pass", this.Pass);

            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);

            Conexion.Close();

            if (dataTable.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
