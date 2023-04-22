using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlado;
using Controlador;
using MySql.Data.MySqlClient;

namespace Vista
{
    public partial class frmAgregarDocentes : Form
    {
        public frmAgregarDocentes()
        {
            InitializeComponent();
        }

        //metodos
        void LlenarDireccion()
        {

            cmbDireccion.DataSource = ControladorDatos.CargarDirecciones();
            cmbDireccion.DisplayMember = "direccion";
            cmbDireccion.ValueMember = "iddireccion";  
        }

        void LlenarEspecialidad()
        {

            cmbEspecialidad.DataSource = ControladorDatos.CargarEspecialidad();
            cmbEspecialidad.DisplayMember = "especialidad";
            cmbEspecialidad.ValueMember = "idespecialidad";
        }

        void LlenarGenero()
        {

            cmbGenero.DataSource = ControladorDatos.CargarGenero();
            cmbGenero.DisplayMember = "genero";
            cmbGenero.ValueMember = "idgenero";
        }
        void LeerDocentes()

        {
            ControladorDocentes objleerdocentes = new ControladorDocentes();
            dgvDocentes.DataSource = objleerdocentes.LeerDocentes();

        }

        void LlenarEstado()
        {

            cmbEstado.DataSource = ControladorDatos.CargarEstado();
            cmbEstado.DisplayMember = "estado";
            cmbEstado.ValueMember = "idestado";
        }


        void CargarListas()
        {
            LlenarDireccion();
            LlenarEspecialidad();
            LlenarGenero();
            LlenarEstado();
        }

        void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con = ControladorConexion.ConectarModelo();
            if(con != null)
            {
                MessageBox.Show("Conexion establecida con exito", "Conexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Conexion no pudo ser establecida,", " Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmAgregarDocentes_Load(object sender, EventArgs e)
        {
            CargarListas();
            LeerDocentes();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //Insercion

        void InsertarDatos()
        {
            ControladorDocentes objdocentes = new ControladorDocentes();
            objdocentes.codigo = txtCodigo.Text;
            objdocentes.nombres = txtNombres.Text;
            objdocentes.apellidos = txtApellidos.Text;
            objdocentes.telefono = txtTelefono.Text;
            objdocentes.fechanacimiento = dtNacimiento.Text;
            objdocentes.iddireccion = Convert.ToInt32(cmbDireccion.SelectedValue);
            objdocentes.idespecialidad = Convert.ToInt32(cmbEspecialidad.SelectedValue);
            objdocentes.idgenero = Convert.ToInt32(cmbGenero.SelectedValue);
            objdocentes.idestado = Convert.ToInt32(cmbEstado.SelectedValue);
            int respuesta = objdocentes.ingresarDatos();
            if (respuesta>=1)
            {

                LeerDocentes();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Empleado no pudo ser registrado", "error de insercion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }



        }
        private void bntagregar_Click(object sender, EventArgs e)
        {
            InsertarDatos();
        }

        private void dgvDocentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bntLimpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
