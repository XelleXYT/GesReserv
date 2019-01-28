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

        private void iniciaConexion()
        {
            conexion = new MySqlConnection("Server = 127.0.0.1; Database = gesreserv; Uid = root; Pwd = root; Port = 3306");
            conexion.Open();
        }

        private void cierraConexion()
        {
            conexion.Close();
        }

        public DataTable cargaDatos(String consulta)
        {
            iniciaConexion();
            DataTable datos = new DataTable();

            comando = new MySqlCommand(consulta, conexion);

            resultado = comando.ExecuteReader();

            datos.Load(resultado);

            cierraConexion();

            return datos;
        }

        public void insertaDatosReserva(DateTime f_entrada, DateTime f_salida, String cliente, String n_hab)
        {
            iniciaConexion();
            String f_in = f_entrada.Year + "-" + f_entrada.Month + "-" + f_entrada.Day;
            String f_out = f_salida.Year + "-" + f_salida.Month + "-" + f_salida.Day;
            comando = conexion.CreateCommand();
            comando.CommandText = "INSERT INTO gesreserv.reservas(fecha_entrada,fecha_salida,cliente,n_habitacion) VALUES('" + f_in + "','" + f_out + "','" + cliente + "','" + n_hab + "');";
            comando.ExecuteNonQuery();
            cierraConexion();
        }

        public void insertaDatosCliente(String dni, String nombre, String telefono)
        {
            iniciaConexion();
            comando = conexion.CreateCommand();
            comando.CommandText = "INSERT INTO gesreserv.clientes(dni,nombre,telefono) VALUES('" + dni + "','" + nombre + "'," + telefono + ");";
            comando.ExecuteNonQuery();
            cierraConexion();
        }

        public void ejecutaQuerry(String querry)
        {
            iniciaConexion();
            comando = conexion.CreateCommand();
            comando.CommandText = querry;
            comando.ExecuteNonQuery();
            cierraConexion();
        }


    }
}
