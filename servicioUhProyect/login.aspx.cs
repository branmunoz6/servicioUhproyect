using System;
using System.Web.UI;

namespace TuProyecto
{
    public partial class Login : Page
    {
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtClave.Text == "1234")
            {
                Session["Usuario"] = txtUsuario.Text;
                Response.Redirect("Usuarios.aspx");
            }
            else
            {
                lblMensaje.Text = "Usuario o contraseña incorrectos.";
            }
        }
    }
}
