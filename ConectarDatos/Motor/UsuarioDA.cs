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
    public class UsuarioDA
    {
        //Conexion al Servidor
        readonly string cadena = "server=localhost; port=3306; Database=programacion; Uid=root; pwd=Alexisviera2612; ";
        MySqlConnection conn;
        MySqlCommand comd;

        public usuario login(string codigo, string clave)
        {
            //Objeto
            usuario dato = null; //null por si ingresa valores incorrectos

            //capturar errores para que no se cierre 
            //Codigo para consultar la tabla 
            try//donde programamos
            {

                string sql = "SELECT * FROM usuario WHERE codigo=@Codigo AND clave=@Clave;";

                conn = new MySqlConnection(cadena);
                //abrimos la conexion a la base de datos
                conn.Open();

                comd = new MySqlCommand(sql, conn);
                //parametros
                comd.Parameters.AddWithValue("@Codigo", codigo);
                comd.Parameters.AddWithValue("@Clave", clave);
                //capturar datos
                MySqlDataReader reader = comd.ExecuteReader();
                //leemos el objeto reader con while 

                while (reader.Read())// osea mientras el objeto lea valores
                {
                    dato = new usuario();//objeto dato es el que retorna 
                    dato.Codigo = reader[0].ToString();  //el primer valor sera 0 ya que en la tabla esta en la posicion 0 el codigo, las tablas se inicia de 0 a contar  ya que estamos en arreglos 
                    dato.Nombre = reader[1].ToString();
                    dato.Clave = reader[2].ToString();
                    dato.Rol = reader[3].ToString();
                    dato.EstaActivo = Convert.ToBoolean(reader[4]);
                }
                //cerramos reader
                reader.Close();
                //cerramos la conexion 
                conn.Close();


            }
            catch (Exception ex)//captura todos los Errores
            {

            }
            //retornar
            return dato;

        }


        public DataTable ListarUsuario()
        {
            DataTable ListaUsuarios = new DataTable();
            try
            {
                //atrae todos los usuarios en la tabla 

                string sql = "SELECT * FROM usuario; ";
                //instanciar el objeto conexion 
                conn = new MySqlConnection(cadena);
                conn.Open();
                comd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = comd.ExecuteReader();
                //Captura todos los datos 
                ListaUsuarios.Load(reader);
                reader.Close();
                conn.Close();
            }

            catch (Exception ex)//CAPTURA ERRORES
            {

            }
            return ListaUsuarios;
        }

        public bool InsertarUsuario(usuario usuario)
        {
            bool inserto = false;
            try
            {
                string sql = "INSERT INTO usuario VALUES (@Codigo, @Nombre, @Rol, @Clave, @EstaActivo);";
                conn = new MySqlConnection(cadena);
                conn.Open();

                comd = new MySqlCommand(sql, conn);

                comd.Parameters.AddWithValue("@Codigo", usuario.Codigo);
                comd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                comd.Parameters.AddWithValue("@Rol", usuario.Rol);
                comd.Parameters.AddWithValue("@Clave", usuario.Clave);
                comd.Parameters.AddWithValue("@EstaActivo", usuario.EstaActivo);

                comd.ExecuteNonQuery();
                inserto = true;

                conn.Close();
            }
            catch (Exception)
            {
            }
            return inserto;
        }


        public bool ModificarUsuario(usuario usuario)
        {
            //variable local 
            bool modifico = false;
            try
            {
                //Sirve para insertar datos a la tabla

                string sql = "UPDATE usuario SET Codigo = @Codigo, Nombre = @Nombre,Clave = @Clave,Rol= @Rol,EstaActivo= @EstaActivo WHERE Codigo =@Codigo;";
                //abrir la conexion de la base 
                conn = new MySqlConnection(cadena);
                conn.Open();

                comd = new MySqlCommand(sql, conn);
                //pasamos los parametros 
                comd.Parameters.AddWithValue("@Codigo", usuario.Codigo);
                comd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                comd.Parameters.AddWithValue("@Clave", usuario.Clave);
                comd.Parameters.AddWithValue("@Rol", usuario.Rol);
                comd.Parameters.AddWithValue("@EstaActivo", usuario.EstaActivo);
                //ahora vamos A ejecutar ,ExecuteNonQuery(); ejecuta y trae datos
                comd.ExecuteNonQuery();
                modifico = true;


                conn.Close();

            }
            catch (Exception ex)
            {

            }
            return modifico;

        }

        public bool EliminarUsuario(string codigo)
        {
            bool elimino = false;
            try
            {
                //Sirve para insertar para Eliminar datos de la tabla
                //DELETE FROM SIRVE PARA ELIMINAR UN REGISTRO

                string sql = "DELETE FROM usuario  WHERE Codigo =@Codigo;";
                //abrir la conexion de la base 
                conn = new MySqlConnection(cadena);
                conn.Open();

                comd = new MySqlCommand(sql, conn);
                //pasamos los parametros 
                comd.Parameters.AddWithValue("@Codigo", codigo);

                //ahora vamos A ejecutar ,ExecuteNonQuery(); ejecuta y trae datos
                comd.ExecuteNonQuery();
                elimino = true;

                conn.Close();



            }
            catch (Exception ex)
            {

            }
            return elimino;



        }

    }
}
