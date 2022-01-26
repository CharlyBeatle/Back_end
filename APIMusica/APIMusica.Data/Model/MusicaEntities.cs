namespace APIMusica.Data.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MusicaEntities : DbContext
    {
        public MusicaEntities()
            : base("name=MusicaEntities")
        {
        }

        public virtual DbSet<Dictado> Dictado { get; set; }
        public virtual DbSet<Nivel> Nivel { get; set; }
        public virtual DbSet<Perfil> Perfil { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dictado>()
                .Property(e => e.IdUsuario)
                .IsUnicode(false);

            modelBuilder.Entity<Dictado>()
                .Property(e => e.Original)
                .IsUnicode(false);

            modelBuilder.Entity<Dictado>()
                .Property(e => e.Respuesta)
                .IsUnicode(false);

            modelBuilder.Entity<Nivel>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Nivel>()
                .HasMany(e => e.Dictado)
                .WithRequired(e => e.Nivel1)
                .HasForeignKey(e => e.Nivel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Perfil>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Perfil>()
                .HasMany(e => e.Usuario)
                .WithRequired(e => e.Perfil)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.IdUsuario)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Dictado)
                .WithRequired(e => e.Usuario)
                .WillCascadeOnDelete(false);
        }
    }
}
