using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
     public class ModeloDatos
    {
        public static DataTable CargarDireccionesDocentes()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM direccion ";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query),ModelConexion.Conectar());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }


        public static DataTable CargarEspecialidad()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM especialidad ";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModelConexion.Conectar());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }

        public static DataTable CargarGenero()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM genero ";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModelConexion.Conectar());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }

        public static DataTable CargarEstado()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM estado ";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModelConexion.Conectar());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }


    }



}


