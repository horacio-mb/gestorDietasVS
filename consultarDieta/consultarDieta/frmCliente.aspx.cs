using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace consultarDieta
{
    public partial class frmCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            wsDieta.wsDieta obj = new wsDieta.wsDieta();
            if (rb1.Checked) { txtSexo.Text = "M"; }
            else { txtSexo.Text = "F"; }//mejor poner otro if por si manda vacio
            obj.guardarCliente(txtNombre.Text, txtPaterno.Text, txtMaterno.Text, txtNacimiento.Text, txtCorreo.Text, txtTelefono.Text, txtSexo.Text);
            limpiar();
            gdvCliente.DataSource = "";
            gdvCliente.DataBind();
        }

        protected void limpiar()
        {
            txtNombre.Text = "";
            txtPaterno.Text = "";
            txtMaterno.Text = "";
            txtNacimiento.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtSexo.Text = "";
        }
        protected void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            wsDieta.wsDieta obj = new wsDieta.wsDieta();
            if (txtBuscarCliente.Text.Length < 1)
            {
                gdvCliente.DataSource = obj.mostrarTodos(txtBuscarCliente.Text);
            }
            else
            { gdvCliente.DataSource = obj.buscarClientePorNombre(txtBuscarCliente.Text); }
            gdvCliente.DataBind();
        }

        protected void gdvCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdCliente.Text = gdvCliente.SelectedRow.Cells[1].Text;
            txtNombre.Text = gdvCliente.SelectedRow.Cells[2].Text;
            txtPaterno.Text = gdvCliente.SelectedRow.Cells[3].Text;
            txtMaterno.Text = gdvCliente.SelectedRow.Cells[4].Text;
            txtNacimiento.Text = gdvCliente.SelectedRow.Cells[5].Text;
            txtCorreo.Text = gdvCliente.SelectedRow.Cells[6].Text;
            txtTelefono.Text = gdvCliente.SelectedRow.Cells[7].Text;
            txtSexo.Text = gdvCliente.SelectedRow.Cells[8].Text;
        }

        protected void bntEliminar_Click(object sender, EventArgs e)
        {
            wsDieta.wsDieta obj = new wsDieta.wsDieta();
            obj.eliminarCliente(txtIdCliente.Text);
            limpiar();
            gdvCliente.DataSource = "";
            gdvCliente.DataBind();
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            wsDieta.wsDieta obj = new wsDieta.wsDieta();
            if (rb1.Checked) { txtSexo.Text = "M"; }
            else { txtSexo.Text = "F"; }
            obj.modificarCliente(txtIdCliente.Text, txtNombre.Text, txtPaterno.Text, txtMaterno.Text, txtNacimiento.Text, txtCorreo.Text, txtTelefono.Text, txtSexo.Text);
            limpiar();
            gdvCliente.DataSource = "";
            gdvCliente.DataBind();

        }


    }
}