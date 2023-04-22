using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlado
{
    public class ControladorDocentes
    {
        //Constructor
        public ControladorDocentes()
        {

        }

        //Atributos

        public int iddocentes { get; set; }
        public string codigo { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string telefono { get; set; }
        public string fechanacimiento { get; set; }
        public int iddireccion { get; set; }
        public int idespecialidad { get; set; }
        public int idgenero { get; set; }
        public int idestado { get; set; }
       
       

        //Metodos
        public  int ingresarDatos()
        {
            return ModeloDocentes.AgregarDatos(codigo,nombres,apellidos,telefono,fechanacimiento,iddireccion,idespecialidad,idgenero,idestado);


        }
        public  DataTable LeerDocentes()
        {
            return ModeloDocentes.CargarDocentes();
        }


    }
}
