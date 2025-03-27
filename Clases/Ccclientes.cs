using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace VetManager_0._1.Clases
{
    internal class Ccclientes
    {
        public void MostrarClientes(DataGridView dgvTotalClientes)
        {
            try
            {
                CConexion objetoConexion = new CConexion();


                String query = "select * from dueño";
                dgvTotalClientes.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvTotalClientes.DataSource = dt;
                objetoConexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la conexion, error:" + ex.ToString());
            }

        }

        public void GuardarClientes(TextBox Id, TextBox Nombre, TextBox Apellidos, TextBox Domicilio, TextBox Telefono)
        {
            try
            {
                CConexion objetoConexion = new CConexion();


                String query = "insert into dueño (idDueño,nombre,apellidos,domicilio,telefono)" + "values('" + Id.Text + "','" + Nombre.Text + "','" + Apellidos.Text + "','" + Domicilio.Text + "', '" + Telefono.Text + "');";

                MySqlCommand myComannd = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myComannd.ExecuteReader();
                MessageBox.Show("Se guardaron los registros correcgamente");
                while (reader.Read())
                {

                }
                objetoConexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la conexion, error:" + ex.ToString());
            }
        }

        public void SeleccionarClientes(DataGridView tablaClientes, TextBox Id, TextBox Nombre, TextBox Apellidos, TextBox Domicilio, TextBox Telefono)
        {
            try
            {
                Id.Text= tablaClientes.CurrentRow.Cells[0].Value.ToString();
                Nombre.Text = tablaClientes.CurrentRow.Cells[1].Value.ToString();
                Apellidos.Text = tablaClientes.CurrentRow.Cells[2].Value.ToString();
                Domicilio.Text = tablaClientes.CurrentRow.Cells[3].Value.ToString();
                Telefono.Text = tablaClientes.CurrentRow.Cells[4].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo seleccionar, error:" + ex.ToString());
            }
        }

        public void ModificarClientes(TextBox Id, TextBox Nombre, TextBox Apellidos, TextBox Domicilio, TextBox Telefono)
        {
            try
            {
                CConexion objetoConexion = new CConexion();


                String query = "update dueño set nombre='" + Nombre.Text + "',apellidos='" + Apellidos.Text + "',domicilio='" + Domicilio.Text + "',telefono='" + Telefono.Text + "' where idDueño ='" + Id.Text + "';";

                MySqlCommand myComannd = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myComannd.ExecuteReader();
                MessageBox.Show("Se actualizaron los registros correcgamente");
                while (reader.Read())
                {

                }
                objetoConexion.cerrarConexion();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar, error:" + ex.ToString());
            }
        }

        public void EliminarClientes(TextBox Id)
        {
            try
            {
                CConexion objetoConexion = new CConexion();


                String query = "delete from dueño where idDueño= '" + Id.Text + "';";

                MySqlCommand myComannd = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myComannd.ExecuteReader();
                MessageBox.Show("Se eliminarón los registros correcgamente");
                while (reader.Read())
                {

                }
                objetoConexion.cerrarConexion();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminarón los datos, error:" + ex.ToString());
            }
        }
    }
}
