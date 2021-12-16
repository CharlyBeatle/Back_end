namespace APIMusica.Business.DTO
{
    public class UsuarioDTO
    {
        public string idUsuario { get; set; }
        public string nombre { get; set; }
        public short idPerfil { get; set; }
        public string nombrePerfil { get; set; }
        public string  password { get; set; }
        public bool estado { get; set; }
        public string correo { get; set; }
    }
}
