using APIMusica.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIMusica.Data.Clases
{
    public class UsuarioDao
    {
        public List<Usuario> GetUsuarios()
        {
            List<Usuario> result = new List<Usuario>();
            try
            {
                using (var context = new MusicaEntities())
                {
                    result = context.Usuario.ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return result;
        }

        public Usuario GetUsuario(string user)
        {
            Usuario result = new Usuario();
            try
            {
                using (var context = new MusicaEntities())
                {
                    result = context.Usuario.FirstOrDefault(x => x.IdUsuario == user);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return result;
        }

        public void SaveUsuario(Usuario model)
        {
            using (var context = new MusicaEntities())
            {
                var user = context.Usuario.FirstOrDefault(x => x.IdUsuario == model.IdUsuario);
                if (user.IdUsuario != "")
                {
                    user.Nombres = model.Nombres;
                    user.Apellidos = model.Apellidos;
                    user.Correo = model.Correo;
                    user.Estado = model.Estado;
                }
                else
                {
                    model.Estado = true;
                    context.Usuario.Add(model);
                }

                context.SaveChanges();
            }
        }
    }
}
