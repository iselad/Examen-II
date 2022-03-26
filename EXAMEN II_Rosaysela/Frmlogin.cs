using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConectarDatos;
using ConectarDatos.Motor;//clase accesoMotor 
using ConectarDatos.Entidades;//clase Entidad
namespace EXAMEN_II_Rosaysela
{
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        public static Frmlogin Frm { get; internal set; }

        private void AceptarButton_Click(object sender, EventArgs e)
        {

            //crear objetos de la clase usuario 
            //UuarioDA es el que accede al motor de base de datos
            UsuarioDA usuarioBD = new UsuarioDA();

            usuario usuario = new usuario();
            usuario = usuarioBD.login(UsuariotextBox1.Text, ClavetextBox2.Text);



            if (usuario == null)
            {
                MessageBox.Show("Datos Erroneos");
                return;
            }
            else if (!usuario.EstaActivo)
            {
                MessageBox.Show("Usuario inactivo");
                return;
            }

            //Llamar formulario mostrar datos

        FrmMenu mostrarDatos = new FrmMenu();
            mostrarDatos.Show();
            this.Hide();


        }

    }
}

