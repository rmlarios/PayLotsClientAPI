using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using DevExtremeAspNetCoreResponsiveApp.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace DevExtremeAspNetCoreResponsiveApp.Model
{
    public partial class PayLotsDBContext : IdentityDbContext<AppUser>
    {
        public PayLotsDBContext()
        {
        }

        public PayLotsDBContext(DbContextOptions<PayLotsDBContext> options)
            : base(options)
        {
        }


        public virtual DbSet<Asignaciones> Asignaciones { get; set; }
        //public virtual DbSet<AspnetApplications> AspnetApplications { get; set; }
        //public virtual DbSet<AspnetMembership> AspnetMembership { get; set; }
        //public virtual DbSet<AspnetPaths> AspnetPaths { get; set; }
        //public virtual DbSet<AspnetPersonalizationAllUsers> AspnetPersonalizationAllUsers { get; set; }
        //public virtual DbSet<AspnetPersonalizationPerUser> AspnetPersonalizationPerUser { get; set; }
        //public virtual DbSet<AspnetProfile> AspnetProfile { get; set; }
        //public virtual DbSet<AspnetRoles> AspnetRoles { get; set; }
        //public virtual DbSet<AspnetSchemaVersions> AspnetSchemaVersions { get; set; }
        //public virtual DbSet<AspnetUsers> AspnetUsers { get; set; }
        //public virtual DbSet<AspnetUsersInRoles> AspnetUsersInRoles { get; set; }
        //public virtual DbSet<AspnetWebEventEvents> AspnetWebEventEvents { get; set; }
        public virtual DbSet<Beneficiarios> Beneficiarios { get; set; }
        public virtual DbSet<Bloques> Bloques { get; set; }
        public virtual DbSet<CatalogoDepartamentos> CatalogoDepartamentos { get; set; }
        public virtual DbSet<CatalogoMunicipios> CatalogoMunicipios { get; set; }
        public virtual DbSet<CatalogoPreguntas> CatalogoPreguntas { get; set; }
        public virtual DbSet<ControlAccesoUsuarios> ControlAccesoUsuarios { get; set; }
        public virtual DbSet<DatosEmpresa> DatosEmpresa { get; set; }
        public virtual DbSet<ErroresSistema> ErroresSistema { get; set; }
        public virtual DbSet<ErrorSql> ErrorSql { get; set; }
        public virtual DbSet<Importacion3> Importacion3 { get; set; }
        public virtual DbSet<Lotes> Lotes { get; set; }
        public virtual DbSet<Mora> Mora { get; set; }
        public virtual DbSet<Pagos> Pagos { get; set; }
        public virtual DbSet<Proformas> Proformas { get; set; }
        public virtual DbSet<Seguimientos> Seguimientos { get; set; }
        public virtual DbSet<Ubicaciones> Ubicaciones { get; set; }

        // Unable to generate entity type for table 'dbo.Consulta'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Importacion'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Importacion2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Morosos'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer("Server=MEM-INFO-10\\LOCALSQL2016;Database=PayLots;Trusted_Connection=True;");
                //optionsBuilder.UseSqlServer();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Asignaciones>(entity =>
            {
                entity.HasOne(d => d.IdBeneficiarioNavigation)
                    .WithMany(p => p.Asignaciones)
                    .HasForeignKey(d => d.IdBeneficiario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Asignaciones_Beneficiarios");

                entity.HasOne(d => d.IdLoteNavigation)
                    .WithMany(p => p.Asignaciones)
                    .HasForeignKey(d => d.IdLote)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Asignaciones_Lotes");
            });

            //modelBuilder.Entity<AspnetApplications>(entity =>
            //{
            //    entity.HasKey(e => e.ApplicationId)
            //        .ForSqlServerIsClustered(false);

            //    entity.HasIndex(e => e.ApplicationName)
            //        .HasName("UQ__aspnet_A__30910331D5193993")
            //        .IsUnique();

            //    entity.HasIndex(e => e.LoweredApplicationName)
            //        .HasName("UQ__aspnet_A__17477DE473C17A67")
            //        .IsUnique();

            //    entity.Property(e => e.ApplicationId).HasDefaultValueSql("(newid())");
            //});

            //modelBuilder.Entity<AspnetMembership>(entity =>
            //{
            //    entity.HasKey(e => e.UserId)
            //        .ForSqlServerIsClustered(false);

            //    entity.Property(e => e.UserId).ValueGeneratedNever();

            //    entity.HasOne(d => d.Application)
            //        .WithMany(p => p.AspnetMembership)
            //        .HasForeignKey(d => d.ApplicationId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK__aspnet_Me__Appli__6E01572D");

            //    entity.HasOne(d => d.User)
            //        .WithOne(p => p.AspnetMembership)
            //        .HasForeignKey<AspnetMembership>(d => d.UserId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK__aspnet_Me__UserI__6EF57B66");
            //});

            //modelBuilder.Entity<AspnetPaths>(entity =>
            //{
            //    entity.HasKey(e => e.PathId)
            //        .ForSqlServerIsClustered(false);

            //    entity.Property(e => e.PathId).HasDefaultValueSql("(newid())");

            //    entity.HasOne(d => d.Application)
            //        .WithMany(p => p.AspnetPaths)
            //        .HasForeignKey(d => d.ApplicationId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK__aspnet_Pa__Appli__6FE99F9F");
            //});

            //modelBuilder.Entity<AspnetPersonalizationAllUsers>(entity =>
            //{
            //    entity.Property(e => e.PathId).ValueGeneratedNever();

            //    entity.HasOne(d => d.Path)
            //        .WithOne(p => p.AspnetPersonalizationAllUsers)
            //        .HasForeignKey<AspnetPersonalizationAllUsers>(d => d.PathId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK__aspnet_Pe__PathI__70DDC3D8");
            //});

            //modelBuilder.Entity<AspnetPersonalizationPerUser>(entity =>
            //{
            //    entity.HasKey(e => e.Id)
            //        .ForSqlServerIsClustered(false);

            //    entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            //    entity.HasOne(d => d.Path)
            //        .WithMany(p => p.AspnetPersonalizationPerUser)
            //        .HasForeignKey(d => d.PathId)
            //        .HasConstraintName("FK__aspnet_Pe__PathI__71D1E811");

            //    entity.HasOne(d => d.User)
            //        .WithMany(p => p.AspnetPersonalizationPerUser)
            //        .HasForeignKey(d => d.UserId)
            //        .HasConstraintName("FK__aspnet_Pe__UserI__72C60C4A");
            //});

            //modelBuilder.Entity<AspnetProfile>(entity =>
            //{
            //    entity.Property(e => e.UserId).ValueGeneratedNever();

            //    entity.HasOne(d => d.User)
            //        .WithOne(p => p.AspnetProfile)
            //        .HasForeignKey<AspnetProfile>(d => d.UserId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK__aspnet_Pr__UserI__73BA3083");
            //});

            //modelBuilder.Entity<AspnetRoles>(entity =>
            //{
            //    entity.HasKey(e => e.RoleId)
            //        .ForSqlServerIsClustered(false);

            //    entity.Property(e => e.RoleId).HasDefaultValueSql("(newid())");

            //    entity.HasOne(d => d.Application)
            //        .WithMany(p => p.AspnetRoles)
            //        .HasForeignKey(d => d.ApplicationId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK__aspnet_Ro__Appli__74AE54BC");
            //});

            //modelBuilder.Entity<AspnetSchemaVersions>(entity =>
            //{
            //    entity.HasKey(e => new { e.Feature, e.CompatibleSchemaVersion });
            //});

            //modelBuilder.Entity<AspnetUsers>(entity =>
            //{
            //    entity.HasKey(e => e.UserId)
            //        .ForSqlServerIsClustered(false);

            //    entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");

            //    entity.HasOne(d => d.Application)
            //        .WithMany(p => p.AspnetUsers)
            //        .HasForeignKey(d => d.ApplicationId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK__aspnet_Us__Appli__75A278F5");
            //});

            //modelBuilder.Entity<AspnetUsersInRoles>(entity =>
            //{
            //    entity.HasKey(e => new { e.UserId, e.RoleId });

            //    entity.HasOne(d => d.Role)
            //        .WithMany(p => p.AspnetUsersInRoles)
            //        .HasForeignKey(d => d.RoleId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK__aspnet_Us__RoleI__76969D2E");

            //    entity.HasOne(d => d.User)
            //        .WithMany(p => p.AspnetUsersInRoles)
            //        .HasForeignKey(d => d.UserId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK__aspnet_Us__UserI__778AC167");
            //});

            //modelBuilder.Entity<AspnetWebEventEvents>(entity =>
            //{
            //    entity.Property(e => e.EventId)
            //        .IsUnicode(false)
            //        .ValueGeneratedNever();
            //});

            modelBuilder.Entity<Bloques>(entity =>
            {
                entity.HasOne(d => d.IdUbicacionNavigation)
                    .WithMany(p => p.Bloques)
                    .HasForeignKey(d => d.IdUbicacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bloques_Ubicaciones");
            });

            modelBuilder.Entity<CatalogoMunicipios>(entity =>
            {
                entity.HasOne(d => d.Departamento)
                    .WithMany(p => p.CatalogoMunicipios)
                    .HasForeignKey(d => d.DepartamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Catalogo_Municipios_Catalogo_Departamentos");
            });

            modelBuilder.Entity<ErrorSql>(entity =>
            {
                entity.Property(e => e.Fecha).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Lotes>(entity =>
            {
                entity.HasOne(d => d.IdBloqueNavigation)
                    .WithMany(p => p.Lotes)
                    .HasForeignKey(d => d.IdBloque)
                    .HasConstraintName("FK_Lotes_Bloques");
            });

            modelBuilder.Entity<Pagos>(entity =>
            {
                entity.HasOne(d => d.IdAsignacionNavigation)
                    .WithMany(p => p.Pagos)
                    .HasForeignKey(d => d.IdAsignacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pagos_Asignaciones");
            });
        }

       
    }
}
