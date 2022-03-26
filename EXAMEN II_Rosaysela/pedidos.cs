using ConectarDatos.Motor;
using ConectarDatos.Entidades;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EXAMEN_II_Rosaysela
{
    public partial class pedidos : Form
    {
        public pedidos()
        {
            InitializeComponent();
        }
        string operacion = string.Empty;

        pedidosDA pedidosDA = new pedidosDA();

        private void HabilitarControles()
        {
            DescripciontextBox1.Enabled = true;
            PreciotextBox3.Enabled = true;
            CantidadtextBox2.Enabled = true;
           ClientetextBox4.Enabled = true;
           DirecciontextBox5.Enabled = true;
            TelefonotextBox6.Enabled = true;
            Cancelarbutton2.Enabled = true;
           Nuevobutton4.Enabled = false;
            button1.Enabled = false;


        }
        private void DesabilitarControles()
        {
            DescripciontextBox1.Enabled = false;
            PreciotextBox3.Enabled = false;
            CantidadtextBox2.Enabled = false;
            ClientetextBox4.Enabled = false;
            DirecciontextBox5.Enabled = false;
            TelefonotextBox6.Enabled= false;    
            Cancelarbutton2.Enabled = false;
            Nuevobutton4.Enabled = true;
            button1.Enabled = true;
        }
        private void LimpiarControles()
        {
            DescripciontextBox1.Clear();
            PreciotextBox3.Clear();
            PreciotextBox3.Clear();
            CantidadtextBox2.Clear();
            ClientetextBox4.Clear();
            DirecciontextBox5.Clear();
            TelefonotextBox6.Clear();   


        }

        private void pedidos_Load(object sender, EventArgs e)
        {


            listarproductos();

        }

        private void listarproductos()
        {
            dataGridView1.DataSource =pedidosDA.ListarProductos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Nuevobutton4_Click(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            HabilitarControles();
        }

        private void Cancelarbutton2_Click(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operacion = "Modificar";

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DescripciontextBox1.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                PreciotextBox3.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                CantidadtextBox2.Text = dataGridView1.CurrentRow.Cells["Cantidad"].Value.ToString();
               ClientetextBox4.Text = dataGridView1.CurrentRow.Cells["Nombrecliente"].Value.ToString();
                DirecciontextBox5.Text = dataGridView1.CurrentRow.Cells["Direccioncliente"].Value.ToString();
                TelefonotextBox6.Text = dataGridView1.CurrentRow.Cells["Telefonocliente"].Value.ToString();


                HabilitarControles();
                DescripciontextBox1.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Pedido");
            }

        }

        private void Guardarbutton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(DescripciontextBox1.Text))
                {
                    errorProvider1.SetError(DescripciontextBox1, "Ingrese una Descripcion");
                    DescripciontextBox1.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(PreciotextBox3.Text))
                {
                    errorProvider1.SetError(PreciotextBox3, "Ingrese un precio");
                    PreciotextBox3.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(CantidadtextBox2.Text))
                {
                    errorProvider1.SetError(CantidadtextBox2, "Ingrese la cantidad");
                    CantidadtextBox2.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(ClientetextBox4.Text))
                {
                    errorProvider1.SetError(ClientetextBox4, "Ingrese el Nombre");
                    ClientetextBox4.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(DirecciontextBox5.Text))
                {
                    errorProvider1.SetError(DirecciontextBox5, "Ingrese Su Direccion");
                    DirecciontextBox5.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(TelefonotextBox6.Text))
                {
                    errorProvider1.SetError(TelefonotextBox6, "Ingrese Su Telefono");
                    TelefonotextBox6.Focus();
                    return;
                }

                pedido pedido = new pedido();
                pedido.Descripcion = DescripciontextBox1.Text;
                pedido.Precio = Convert.ToDecimal(PreciotextBox3.Text);
                pedido.Cantidad = CantidadtextBox2.Text;
                pedido.Nombrecliente = ClientetextBox4.Text;
                pedido.Direccioncliente= DirecciontextBox5.Text;    
                pedido.Telefonocliente= TelefonotextBox6.Text;

                bool inserto = pedidosDA.InsertarProducto(pedido);
                if (operacion == "Nuevo")
                {


                    if (inserto)
                    {
                        DesabilitarControles();
                        LimpiarControles();
                        listarproductos();
                        MessageBox.Show("Pedido Creado");
                    }
                }
              
                else if (operacion == "Modificar")
                {
                    bool modifico = pedidosDA.ModificarProducto(pedido);
                    if (modifico)
                    {
                        LimpiarControles();
                        DesabilitarControles();
                        listarproductos();
                        MessageBox.Show("Pedido Modificado");
                    }
                }
            }
            catch (Exception)
            {
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                bool elimino = pedidosDA.EliminarProducto(dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString());

                if (elimino)
                {
                    listarproductos();
                    MessageBox.Show("Pedido Eliminado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Pedido", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un pedido", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ealizarpedidobutton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su pedido fue realizado");

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

        private void CantidadtextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(CantidadtextBox2, "Ingrese un caracter numerico");
            }
        }
    }
}
    
  

