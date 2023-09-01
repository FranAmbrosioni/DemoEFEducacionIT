using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DemoEscuelaEF.Models;

namespace DemoEscuelaEF.Data
{
    public class EscuelaDbContext : DbContext
    {
        public EscuelaDbContext() : base("keyEscuelaDB") { }

        public DbSet<Titulo> Titulos { get; set;}

        public DbSet<Profesor> Profesores { get; set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Profesor>().ToTable("Profesor");

            modelBuilder.Entity<Profesor>().HasKey(e => e.Id);

            //campo requerido, longitud y tipo de dato

            modelBuilder.Entity<Profesor>().Property(e => e.Nombre)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Profesor>().Property(e => e.Apellido)
                .HasColumnType("varchar")
                .HasMaxLength (50)
                .IsRequired();
        }

    }
}
