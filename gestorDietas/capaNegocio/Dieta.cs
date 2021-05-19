using capaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    class Dieta:clsConexion
    {
        //Modelo
        private int idDieta;
        private string nombre;
        private DateTime fechaInicio;
        private DateTime fechaFinal;
        private int idCliente;

        //Constructor
        public Dieta()
        {
            idDieta = 0;
            nombre = "";
            fechaInicio = DateTime.Today.Date;
            fechaFinal = DateTime.Today.Date;
            idCliente = 0;
        }
        
        //Metodos de Acceso
        public int IdDieta
        {
            get { return this.idDieta; }
            set { this.idDieta = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public DateTime FechaInicio
        {
            get { return this.fechaInicio; }
            set { this.fechaInicio = value; }
        }
        public DateTime FechaFinal
        {
            get { return this.fechaFinal; }
            set { this.fechaFinal = value; }
        }

        public int IdCliente
        {
            get { return this.idCliente; }
            set { this.idCliente = value; }
        }

        //Metodos CRUD
        public bool guardar()
        {
            iniciarSP("guardarVenta");
            parametroFecha(fecha, "fech");
            parametroDecimal(monto, "mont");
            parametroInt(id_cliente, "id_cli");
            if (ejecutarSP() == true) { return true; } else { return false; }
        }

    }

   
}
