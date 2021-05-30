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

            string UserPass = "select NomUser, Pass from Login1";

            SqlCommand sql = new SqlCommand(UserPass, Conexion);
            Conexion.Close();

            if (this.NomUser == sql.CommandText && this.Pass == sql.CommandText)
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
