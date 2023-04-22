using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlado
{
    public class ControladorDatos
    {
        public static DataTable CargarDirecciones()
        {
            return ModeloDatos.CargarDireccionesDocentes();
        }

        public static DataTable CargarEspecialidad()
        {
            return ModeloDatos.CargarEspecialidad();
        }

        public static DataTable CargarGenero()
        {
            return ModeloDatos.CargarGenero();
        }

        public static DataTable CargarEstado()
        {
            return ModeloDatos.CargarEstado();
        }

    }
}
