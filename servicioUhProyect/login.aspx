<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TuProyecto.Login" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server"><title>Login</title><link href="Site.css" rel="stylesheet" /></head>
<body>
<form id="form1" runat="server">
    <div class="form-box">
        <h2>Login</h2>
        <asp:TextBox ID="txtUsuario" runat="server" CssClass="input-box" Placeholder="Usuario"></asp:TextBox><br />
        <asp:TextBox ID="txtClave" runat="server" CssClass="input-box" TextMode="Password" Placeholder="Contraseña"></asp:TextBox><br />
        <asp:Button ID="btnLogin" runat="server" Text="Entrar" CssClass="btn" OnClick="btnLogin_Click" />
        <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>
    </div>
</form>
</body>
</html>
