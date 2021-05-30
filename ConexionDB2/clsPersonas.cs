using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConexionDB2
{
    class clsPersonas
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }

        public clsPersonas()
        {

        }

        public clsPersonas(int Id, string Nombre, string Apellido, string Correo, string Direccion)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Correo = Correo;
            this.Direccion = Direccion;
        }

        public bool Crear()
        {
            SqlConnection Conexion = new SqlConnection("server=localhost\\SQLEXPRESS;database=ConexionDB2;Integrated Security=true");
            Conexion.Open();

            string crear = "insert into Personas values(@Id, @Nombre, @Apellido, @Correo, @Direccion)";
            SqlCommand sql = new SqlCommand(crear, Conexion);

            sql.Parameters.AddWithValue("@Id", this.Id);
            sql.Parameters.AddWithValue("@Nombre", this.Nombre);
            sql.Parameters.AddWithValue("@Apellido", this.Apellido);
            sql.Parameters.AddWithValue("@Correo", this.Correo);
            sql.Parameters.AddWithValue("@Direccion", this.Direccion);
            sql.ExecuteNonQuery();

            return true;
        }

        public DataTable Consultar()
        {
            SqlConnection Conexion = new SqlConnection("server=localhost\\SQLEXPRESS;database=ConexionDB2;Integrated Security=true");
            Conexion.Open();

            DataTable dataTable = new DataTable();
            string Consulta = "select Id, Nombre, Apellido, Correo, Direccion from Personas";
            SqlCommand sql = new SqlCommand(Consulta, Conexion);

            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            sqlData.Fill(dataTable);

            return dataTable;
        }

        public bool Actualizar()
        {
            SqlConnection Conexion = new SqlConnection("server=localhost\\SQLEXPRESS;database=ConexionDB2;Integrated Security=true");
            Conexion.Open();
            string Actualizar = "update Personas set Id = @Id, Nombre = @Nombre, Apellido = @Apellido, Correo = @Correo, Direccion = @Direccion";
            SqlCommand sql = new SqlCommand(Actualizar, Conexion);

            sql.Parameters.AddWithValue("@Id", this.Id);
            sql.Parameters.AddWithValue("@Nombre", this.Nombre);
            sql.Parameters.AddWithValue("@Apellido", this.Apellido);
            sql.Parameters.AddWithValue("@Correo", this.Correo);
            sql.Parameters.AddWithValue("@Direccion", this.Direccion);
            sql.ExecuteNonQuery();

            return true;
        }

        public bool Eliminar(int Id)
        {
            SqlConnection Conexion = new SqlConnection("server=localhost\\SQLEXPRESS;database=ConexionDB2;Integrated Security=true");
            Conexion.Open();

            this.Id = Id;
            string Eliminar = "delete Personas where Id = @Id";
            SqlCommand sql = new SqlCommand(Eliminar, Conexion);
            sql.Parameters.AddWithValue("@Id", this.Id);
            sql.ExecuteNonQuery();

            return true;
        }

        public DataTable Seleccionar(int Id)
        {
            SqlConnection Conexion = new SqlConnection("server=localhost\\SQLEXPRESS;database=ConexionDB2;Integrated Security=true");
            Conexion.Open();

            this.Id = Id;
            DataTable dataTable = new DataTable();
            string Seleccionar = "select Id, Nombre, Apellido, Correo, Direccion from Personas where Id = @Id";
            SqlCommand sql = new SqlCommand(Seleccionar, Conexion);

            sql.Parameters.AddWithValue("@Id", this.Id);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);

            sqlData.Fill(dataTable);

            return dataTable;
        }
    }
}
