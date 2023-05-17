using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;

namespace Compilador_C
{
    class Conexion
    {
        public static DataTable Query(string query)
        {
            string BaseDatos = "Compilador";
            string Servidor = "localhost\\SQLEXPRESS01";
            string CadenaConexion = "Server=" + Servidor + ";Database=" + BaseDatos + ";Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            conexion.Open();
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable Resultados = new DataTable();
            Resultados.Load(reader);

            conexion.Close();
            return Resultados;
        }

        public static DataTable Query(string query,DateTime fecha1,DateTime fecha2)
        {
            string BaseDatos = "Compilador";
            string Servidor = "localhost\\SQLEXPRESS01";
            string CadenaConexion = "Server=" + Servidor + ";Database=" + BaseDatos + ";Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            conexion.Open();
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@fecha1", fecha1);
            cmd.Parameters.AddWithValue("@fecha2",fecha2);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable Resultados = new DataTable();
            Resultados.Load(reader);

            conexion.Close();
            return Resultados;
        }

        public static string encriptar(string Cadena)
        {
            SHA1CryptoServiceProvider SHA1 = new SHA1CryptoServiceProvider();
            byte[] vectoBytes = System.Text.Encoding.UTF8.GetBytes(Cadena);
            byte[] inArray = SHA1.ComputeHash(vectoBytes);
            SHA1.Clear();
            return Convert.ToBase64String(inArray);
        }
    }
}
