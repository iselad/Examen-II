using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConectarDatos.Entidades
{
    public class pedido
    {
     public string Descripcion { get; set; }
    public string Cantidad{ get; set; }
    public decimal Precio { get; set; }
    public string Nombrecliente{ get; set; }

    public string Direccioncliente { get; set; }
    public string Telefonocliente { get; set; }
 

    public pedido()
    {
    }

    public pedido(string descripcion, string cantidad, decimal precio, string nombrecliente,string direccioncliente,string telefonoCliente)
    {
       Descripcion = descripcion;
        Precio = precio;
      Cantidad = cantidad;
      Nombrecliente = nombrecliente;    
      Direccioncliente = direccioncliente;    
     Telefonocliente = telefonoCliente;
    }
}
}

