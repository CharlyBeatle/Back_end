using APIMusica.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIMusica.Data.Clases
{
    public class DictadoDao
    {
        public List<Dictado> GetDictados(string user)
        {
            var result = new List<Dictado>();
            try
            {
                using(var context = new MusicaEntities())
                {
                    result= context.Dictado.Where(x => x.IdUsuario == user).OrderByDescending(s=> s.Fecha).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }

        public Dictado GetDictado(int idDictado)
        {
            Dictado result = new Dictado();
            try
            {
                using (var context = new MusicaEntities())
                {
                    result = context.Dictado.FirstOrDefault(x => x.IdDictado == idDictado);
                }
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }

        public void SaveDictado(Dictado model)
        {
            try
            {
                using (var context = new MusicaEntities())
                {
                    context.Dictado.Add(model);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
