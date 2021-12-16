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
    public class UsuarioController : ApiController
    {
        private ClsUsuario usuario = new ClsUsuario();
        
        [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
        [HttpGet]
        public IHttpActionResult GetUsuariosList()
        {
            var result = usuario.getList();
            return Json(result);
        }


        [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
        [HttpGet]
        public IHttpActionResult GetUsuario(string id)
        {
            var result = usuario.getUsuario(id);
            return Json(result);
        }

        [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
        [HttpPost]
        public IHttpActionResult SaveUsuario(UsuarioDTO model)
        {
            usuario.SaveUsuario(model);
            return Json("");
        }
    }
}
