using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;//agregar
using ConectarDatos.Entidades;//agregar segun el nombre de la carpeta
using System.Data;


namespace ConectarDatos.Motor
{
   public class pedidosDA
    {
        //Conexion al Servidor
        readonly string cadena = "server=localhost; port=3306;Database=Programacion;Uid=root;pwd=Alexisviera2612; ";
        MySqlConnection conn;
        MySqlCommand comd;

        public DataTable ListarProductos()
        {
            DataTable lista = new DataTable();

            try
            {
                string sql = "SELECT * FROM pedidos;";
                conn = new MySqlConnection(cadena);
                conn.Open();

                comd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = comd.ExecuteReader();
                lista.Load(reader);
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return lista;
        }

        public bool InsertarProducto(pedido pedido)
        {
            bool inserto = false;
            try
            {
                string sql = "INSERT INTO pedidos VALUES (@Descripcion, @Precio, @Cantidad,@NombreCliente, @Direccioncliente,@Telefonocliente);";

                conn = new MySqlConnection(cadena);
                conn.Open();

                comd = new MySqlCommand(sql, conn);

                comd.Parameters.AddWithValue("@Descripcion", pedido.Descripcion);
                comd.Parameters.AddWithValue("@Precio", pedido.Precio);
                comd.Parameters.AddWithValue("@Cantidad", pedido.Cantidad);
                comd.Parameters.AddWithValue("@NombreCliente", pedido.Nombrecliente);
                comd.Parameters.AddWithValue("@Direccioncliente", pedido.Direccioncliente);
                comd.Parameters.AddWithValue("@Telefonocliente", pedido.Telefonocliente);

                comd.ExecuteNonQuery();
                inserto = true;

                conn.Close();
            }
            catch (Exception)
            {
            }
            return inserto;
        }

        public bool ModificarProducto(pedido pedido)
        {
            bool modifico = false;
            try
            {
                string sql = "UPDATE pedidos SET Descripcion= @Descripcion, Precio = @Precio, " +
                             "Cantidad = @Cantidad,NombreCliente = @NombreCliente,Direccioncliente = @Direccioncliente,Telefonocliente =@Telefonocliente WHERE Descripcion= @Descripcion;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                comd = new MySqlCommand(sql, conn);

                comd.Parameters.AddWithValue("@Descripcion", pedido.Descripcion);
                comd.Parameters.AddWithValue("@Precio", pedido.Precio);
                comd.Parameters.AddWithValue("@Cantidad", pedido.Cantidad);
                comd.Parameters.AddWithValue("@NombreCliente", pedido.Nombrecliente);
                comd.Parameters.AddWithValue("@Direccioncliente", pedido.Direccioncliente);
                comd.Parameters.AddWithValue("@Telefonocliente", pedido.Telefonocliente);


                comd.ExecuteNonQuery();
                modifico = true;
                conn.Close();
            }
            catch (Exception)
            {
            }
            return modifico;
        }

        public bool EliminarProducto(string Descripcion)
        {
            bool elimino = false;
            try
            {
                string sql = "DELETE FROM pedidos WHERE Descripcion = @Descripcion;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                comd = new MySqlCommand(sql, conn);

                comd.Parameters.AddWithValue("@Descripcion", Descripcion);

                comd.ExecuteNonQuery();
                elimino = true;
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return elimino;
        }

        public pedido GetProductoPorCodigo(string Descripcion)
        {
            pedido pedido = new pedido();
            try
            {
                string sql = "Select * from pedido WHERE Descripcion = @Descripcion;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                comd = new MySqlCommand(sql, conn);

                comd.Parameters.AddWithValue("@Descripcion", Descripcion);
                MySqlDataReader reader = comd.ExecuteReader();
                if (reader.Read())
                {
                    pedido.Descripcion = reader["Descripcion"].ToString();
                    pedido.Precio = Convert.ToDecimal(reader["Precio"]);
                    pedido.Cantidad= reader["Cantidad"].ToString();
                    pedido.Nombrecliente = reader["Nombrecliente"].ToString();
                    pedido.Direccioncliente = reader["Direccioncliente"].ToString();
                    pedido.Telefonocliente = reader["Telefonocliente"].ToString();
                   
                }

                conn.Close();
            }
            catch (Exception)
            {
            }
            return pedido;
        }

    }
}

