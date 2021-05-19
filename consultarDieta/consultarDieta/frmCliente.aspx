<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCliente.aspx.cs" Inherits="consultarCliente.frmCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h3>CONSULTAS</h3>
        <div>
            <div>
                <h4>BUSCAR CLIENTES</h4>
                <h3>REGISTRO DE PRODUCTOS</h3>
            <div>
                <asp:Table runat="server">
                    <asp:TableRow>
                        <asp:TableCell></asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="txtIdCliente" Type="hidden" runat="server"></asp:TextBox></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>Nombre</asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>Apellido Paterno</asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="txtPaterno" runat="server"></asp:TextBox></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>Apellido Materno</asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="txtMaterno" runat="server"></asp:TextBox></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>Fecha de Nacimiento</asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="txtNacimiento" type="date" runat="server"></asp:TextBox></asp:TableCell>
                     </asp:TableRow>
                      <asp:TableRow>
                        <asp:TableCell>Correo</asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox></asp:TableCell>
                     </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>Telefono</asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox></asp:TableCell>
                     </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>Sexo</asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="txtSexo" type="hidden" runat="server"></asp:TextBox>
                            <asp:RadioButton ID="rb1" runat="server" GroupName="rbt" text="Masculino"/>
                    <asp:RadioButton ID="rb2" runat="server" GroupName="rbt" text="Femenino"/>
                        </asp:TableCell>
                     </asp:TableRow>
                </asp:Table>             
                    
                    <br />
                    <br />
                    <asp:Button ID="btnGuardar" runat="server" OnClick="Button1_Click" Text="Guardar" />
                    <asp:Button ID="bntEliminar" runat="server" Text="Eliminar" OnClick="bntEliminar_Click" />
                    <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
                    <br />
                    <br />
                    <asp:TextBox ID="txtBuscarCliente" runat="server"></asp:TextBox>             
                    <asp:Button ID="btnBuscarCliente" runat="server" Text="Buscar Cliente por Nombre" OnClick="btnBuscarCliente_Click" />
                    <br />
                    <br />
                    <asp:GridView ID="gdvCliente" runat="server" OnSelectedIndexChanged="gdvCliente_SelectedIndexChanged">
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" HeaderText="Opciones" SelectText="Seleccionar"/>
                        </Columns>
                    </asp:GridView>
                    <br />
                </div>
               </div>
            </div>
    </form>
</body>
</html>