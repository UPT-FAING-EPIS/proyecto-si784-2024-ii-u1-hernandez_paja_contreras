using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TGU3_Briceño_Lopez_Hernandez_Huallpa.BD
{
    public partial class Modelo_Asistencia : DbContext
    {
        public Modelo_Asistencia()
            : base("name=Modelo_Asistencia")
        {
        }

        public virtual DbSet<Asistencia> Asistencia { get; set; }
        public virtual DbSet<Departamentos> Departamentos { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Empleado_Puesto> Empleado_Puesto { get; set; }
        public virtual DbSet<Horarios> Horarios { get; set; }
        public virtual DbSet<Puestos> Puestos { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<V_Asistencias> V_Asistencias { get; set; }
        public virtual DbSet<V_Empleados> V_Empleados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asistencia>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Departamentos>()
                .Property(e => e.NombreDepartamento)
                .IsUnicode(false);

            modelBuilder.Entity<Departamentos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Dni)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Celular)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .HasMany(e => e.Asistencia)
                .WithRequired(e => e.Empleado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empleado>()
                .HasMany(e => e.Empleado_Puesto)
                .WithRequired(e => e.Empleado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empleado>()
                .HasMany(e => e.Horarios)
                .WithRequired(e => e.Empleado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empleado>()
                .HasMany(e => e.Usuario)
                .WithRequired(e => e.Empleado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empleado_Puesto>()
                .Property(e => e.Precio)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Puestos>()
                .Property(e => e.NombrePuesto)
                .IsUnicode(false);

            modelBuilder.Entity<Puestos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Puestos>()
                .HasMany(e => e.Empleado_Puesto)
                .WithRequired(e => e.Puestos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Nivel)
                .IsUnicode(false);

            modelBuilder.Entity<V_Asistencias>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<V_Empleados>()
                .Property(e => e.Dni)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_Empleados>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<V_Empleados>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<V_Empleados>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<V_Empleados>()
                .Property(e => e.Celular)
                .IsUnicode(false);

            modelBuilder.Entity<V_Empleados>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<V_Empleados>()
                .Property(e => e.Estado)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
