using Estacionamiento.BO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.DAO
{
    internal class UsuarioDAO
    {
        Conexion con = new Conexion();
        DataSet dsCelulares = null;
        string sql;
        MySqlCommand cmd;
        MySqlDataAdapter da;

        public UsuarioDAO() 
        {
        }

        public DataSet devuelveUsuario()
        {
            cmd = new MySqlCommand();
            dsEstacionamiento = new DataSet();
            da = new MySqlDataAdapter();
            cmd.Connection = con.establecerConexion();
            sql = "SELECT * FROM SisEstacionamiento ORDER BY idUsuario";
            cmd.CommandText = sql;
            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(dsEstacionamiento);
            return dsEstacionamiento;
        }

        public int CreaUsuario(object obj)
        {
            UsuarioBO data = (UsuarioBO)obj;
            cmd = new MySqlCommand();
            //nombre de mi solucion??
            dsEstacionamiento = new DataSet();
            da = new MySqlDataAdapter();
            cmd.Connection = con.establecerConexion();
            con.abrirConexion();
            sql = "INSERT INTO SisEstacionamiento VALUES('" + data.NomUsuario + "','" + data.IdUsuarios;
            cmd.CommandText = sql;
            int i = cmd.ExecuteNonQuery();
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }
    }
}
