
using APIMusica.Business.DTO;
using APIMusica.Data.Clases;
using APIMusica.Data.Model;
using System.Collections.Generic;

namespace APIMusica.Business.Clases
{
    public class ClsUsuario
    {
        private UsuarioDao usuarioDao = new UsuarioDao();
        public List<UsuarioDTO> getList()
        {
            List<UsuarioDTO> list = new List<UsuarioDTO>();
            var usuarios = usuarioDao.GetUsuarios();
            foreach (var item in usuarios)
            {
                var usuario = new UsuarioDTO
                {
                    idUsuario = item.IdUsuario,
                    nombre = string.Format("{0} {1}", item.Nombres, item.Apellidos),
                    idPerfil = item.IdPerfil,
                    nombrePerfil = item.Perfil.Descripcion,
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

                usuario = new UsuarioDTO
                {
                    idUsuario = item.IdUsuario,
                    nombre = string.Format("{0} {1}", item.Nombres, item.Apellidos),
                    idPerfil = item.IdPerfil,
                    nombrePerfil = item.Perfil.Descripcion,
                    password = item.Password,
                    estado = item.Estado
                };
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
                Correo = usuario.correo,
                Estado = usuario.estado,
                Password = usuario.password
            };

            usuarioDao.SaveUsuario(model);
        }
    }
}
