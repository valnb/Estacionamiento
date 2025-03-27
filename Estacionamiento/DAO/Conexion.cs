using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.DAO
{
    internal class Conexion
    {
        MySqlConnection con;

        public Conexion()
        {
        }

        public MySqlConnection establecerConexion()
        {
            string cs = "Server=localhost;User ID=root;Password=fatima13;Persist Security Info=true;Database=Usuarios";
            con = new MySqlConnection(cs);
            return con;
        }

        public MySqlConnection establecerConexion(string conexionString)
        {
            string cs = conexionString;
            con = new MySqlConnection(cs);
            return con;
        }
        public void abrirConexion()
        {
            con.Open();
        }
        public void cerrarConexion()
        {
            con.Close();
        }

    }
}
