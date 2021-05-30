using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Data.SqlClient;

namespace ConexionDB2
{
    public partial class frmLogin : MaterialForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public void Verificacion()
        {
            try
            {
                SqlConnection Conexion = new SqlConnection("server=localhost\\SQLEXPRESS;database=ConexionDB2;Integrated Security=true");
                Conexion.Open();
                MessageBox.Show("Conexion exitosa");
                Conexion.Close();
            }
            catch
            {
                MessageBox.Show("Conexion erronea");
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Verificacion();
        }
    }
}
