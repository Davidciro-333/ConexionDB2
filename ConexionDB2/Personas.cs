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
    public partial class frmPersonas : MaterialForm
    {
        public frmPersonas()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                clsPersonas clsPersonas = new clsPersonas(Convert.ToInt32(txtbID.Text), txtbNombre.Text, txtbApellido.Text, txtbCorreo.Text, txtbDireccion.Text);

                clsPersonas.Crear();

                MessageBox.Show("Datos creados con éxtio");

                dtgPersonas.DataSource = clsPersonas.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el dato" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                clsPersonas clsPersonas = new clsPersonas(Convert.ToInt32(txtbID.Text), txtbNombre.Text, txtbApellido.Text, txtbCorreo.Text, txtbDireccion.Text);

                clsPersonas.Actualizar();

                MessageBox.Show("Datos Actualizados con éxtio");

                dtgPersonas.DataSource = clsPersonas.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Actualizar el dato" + ex.Message);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbID.Text == "")
                {
                    clsPersonas clsPersonas = new clsPersonas();
                    dtgPersonas.DataSource = clsPersonas.Consultar();
                }
                else
                {
                    clsPersonas clsPersonas = new clsPersonas();
                    dtgPersonas.DataSource = clsPersonas.Seleccionar(Convert.ToInt32(txtbID.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar el dato" + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                clsPersonas clsPersonas = new clsPersonas();

                clsPersonas.Eliminar(Convert.ToInt32(txtbID.Text));

                MessageBox.Show("Datos Eliminados con éxtio");

                dtgPersonas.DataSource = clsPersonas.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el dato " + ex.Message);
            }
        }

        private void dtgPersonas_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                txtbID.Text = dtgPersonas.SelectedRows[0].Cells[0].Value.ToString();
                txtbNombre.Text = dtgPersonas.SelectedRows[0].Cells[1].Value.ToString();
                txtbApellido.Text = dtgPersonas.SelectedRows[0].Cells[2].Value.ToString();
                txtbCorreo.Text = dtgPersonas.SelectedRows[0].Cells[3].Value.ToString();
                txtbDireccion.Text = dtgPersonas.SelectedRows[0].Cells[4].Value.ToString();

            }
            catch
            {
                MessageBox.Show("Error, no haga clic aquí");
            }
        }

        private void frmPersonas_Load(object sender, EventArgs e)
        {
            btnConsultar_Click(sender, e);
        }
    }
}
