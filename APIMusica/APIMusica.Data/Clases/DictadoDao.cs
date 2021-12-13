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
        List<Dictado> GetDictados(string user)
        {
            var result = new List<Dictado>();
            try
            {
                using(var context = new MusicaEntities())
                {
                    result= context.Dictado.Where(x => x.IdUsuario == user).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }

        Dictado GetDictado(int idDictado)
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

        void SaveDictado(Dictado model)
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
