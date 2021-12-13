namespace APIMusica.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dictado")]
    public partial class Dictado
    {
        [Key]
        public int IdDictado { get; set; }

        [Required]
        [StringLength(20)]
        public string IdUsuario { get; set; }

        [Column("Dictado")]
        [Required]
        [StringLength(800)]
        public string Dictado1 { get; set; }

        public bool Calificacion { get; set; }

        public DateTime Fecha { get; set; }

        public short Nivel { get; set; }

        public virtual Nivel Nivel1 { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
