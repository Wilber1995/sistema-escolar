using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Modelo;


namespace Controlador
{
    public class ControladorConexion
    {
        public static MySqlConnection ConectarModelo()

        {

            return ModelConexion.Conectar();
        }
    }
}
