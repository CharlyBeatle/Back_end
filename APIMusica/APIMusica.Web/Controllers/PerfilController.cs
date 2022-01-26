using APIMusica.Business.Clases;
using APIMusica.Business.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace APIMusica.Web.Controllers
{
    public class PerfilController : ApiController
    {
        private ClsPerfil perfil = new ClsPerfil();

        [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
        [HttpGet]
        public IHttpActionResult GetPerfilList()
        {
            var result = perfil.getList();
            return Json(result);
        }

        [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
        [HttpGet]
        public IHttpActionResult GetPerfilById(int id)
        {
            var result = perfil.getPerfil(id);
            return Json(result);
        }

        [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
        [HttpPost]
        public IHttpActionResult SavePerfil(PerfilDTO model)
        {
            perfil.SavePerfil(model);
            return Json("");
        }
    }
}
