using APIMusica.Business.Clases;
using APIMusica.Business.DTO;
using System.Web.Http;
using System.Web.Http.Cors;

namespace APIMusica.Web.Controllers
{
    public class DictadoController : ApiController
    {
        ClsDictado dictados = new ClsDictado();

        [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
        [HttpGet]
        public IHttpActionResult GetDictado(int dificultad)
        {
            
            var dictado = dictados.GenerarDictado(dificultad);
            return Json(dictado);
        }

        [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
        [HttpGet]
        public IHttpActionResult GetDictadosByUser(string idUsuario)
        {
            var lista = dictados.ConsultatDictadosUsuario(idUsuario);
            return Json(lista);
        }

        [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
        [HttpPost]
        public IHttpActionResult Save(DictadoRespuesta dictado)
        {
            var resultado = dictados.GuardarDictado(dictado);
            return Json(resultado);
        }
    }
}