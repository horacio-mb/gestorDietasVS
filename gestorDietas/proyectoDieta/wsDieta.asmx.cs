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
        public DataSet guardarDieta(string nombre, string fechaInicio, string fechaFinal, int idCliente,int idUsuario)
        {
            clsConexion con = new clsConexion();
            string s;
            s = "insert into dieta(nombre,fechaInicio,fechaFinal,idCliente,idUsuario) values('"+ nombre + "','"+ fechaInicio + "','"+ fechaFinal + "','"+ idCliente + "','"+ idUsuario + "');";
            DataSet ds = new DataSet();
            con.ejecutarSQL(s, "tc", ds);
            return ds;
        }

        [WebMethod]
        public DataSet buscarVentaPorFecha(string fecha1, string fecha2)
        {
            clsConexion con = new clsConexion();
            string s;
            s = "select id_venta, empresa, date_format(fecha, '%Y-%m-%d') as fecha from cliente, venta where venta.id_cliente=cliente.id_cliente and fecha between ('" + fecha1 + "') and ('" + fecha2 + "');";
            DataSet ds = new DataSet();
            con.ejecutarSQL(s, "tc", ds);
            return ds;
        }
    }
}
