using APIMusica.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APIMusica.Data.Clases
{
    public class PerfilDao
    {
        public List<Perfil> GetPerfiles()
        {
            List<Perfil> result = new List<Perfil>();
            try
            {
                using (var context = new MusicaEntities())
                {
                    result = context.Perfil.ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return result;
        }

        public Perfil GetPerfil(int idPerfil)
        {
            Perfil result = new Perfil();
            try
            {
                using (var context = new MusicaEntities())
                {
                    result = context.Perfil.FirstOrDefault(x => x.IdPerfil == idPerfil);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return result;
        }

        public void SavePerfil(Perfil model)
        {
            using (var context = new MusicaEntities())
            {
                var perfil = context.Perfil.FirstOrDefault(x => x.IdPerfil == model.IdPerfil);
                if (perfil != null)
                {
                    perfil.Descripcion = model.Descripcion;
                }
                else
                {
                    context.Perfil.Add(model);
                }

                context.SaveChanges();
            }
        }
    }
}
