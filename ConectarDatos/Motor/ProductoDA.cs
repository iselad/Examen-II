using ConectarDatos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectarDatos.Motor
{
public class ProductoDA
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=programacion; Uid=root; Pwd=Alexisviera2612;";

        MySqlConnection conn;
        MySqlCommand comd;

        public DataTable ListarProductos()
        {
            DataTable lista = new DataTable();

            try
            {
                string sql = "SELECT * FROM producto;";
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
        public bool InsertarProducto(Producto producto)
        {
            bool inserto = false;
            try
            {
                string sql = "INSERT INTO producto VALUES (@Codigo, @Descripcion, @Precio, @Existencia);";

                conn = new MySqlConnection(cadena);
                conn.Open();

                comd = new MySqlCommand(sql, conn);

                comd.Parameters.AddWithValue("@Codigo", producto.Codigo);
                comd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                comd.Parameters.AddWithValue("@Precio", producto.Precio);
                comd.Parameters.AddWithValue("@Existencia", producto.Existencia);
                comd.ExecuteNonQuery();
                inserto = true;

                conn.Close();
            }
            catch (Exception)
            {
            }
            return inserto;
        }

        public bool ModificarProducto(Producto producto)
        {
            bool modifico = false;
            try
            {
                string sql = "UPDATE producto SET Codigo = @Codigo, Descripcion = @Descripcion, " +
                             "Precio = @Precio, Existencia = @Existencia  WHERE Codigo = @Codigo;";
                conn = new MySqlConnection(cadena);
                conn.Open();

                comd = new MySqlCommand(sql, conn);

                comd.Parameters.AddWithValue("@Codigo", producto.Codigo);
                comd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                comd.Parameters.AddWithValue("@Precio", producto.Precio);
                comd.Parameters.AddWithValue("@Existencia", producto.Existencia);
                comd.ExecuteNonQuery();
                modifico = true;
                conn.Close();
            }
            catch (Exception)
            {
            }
            return modifico;
        }
        public bool EliminarProducto(string codigo)
        {
            bool elimino = false;
            try
            {
                string sql = "DELETE FROM producto WHERE Codigo = @Codigo;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                comd = new MySqlCommand(sql, conn);

                comd.Parameters.AddWithValue("@Codigo", codigo);

                comd.ExecuteNonQuery();
                elimino = true;
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return elimino;
        }
        

        public Producto GetProductoPorCodigo(string codigo)
        {
            Producto producto = new Producto();
            try
            {
                string sql = "Select * from producto WHERE Codigo = @Codigo;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                comd = new MySqlCommand(sql, conn);

                comd.Parameters.AddWithValue("@Codigo", codigo);
                MySqlDataReader reader = comd.ExecuteReader();
                if (reader.Read())
                {
                    producto.Codigo = reader["Codigo"].ToString();
                    producto.Descripcion = reader["Descripcion"].ToString();
                    producto.Precio = Convert.ToDecimal(reader["Precio"]);
                    producto.Existencia = Convert.ToInt32(reader["Existencia"].ToString());
                }

                conn.Close();
            }
            catch (Exception)
            {
            }
            return producto;
        }

    }
}