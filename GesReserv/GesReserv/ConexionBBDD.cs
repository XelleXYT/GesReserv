using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Odbc;
using MySql.Data.Types;
using MySql.Data.MySqlClient;

namespace GesReserv
{

    public class ConexionBBDD
    {
        private MySqlConnection conexion;
        private static MySqlCommand comando;
        private MySqlDataReader resultado;

        public void iniciaConexion()
        {
            conexion = new MySqlConnection("Server = 127.0.0.1; Database = gesreserv; Uid = root; Pwd = root; Port = 3306");
            conexion.Open();
        }

        public DataTable cargaDatos(String consulta)
        {
            DataTable datos = new DataTable();

            comando = new MySqlCommand(consulta, conexion);

            resultado = comando.ExecuteReader();

            datos.Load(resultado);

            return datos;
        }


    }
}
