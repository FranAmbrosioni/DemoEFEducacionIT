using DemoEFWindows.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoEFWindows.Data
{
    internal class DbProductosMAJAContext : DbContext
    {


        public DbProductosMAJAContext():base("keyDBFacturacion") { }

        //propiedades dbSET
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }

        public DbSet<Cliente> Clientes { get; set;}

        public DbSet<Empleado> Empleados { get; set; }

        //aqui se agregaria fluent api para las validaciones
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            //pk empleado
            modelBuilder.Entity<Empleado>().HasKey(e => e.IdEmpleado);

            //tipo de dato
           
            //longitud cadena 
            modelBuilder.Entity<Empleado>()
                .Property(e => e.Nombre)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Apellido)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

          
           //not nullable

           
        }

    }
}
