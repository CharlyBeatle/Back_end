using APIMusica.Business.Clases;
using System.Web.Http;
using System.Web.Http.Cors;

namespace APIMusica.Web.Controllers
{
    public class DictadoController : ApiController
    {
        [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
        [HttpGet]
        public IHttpActionResult GetDictado(int dificultad)
        {
            ClsDictado prueba = new ClsDictado();
            var dictado = prueba.GenerarDictado(dificultad);
            return Json(dictado);
        }
    }
}