using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloDocentes
    {
        public static int AgregarDatos(string pcodigo, string pnombres, string papellidos, string ptelefono,
            string pfechanacimiento, int piddireccion, int pidespecialidad, int pidgenero, int pidestado)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO docentes (codigo,nombres,apellidos,telefono,fechanacimiento,iddireccion, " +
                    "idespecialidad,idgenero,idestado) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",pcodigo,pnombres,papellidos,ptelefono,pfechanacimiento,
                    piddireccion,pidespecialidad,pidgenero,pidestado),ModelConexion.Conectar());
                retorno = Convert.ToInt32(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch(Exception)
            {
                return retorno = 0;
            }

        }


        
            public static DataTable CargarDocentes()
            {
                DataTable data;
                try
                {
                    string query = "SELECT * FROM docentes ";
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

