<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="TuProyecto.Usuarios" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Usuarios</title>
    <link href="css/estilo.css" rel="stylesheet" />
</head>
<body>
<form id="form1" runat="server">
    <div class="form-box">
        <h2>Gestión de Usuarios</h2>
        <asp:HiddenField ID="hfUsuarioID" runat="server" />
        <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label><br />
        <asp:TextBox ID="txtNombre" runat="server" CssClass="input-box"></asp:TextBox><br />
        <asp:Label ID="lblCorreo" runat="server" Text="Correo Electrónico"></asp:Label><br />
        <asp:TextBox ID="txtCorreo" runat="server" CssClass="input-box"></asp:TextBox><br />
        <asp:Label ID="lblTelefono" runat="server" Text="Teléfono"></asp:Label><br />
        <asp:TextBox ID="txtTelefono" runat="server" CssClass="input-box"></asp:TextBox><br />

        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn" OnClick="btnGuardar_Click" />
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn" OnClick="btnEliminar_Click" />

        <br /><br />
        <asp:GridView ID="gvUsuarios" runat="server" AutoGenerateColumns="false" CssClass="grid" OnSelectedIndexChanged="gvUsuarios_SelectedIndexChanged" DataKeyNames="UsuarioID">
            <Columns>
                <asp:BoundField DataField="UsuarioID" HeaderText="ID" ReadOnly="true" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="CorreoElectronico" HeaderText="Correo" />
                <asp:BoundField DataField="Telefono" HeaderText="Teléfono" />
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </div>
</form>
</body>
</html>
