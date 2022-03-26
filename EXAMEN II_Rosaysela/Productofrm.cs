using ConectarDatos.Motor;
using ConectarDatos.Entidades;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EXAMEN_II_Rosaysela
{
    public partial class Productofrm : Form
    {
        public Productofrm()
        {
            InitializeComponent();

        }
       
        string operacion = string.Empty;

        ProductoDA productoDA = new ProductoDA();


        private void NuevoButton_Click(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            HabilitarControles();
        }

        private void HabilitarControles()
        {
           CodigotextBox1.Enabled = true;
           DescripciontextBox2.Enabled = true;
             PreciotextBox3.Enabled = true;
           ExistenciatextBox4.Enabled = true;
            Guardarbutton3.Enabled = true;
           Cancelarbutton5.Enabled = true;
            Nuevobutton1.Enabled = false;
           Modificarbutton2.Enabled = false;

        }
        private void DesabilitarControles()
        {
            CodigotextBox1.Enabled = false;
            DescripciontextBox2.Enabled = false;
            PreciotextBox3.Enabled = false;
            ExistenciatextBox4.Enabled = false;
            Guardarbutton3.Enabled = false;
            Cancelarbutton5.Enabled = false;
            Nuevobutton1.Enabled = true;
            Modificarbutton2.Enabled = true;

        }
        private void LimpiarControles()
        {
           CodigotextBox1.Clear();
            DescripciontextBox2.Clear();
            PreciotextBox3.Clear();
          ExistenciatextBox4.Clear();
            
        }

        private void Nuevobutton1_Click(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            HabilitarControles();
        }

        private void Producto_Load(object sender, EventArgs e)
        {


            listarproductos();

        }

        private void listarproductos()
        {
            dataGridView1.DataSource = productoDA.ListarProductos();
        }

        private void Guardarbutton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(CodigotextBox1.Text))
                {
                    errorProvider1.SetError(CodigotextBox1, "Ingrese el código");
                    CodigotextBox1.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(DescripciontextBox2.Text))
                {
                    errorProvider1.SetError(DescripciontextBox2, "Ingrese una descripción");
                    DescripciontextBox2.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(PreciotextBox3.Text))
                {
                    errorProvider1.SetError(PreciotextBox3, "Ingrese un precio");
                    PreciotextBox3.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(ExistenciatextBox4.Text))
                {
                    errorProvider1.SetError(ExistenciatextBox4, "Ingrese una existencia");
                    ExistenciatextBox4.Focus();
                    return;
                }

                Producto producto = new Producto();
                producto.Codigo = CodigotextBox1.Text;
                producto.Descripcion = DescripciontextBox2.Text;
                producto.Precio = Convert.ToDecimal(PreciotextBox3.Text);
                producto.Existencia = Convert.ToInt32(ExistenciatextBox4.Text);


                bool inserto = productoDA.InsertarProducto(producto);
                if (operacion == "Nuevo")
                {
                   

                    if (inserto)
                    {
                        DesabilitarControles();
                        LimpiarControles();
                        listarproductos();
                        MessageBox.Show("Producto insertado");
                    }
                }

                if (operacion == "Modificar")
                {
                    bool modifico = productoDA.ModificarProducto(producto);
                    if (modifico)
                    {
                        LimpiarControles();
                        DesabilitarControles();
                        listarproductos();
                        MessageBox.Show("Producto Modificado");
                    }
                }
            }
            catch (Exception)
            {
            }

        }

        private void Modificarbutton2_Click(object sender, EventArgs e)
        {
            operacion = "Modificar";

            if (dataGridView1.SelectedRows.Count > 0)
            {
                CodigotextBox1.Text = dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
               DescripciontextBox2.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
              PreciotextBox3.Text =dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                ExistenciatextBox4.Text = dataGridView1.CurrentRow.Cells["Existencia"].Value.ToString();

              

              
                HabilitarControles();
               CodigotextBox1.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto");
            }

        }

        private void Eliminarbutton4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                bool elimino = productoDA.EliminarProducto(dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString());

                if (elimino)
                {
                    listarproductos();
                    MessageBox.Show("Producto Eliminado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Producto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Producto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Cancelarbutton5_Click(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
        }

        private void PreciotextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(PreciotextBox3, "Ingrese un caracter numerico");
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ExistenciatextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}







