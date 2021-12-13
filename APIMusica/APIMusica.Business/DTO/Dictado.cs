using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIMusica.Business.DTO
{
    public class Dictado
    {
        public string Metrica { get; set; }
        public List<string> Compas { get; set; }
        public string TextoDictado { get; set; }
        public bool Estado { get; set; }
    }
}
