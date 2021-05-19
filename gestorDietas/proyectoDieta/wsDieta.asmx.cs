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

    }
}
