using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class ModelConexion
    {
        public static MySqlConnection Conectar()

        {

            MySqlConnection connect;
            try
            {
                string server, database, uid, pwd;
                server = "localhost";
                database = "sistema";
                uid = "root";
                pwd = "1234";
                connect = new MySqlConnection("server =" + server +
                                                "; database =" + database +
                                                "; uid = " + uid +
                                                "; pwd = " + pwd);
                connect.Open();
                return connect;

            }
            catch(Exception)
            {
                return connect = null;
            }
        }
    }
}
