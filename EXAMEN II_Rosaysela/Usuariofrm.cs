using ConectarDatos.Motor;
using ConectarDatos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace EXAMEN_II_Rosaysela
{
    public partial class Usuariofrm : Form
    {
        public Usuariofrm()
        {
            InitializeComponent();
        }
        //objeto
        UsuarioDA UsuarioDA = new UsuarioDA();
        //esta variable sirve para los botones Nuevo y Modificar 
        //para iniciar una varible vacia utilizamos Empty,
        //o tambien lo puedo inicializar " "(string operacion = " ";) 
        string operacion = " ";
        //objeto para el boton guardar 
        usuario dato = new usuario();
      
        private void Usuario_Load(object sender, EventArgs e)
        {
            //ledamos clic en el formulario para abrir
            //al cargar el usuario va mostrar los usuarios
            ListarUsuarios();
        }
        private void ListarUsuarios()
        {
            DataGridView1.DataSource = UsuarioDA.ListarUsuario();

        }

        private void Nuevobutton1_Click(object sender, EventArgs e)
        {
            //llamar procedimiento 
            habilitarcontroles();
            //llamamos la variable operacion que definimos al inicio
            operacion = " Nuevo";
        }
        private void habilitarcontroles()
        {
            //le ponemos true porque lo tenemos en false Enabled
            CodigotextBox1.Enabled = true;
            NombretextBox2.Enabled = true;
            ClavetextBox4.Enabled = true;
            RolcomboBox1.Enabled = true;
            EstadoActivocheckBox1.Enabled = true;

            Nuevobutton1.Enabled = false;
            //habilitar botones  al darle clic al nuevo
            Guardarbutton3.Enabled = true;
            Cancelarbutton5.Enabled = true;

        }
        //Desabilitar botones 
        private void Desabilitar()
        {
            //le ponemos true porque lo tenemos en false Enabled
            CodigotextBox1.Enabled = false;
            NombretextBox2.Enabled = false;
            ClavetextBox4.Enabled = false;
            RolcomboBox1.Enabled = false;
            EstadoActivocheckBox1.Enabled = false;

            Nuevobutton1.Enabled = true;
            //habilitar botones  al darle clic al nuevo
            Guardarbutton3.Enabled = false;
            Cancelarbutton5.Enabled = false;

        }
        //limpiar los botones 
        private void limpiarcontroles()
        {
            //le ponemos true porque lo tenemos en false Enabled
            CodigotextBox1.Clear();//limpiar cadena 
            NombretextBox2.Text = " ";//limpiar cadena
            ClavetextBox4.Text = String.Empty;//limpiar una cadena
            RolcomboBox1.Text = String.Empty;//limpiar una cadena
            EstadoActivocheckBox1.Enabled = false;
        }

        private void Guardarbutton3_Click(object sender, EventArgs e)
         {

            dato.Codigo = CodigotextBox1.Text;
            dato.Nombre = NombretextBox2.Text;
            dato.Clave =ClavetextBox4.Text;
            dato.Rol = RolcomboBox1.Text;
            dato.EstaActivo = EstadoActivocheckBox1.Checked;
          
          
                bool inserto = UsuarioDA.InsertarUsuario(dato);
            if (operacion == " Nuevo") 
            {
                if (inserto)
                {
                    MessageBox.Show("Usuario Creado");
                    ListarUsuarios();
                    limpiarcontroles();
                    Desabilitar();
                }
                else
                {
                    MessageBox.Show("Usuario no se pudo Crear");
                }

            }

             if (operacion == "Modificar")
            {
                bool modifico = UsuarioDA.ModificarUsuario(dato);
                if (modifico)
                {
                    MessageBox.Show("Usuario Modificado");
                    ListarUsuarios();
                    limpiarcontroles();
                    Desabilitar();
                }
                else
                {
                    MessageBox.Show("Usuario no se pudo Modificar");
                }
            }
           


        }
        private void Modificarbutton2_Click(object sender, EventArgs e)
        {

            //propiedad que permite si tenemos seleccionado algun registro 
            //DataGridView.SelectedRows.count
            operacion = "Modificar";

            if (DataGridView1.SelectedRows.Count >= 1)
            {


                //pasar los datos
                //CurrentRow.Cells significa celda actual
                CodigotextBox1.Text = DataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
                NombretextBox2.Text = DataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                ClavetextBox4.Text = DataGridView1.CurrentRow.Cells["Clave"].Value.ToString();
                RolcomboBox1.Text = DataGridView1.CurrentRow.Cells["Rol"].Value.ToString();
                EstadoActivocheckBox1.Checked = Convert.ToBoolean(DataGridView1.CurrentRow.Cells["EstaActivo"].Value);
                //Habilitamos los controles
                habilitarcontroles();
            }

        }

        private void Eliminarbutton4_Click(object sender, EventArgs e)
        {


            if (DataGridView1.SelectedRows.Count >= 1)
            {

                bool elimino = UsuarioDA.EliminarUsuario(DataGridView1.CurrentRow.Cells["Codigo"].Value.ToString());
                if (elimino)
                {
                    //mandar mensaje 

                    MessageBox.Show(" Usuario Eliminado");
                    ListarUsuarios();// llamo al procedimiento listarUsuario para que refresque la base

                }
                else
                {
                    MessageBox.Show(" Usuario No se pudo Eliminar");
                }

            }
        }

        private void Cancelarbutton5_Click(object sender, EventArgs e)
        {
            Desabilitar();
            limpiarcontroles();
        }
    }
}
