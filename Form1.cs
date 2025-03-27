using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetManager_0._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Clases.Ccclientes objetoUsuarios = new Clases.Ccclientes();
            objetoUsuarios.MostrarClientes(dgvTotalClientes);
            // Establece el título del formulario
            this.Text = "VetManager - Gestión Veterinaria";

        }
        private void LimpiarControles()
        {
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDomicilio.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
           // Clases.CConexion objetoConexion = new Clases.CConexion();
            //objetoConexion.establecerConexion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clases.Ccclientes objetoUsuarios = new Clases.Ccclientes();
            objetoUsuarios.GuardarClientes(txtId,txtNombre,txtApellido,txtDomicilio,txtTelefono);
            objetoUsuarios.MostrarClientes(dgvTotalClientes);
            LimpiarControles();
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvTotalClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.Ccclientes objetoUsuarios = new Clases.Ccclientes();
            objetoUsuarios.SeleccionarClientes(dgvTotalClientes,txtId,txtNombre,txtApellido,txtDomicilio,txtTelefono);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clases.Ccclientes objetoUsuarios = new Clases.Ccclientes();
            objetoUsuarios.ModificarClientes(txtId, txtNombre, txtApellido, txtDomicilio, txtTelefono);
            objetoUsuarios.MostrarClientes(dgvTotalClientes);
            LimpiarControles();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Clases.Ccclientes objetoUsuarios = new Clases.Ccclientes();
            objetoUsuarios.EliminarClientes(txtId);
            objetoUsuarios.MostrarClientes(dgvTotalClientes);
            LimpiarControles();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvTotalClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
