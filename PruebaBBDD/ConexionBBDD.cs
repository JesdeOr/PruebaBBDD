using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace PruebaBBDD
{
    internal class ConexionBBDD
    {
        SqlConnection conection;
        SqlCommand command;
        SqlDataReader dataReader;

        public ConexionBBDD()
        {
            try
            {
                conection = new SqlConnection("Data Source=DESKTOP-TNU8JNK\\DAM1SQLSERVER;Initial Catalog=Prueba;Integrated Security=True");
                conection.Open();
                MessageBox.Show("Conexión a la BBDD realizada.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Conexión a la BBDD fallida: " + e.Message);
            }
        }
        public string Insertar(int id, string nombre, string apellidos)
        {
            String salida = "Se insertó nuevo usuario.";
            try
            {
                command = new SqlCommand("INSERT INTO TUsuario (nUsuarioID, cUsuarioNombre, cUsuarioApellidos) VALUES (" + id + ", '" + nombre + "', '" + apellidos + "')", conection);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                salida = "No se pudo ingresar el usuario: \n" + e.Message;
            }
            return salida;
        }
    }
}
