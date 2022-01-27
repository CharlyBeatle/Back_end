
using APIMusica.Business.DTO;
using APIMusica.Data.Clases;
using APIMusica.Data.Model;
using System.Collections.Generic;

namespace APIMusica.Business.Clases
{
    public class ClsUsuario
    {
        private UsuarioDao usuarioDao = new UsuarioDao();
        private PerfilDao perfilDao = new PerfilDao();
        public List<UsuarioDTO> getList()
        {
            List<UsuarioDTO> list = new List<UsuarioDTO>();
            var usuarios = usuarioDao.GetUsuarios();
            foreach (var item in usuarios)
            {
                var usuario = new UsuarioDTO
                {
                    idUsuario = item.IdUsuario,
                    nombre = string.Format("{0}", item.Nombres),
                    idPerfil = item.IdPerfil,
                    correo = item.Correo,
                    nombrePerfil = perfilDao.GetPerfil(item.IdPerfil).Descripcion,
                    password = item.Password,
                    estado = item.Estado
                };

                list.Add(usuario);
            }
            return list;
        }

        public UsuarioDTO getUsuario(string id)
        {
            UsuarioDTO usuario = new UsuarioDTO();
            var item = usuarioDao.GetUsuario(id);
            if (item != null)
            {
                var perfil = perfilDao.GetPerfil(item.IdPerfil);
                usuario = new UsuarioDTO
                {
                    idUsuario = item.IdUsuario,
                    nombre = string.Format("{0}", item.Nombres),
                    idPerfil = item.IdPerfil,
                    nombrePerfil = perfil.Descripcion,
                    tipo = perfil.Tipo,
                    password = item.Password,
                    estado = item.Estado
                };
            }
            return usuario;
        }

        public UsuarioDTO validateLogin(string user, string password)
        {
            UsuarioDTO usuario = new UsuarioDTO();
            var item = usuarioDao.GetUsuarioByUserPassword(user,password);
            if (item != null)
            {
                var perfil = perfilDao.GetPerfil(item.IdPerfil);
                usuario = new UsuarioDTO
                {
                    idUsuario = item.IdUsuario,
                    nombre = string.Format("{0}", item.Nombres),
                    idPerfil = item.IdPerfil,
                    nombrePerfil = perfil.Descripcion,
                    tipo = perfil.Tipo,
                    password = item.Password,
                    estado = item.Estado
                };
            } else
            {
                usuario = null;
            }
            return usuario;
        }

        public void SaveUsuario(UsuarioDTO usuario)
        {
            var model = new Usuario
            {
                IdUsuario = usuario.idUsuario,
                IdPerfil = usuario.idPerfil,
                Nombres = usuario.nombre,
                Apellidos = usuario.nombre,
                Correo = usuario.correo,
                Estado = usuario.estado,
                Password = usuario.password
            };

            usuarioDao.SaveUsuario(model);
        }
    }
}
