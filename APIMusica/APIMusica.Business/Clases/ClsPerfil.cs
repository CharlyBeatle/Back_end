using APIMusica.Business.DTO;
using APIMusica.Data.Clases;
using APIMusica.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIMusica.Business.Clases
{
    public class ClsPerfil
    {
        private PerfilDao perfilDao = new PerfilDao();
        public List<PerfilDTO> getList()
        {
            List<PerfilDTO> list = new List<PerfilDTO>();
            var perfiles = perfilDao.GetPerfiles();
            foreach (var item in perfiles)
            {
                var perfil = new PerfilDTO
                {
                    idPerfil = item.IdPerfil,
                    nombre = item.Descripcion,
                    Tipo = item.Tipo,
                    estado = true
                };

                list.Add(perfil);
            }
            return list;
        }

        public PerfilDTO getPerfil(int id)
        {
            PerfilDTO perfil = new PerfilDTO();
            var item = perfilDao.GetPerfil(id);
            if (item != null)
            {

                perfil = new PerfilDTO
                {
                    idPerfil = item.IdPerfil,
                    nombre = item.Descripcion,
                    Tipo = item.Tipo,
                    estado = true
                };
            }
            return perfil;
        }

        public void SavePerfil(PerfilDTO perfil)
        {
            var model = new Perfil
            {
                IdPerfil = (short)perfil.idPerfil,
                Tipo = perfil.Tipo,
                Descripcion = perfil.nombre
            };

            perfilDao.SavePerfil(model);
        }
    }
}
