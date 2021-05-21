using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace E_Commerce_CuidadoConElPerro.Models
{
    public partial class CuidadoConElPerroContext : DbContext
    {
        public CuidadoConElPerroContext()
        {
        }

        public CuidadoConElPerroContext(DbContextOptions<CuidadoConElPerroContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Departamento> Departamentos { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<MetodoPago> MetodoPagos { get; set; }
        public virtual DbSet<Prendum> Prenda { get; set; }
        public virtual DbSet<Proovedor> Proovedors { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<Talla> Tallas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:project1-ropa.database.windows.net,1433;Initial Catalog=CuidadoConElPerro;Persist Security Info=False;User ID=Administrador;Password=Holasoymartin05;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__Cliente__E005FBFFFF19A0DC");

                entity.ToTable("Cliente");

                entity.Property(e => e.IdCliente).HasColumnName("ID_Cliente");

                entity.Property(e => e.Contrasenia)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Domicilio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.NomCliente)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Nom_Cliente");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.HasKey(e => e.IdDepartamento)
                    .HasName("PK__Departam__D9F8A9116BA01E97");

                entity.ToTable("Departamento");

                entity.Property(e => e.IdDepartamento).HasColumnName("Id_Departamento");

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.NombreDepartamento)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Departamento");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado)
                    .HasName("PK__Empleado__74056223A9B592A2");

                entity.ToTable("Empleado");

                entity.Property(e => e.IdEmpleado).HasColumnName("Id_Empleado");

                entity.Property(e => e.Contrasenia)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.IdRol).HasColumnName("Id_Rol");

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.NombreEmpleado)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Empleado");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("fk_Rol");
            });

            modelBuilder.Entity<MetodoPago>(entity =>
            {
                entity.HasKey(e => e.IdMetodoPago)
                    .HasName("PK__MetodoPa__657893471BE897FA");

                entity.ToTable("MetodoPago");

                entity.Property(e => e.IdMetodoPago).HasColumnName("Id_MetodoPago");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Prendum>(entity =>
            {
                entity.HasKey(e => e.IdPrenda)
                    .HasName("PK__Prenda__81B148F8E3434CAB");

                entity.Property(e => e.IdPrenda).HasColumnName("Id_Prenda");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Genero)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdDepartamento).HasColumnName("Id_Departamento");

                entity.Property(e => e.IdProovedor).HasColumnName("Id_Proovedor");

                entity.Property(e => e.IdTalla).HasColumnName("Id_Talla");

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.NombrePrenda)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Prenda");

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.HasOne(d => d.IdDepartamentoNavigation)
                    .WithMany(p => p.Prenda)
                    .HasForeignKey(d => d.IdDepartamento)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_Departamento");

                entity.HasOne(d => d.IdProovedorNavigation)
                    .WithMany(p => p.Prenda)
                    .HasForeignKey(d => d.IdProovedor)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_Proovedor");

                entity.HasOne(d => d.IdTallaNavigation)
                    .WithMany(p => p.Prenda)
                    .HasForeignKey(d => d.IdTalla)
                    .HasConstraintName("fk_Talla");
            });

            modelBuilder.Entity<Proovedor>(entity =>
            {
                entity.HasKey(e => e.IdProovedor)
                    .HasName("PK__Proovedo__21745C0AD970FF2E");

                entity.ToTable("Proovedor");

                entity.Property(e => e.IdProovedor).HasColumnName("Id_Proovedor");

                entity.Property(e => e.NombreProovedor)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Proovedor");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PK__Rol__55932E860785E85F");

                entity.ToTable("Rol");

                entity.Property(e => e.IdRol).HasColumnName("Id_Rol");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Talla>(entity =>
            {
                entity.HasKey(e => e.IdTalla)
                    .HasName("PK__Talla__A135FE6E42756548");

                entity.ToTable("Talla");

                entity.Property(e => e.IdTalla).HasColumnName("Id_Talla");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombreTalla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Talla");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
