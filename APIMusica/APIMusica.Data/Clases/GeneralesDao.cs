using APIMusica.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIMusica.Data.Clases
{
    public class GeneralesDao
    {
        public List<Perfil> GetPerfiles()
        {
            var result = new List<Perfil>();
            using(var context = new MusicaEntities())
            {
                context.Perfil.ToList();
            }

            return result;
        }

        public List<Nivel> GetNiveles()
        {
            var result = new List<Nivel>();
            using (var context = new MusicaEntities())
            {
                context.Nivel.ToList();
            }

            return result;
        }


        public Nivel GetNivelById(short id)
        {
            var result = new List<Nivel>();
            using (var context = new MusicaEntities())
            {
                return context.Nivel.FirstOrDefault(x => x.IdNivel == id);
            }
        }
    }
}
