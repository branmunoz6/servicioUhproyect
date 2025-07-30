using servicioUhProyect.Modelos;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace servicioUhProyect.Logica
{
    public class UsuarioBLL
    {
        private const string SessionKey = "ListaUsuarios";

        public List<Usuario> ObtenerUsuarios(HttpSessionState session)
        {
            if (session[SessionKey] == null)
                session[SessionKey] = new List<Usuario>();
            return (List<Usuario>)session[SessionKey];
        }

        public void AgregarUsuario(HttpSessionState session, Usuario u)
        {
            var lista = ObtenerUsuarios(session);
            u.UsuarioID = lista.Count > 0 ? lista.Max(x => x.UsuarioID) + 1 : 1;
            lista.Add(u);
            session[SessionKey] = lista;
        }

        public void ActualizarUsuario(HttpSessionState session, Usuario u)
        {
            var lista = ObtenerUsuarios(session);
            var item = lista.Find(x => x.UsuarioID == u.UsuarioID);
            if (item != null)
            {
                item.Nombre = u.Nombre;
                item.CorreoElectronico = u.CorreoElectronico;
                item.Telefono = u.Telefono;
            }
            session[SessionKey] = lista;
        }

        public void EliminarUsuario(HttpSessionState session, int id)
        {
            var lista = ObtenerUsuarios(session);
            lista.RemoveAll(x => x.UsuarioID == id);
            session[SessionKey] = lista;
        }
    }
}
