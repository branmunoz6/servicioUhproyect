using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using servicioUhProyect.Modelos;
using servicioUhProyect.Logica;


namespace TuProyecto
{
    public partial class Usuarios : Page
    {
        UsuarioBLL usuarioBLL = new UsuarioBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                CargarGrid();
        }

        private void CargarGrid()
        {
            gvUsuarios.DataSource = usuarioBLL.ObtenerUsuarios(Session);
            gvUsuarios.DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(hfUsuarioID.Value, out id) && id > 0)
            {
                usuarioBLL.ActualizarUsuario(Session, new Usuario()
                {
                    UsuarioID = id,
                    Nombre = txtNombre.Text,
                    CorreoElectronico = txtCorreo.Text,
                    Telefono = txtTelefono.Text
                });
            }
            else
            {
                usuarioBLL.AgregarUsuario(Session, new Usuario()
                {
                    Nombre = txtNombre.Text,
                    CorreoElectronico = txtCorreo.Text,
                    Telefono = txtTelefono.Text
                });
            }
            LimpiarCampos();
            CargarGrid();
        }

        protected void gvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)gvUsuarios.SelectedDataKey.Value;
            var usuario = usuarioBLL.ObtenerUsuarios(Session).FirstOrDefault(u => u.UsuarioID == id);
            if (usuario != null)
            {
                hfUsuarioID.Value = usuario.UsuarioID.ToString();
                txtNombre.Text = usuario.Nombre;
                txtCorreo.Text = usuario.CorreoElectronico;
                txtTelefono.Text = usuario.Telefono;
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(hfUsuarioID.Value, out id))
            {
                usuarioBLL.EliminarUsuario(Session, id);
                LimpiarCampos();
                CargarGrid();
            }
        }

        private void LimpiarCampos()
        {
            hfUsuarioID.Value = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
        }
    }
}
