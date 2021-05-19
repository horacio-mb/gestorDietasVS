using DATOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace proyectoCliente
{
    /// <summary>
    /// Descripción breve de wsCliente
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsCliente : System.Web.Services.WebService
    {

   
        [WebMethod]
        public DataSet buscarClientePorNombre(string nombre1)
        {
            clsConexion con = new clsConexion();
            string s;
            s = "select idCliente, nombre, apellido_paterno, apellido_materno, date_format(fecha_nacimiento, '%Y-%m-%d') as fecha, correo, telefono, sexo from cliente where cliente.nombre=('"+nombre1+"');";
            DataSet ds = new DataSet();
            con.ejecutarSQL(s, "tc", ds);
            return ds;
        }

        [WebMethod]
        public DataSet mostrarTodos(string nombre)
        {
            clsConexion con = new clsConexion();
            string s;
            s = "select idCliente, nombre, apellido_paterno, apellido_materno, date_format(fecha_nacimiento, '%Y-%m-%d') as fecha, correo, telefono, sexo from cliente";
            DataSet ds = new DataSet();
            con.ejecutarSQL(s, "tc", ds);
            return ds;
        }

        [WebMethod]
        public DataSet guardarCliente(string nombre1, string paterno, string materno, string fecha, string correo, string telefono, string sexo)
        {
            clsConexion con = new clsConexion();
            string s;
            s = "insert into cliente (nombre,apellido_paterno,apellido_materno,fecha_nacimiento,correo,telefono,sexo) values ('"+nombre1+"','"+paterno+"','"+materno+"','"+fecha+"','"+correo+"','"+telefono+"','"+sexo+"');";
            DataSet ds = new DataSet();
            con.ejecutarSQL(s, "tc", ds);
            return ds;
        }

        [WebMethod]
        public DataSet eliminarCliente(string id)
        {
            clsConexion con = new clsConexion();
            string s;
            s = "delete from cliente where idCliente = '"+id+"'";
            DataSet ds = new DataSet();
            con.ejecutarSQL(s, "tc", ds);
            return ds;
        }

        [WebMethod]
        public DataSet modificarCliente(string id, string nombre1, string paterno, string materno, string fecha, string correo, string telefono, string sexo)
        {
            clsConexion con = new clsConexion();
            string s;
            s = "update cliente set nombre='"+nombre1+ "',apellido_paterno='"+paterno+ "',apellido_materno='"+materno+"',fecha_nacimiento='"+fecha+ "',correo='" + correo + "',telefono='" + telefono + "',sexo='" + sexo + "' where idCliente='"+id+"'";
            DataSet ds = new DataSet();
            con.ejecutarSQL(s, "tc", ds);
            return ds;
        }


    }
}
