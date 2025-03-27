using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VetManager_0._1.Clases
{
    internal class CConexion
    {
        MySqlConnection conex = new MySqlConnection();

        // creamos las variables para la coneccion
        static string servidor = "localhost";
        static string bd = "proyectoIntermodular";
        static string usuario = "root";
        static string password = "12345678";
        static string puerto = "3306";
       

        string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        public MySqlConnection establecerConexion() {

            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
               // MessageBox.Show("se conecto a la base de datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO se realizo al a conexion, error:" + ex.ToString());
            }
        
        return conex;
        }
        public void cerrarConexion()
        {
            conex.Close();
        }
    }

}
