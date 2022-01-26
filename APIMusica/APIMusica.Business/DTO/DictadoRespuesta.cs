using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIMusica.Business.DTO
{
    public class DictadoRespuesta
    {
        public short idTipo { get; set; }
        public string tipo { get; set; }
        public DateTime fecha { get; set; }
        public bool calificacion { get; set; }
        public DetalleDictadoRespuesta detalle { get; set; }
        public string usuario { get; set; }

    }

    public class DetalleDictadoRespuesta 
    {
        public string dictadoOriginal { get; set; }
        public string dictadoRespuesta { get; set; }
    }
}
