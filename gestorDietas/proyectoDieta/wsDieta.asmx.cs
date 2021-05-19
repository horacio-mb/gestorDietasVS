using DATOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace proyectoDieta
{
    /// <summary>
    /// Descripción breve de wsDieta
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsDieta : System.Web.Services.WebService
    {
        //Dieta Metodos
        [WebMethod]
        public DataSet guardarDieta(string nombre, string fechaInicio, string fechaFinal, string idCliente,string idUsuario)
        {
            clsConexion con = new clsConexion();
            string s;
            s = "insert into dieta(nombre,fechaInicio,fechaFinal,idCliente,idUsuario) values('"+ nombre + "','"+ fechaInicio + "','"+ fechaFinal + "','"+ idCliente + "','"+ idUsuario + "');";
            DataSet ds = new DataSet();
            con.ejecutarSQL(s, "tc", ds);
            return ds;
        }

        [WebMethod]
        public DataSet modificarDieta(string idDieta,string nombre, string fechaInicio, string fechaFinal, string idCliente, string idUsuario)
        {
            clsConexion con = new clsConexion();
            string s;
            s = "update dieta set nombre="+nombre+ ", fechaInicio="+ fechaInicio + ",  fechaFinal="+ fechaFinal + ", idCliente="+ idCliente + ", idUsuario="+ idUsuario + " where idDieta="+idDieta+" ;";
            DataSet ds = new DataSet();
            con.ejecutarSQL(s, "tc", ds);
            return ds;
        }

        [WebMethod]
        public DataSet eliminarDieta(string idDieta)
        {
            clsConexion con = new clsConexion();
            string s;
            s = "delete from dieta where idDieta = "+ idDieta + "; ";
            DataSet ds = new DataSet();
            con.ejecutarSQL(s, "tc", ds);
            return ds;
        }
        //buscar dieta averiguar que parámetros 
        [WebMethod]
        public DataSet buscarDietaPorCliente(string buscar)
        {
            clsConexion con = new clsConexion();
            string s;
            s = "select d.idDieta, d.nombre, d.fechaInicio, d.fechaFinal , concat_ws(' ',c.nombre, c.apellido_paterno) as cliente from dieta d inner join cliente c on c.idCliente=d.idCliente where concat_ws(' ',c.nombre, c.apellido_paterno) like concat('%" + buscar + "%')";
            DataSet ds = new DataSet();
            con.ejecutarSQL(s, "tc", ds);
            return ds;
        }


        //Metodos Cliente
        [WebMethod]
        public DataSet buscarClientePorNombre(string nombre1)
        {
            clsConexion con = new clsConexion();
            string s;
            s = "select idCliente, nombre, apellido_paterno, apellido_materno, date_format(fecha_nacimiento, '%Y-%m-%d') as fecha, correo, telefono, sexo from cliente where cliente.nombre=('" + nombre1 + "');";
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
            s = "insert into cliente (nombre,apellido_paterno,apellido_materno,fecha_nacimiento,correo,telefono,sexo) values ('" + nombre1 + "','" + paterno + "','" + materno + "','" + fecha + "','" + correo + "','" + telefono + "','" + sexo + "');";
            DataSet ds = new DataSet();
            con.ejecutarSQL(s, "tc", ds);
            return ds;
        }

        [WebMethod]
        public DataSet eliminarCliente(string id)
        {
            clsConexion con = new clsConexion();
            string s;
            s = "delete from cliente where idCliente = '" + id + "'";
            DataSet ds = new DataSet();
            con.ejecutarSQL(s, "tc", ds);
            return ds;
        }

        [WebMethod]
        public DataSet modificarCliente(string id, string nombre1, string paterno, string materno, string fecha, string correo, string telefono, string sexo)
        {
            clsConexion con = new clsConexion();
            string s;
            s = "update cliente set nombre='" + nombre1 + "',apellido_paterno='" + paterno + "',apellido_materno='" + materno + "',fecha_nacimiento='" + fecha + "',correo='" + correo + "',telefono='" + telefono + "',sexo='" + sexo + "' where idCliente='" + id + "'";
            DataSet ds = new DataSet();
            con.ejecutarSQL(s, "tc", ds);
            return ds;
        }

    }
}
