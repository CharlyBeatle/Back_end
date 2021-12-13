namespace APIMusica.Business.DTO
{
    #region Librerias
    using System.Collections.Generic;
    #endregion
    public class Metrica
    {
        public string ValorMetrica { get; set; }
        public List<Figura> Figuras { get; set; }
    }
}
