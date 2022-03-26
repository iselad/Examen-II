using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectarDatos.Entidades
{
    public class usuario
    {

        //propiedades
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public string Rol { get; set; }

        public bool EstaActivo { get; set; }
        // Constructor vacio 
        public usuario() { }

        //constructor con parametros 
        public usuario(string codigo, string nombre, string clave, string rol, bool estaActivo)
        {
            Codigo = codigo;
            Nombre = nombre;
            Clave = clave;
            Rol = rol;
            EstaActivo = estaActivo;


        }
    }
}
