namespace ElTavo.RepositoryPattern.SqlRepository
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Contexto : DbContext
    {
        public Contexto()
            : base("name=Contexto")
        {
        }

        public virtual DbSet<Empleado.Empleado> Empleados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado.Empleado>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado.Empleado>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado.Empleado>()
                .Property(e => e.Telefono)
                .IsUnicode(false);
        }
    }
}
