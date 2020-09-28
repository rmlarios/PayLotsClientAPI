using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Data.Model
{
    public partial class PayLotsDbContext : DbContext
    {
        public PayLotsDbContext()
        {
        }

        public PayLotsDbContext(DbContextOptions<PayLotsDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Asignaciones> Asignaciones { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles1> AspNetRoles1 { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers1> AspNetUsers1 { get; set; }
        public virtual DbSet<AspnetApplications> AspnetApplications { get; set; }
        public virtual DbSet<AspnetMembership> AspnetMembership { get; set; }
        public virtual DbSet<AspnetPaths> AspnetPaths { get; set; }
        public virtual DbSet<AspnetPersonalizationAllUsers> AspnetPersonalizationAllUsers { get; set; }
        public virtual DbSet<AspnetPersonalizationPerUser> AspnetPersonalizationPerUser { get; set; }
        public virtual DbSet<AspnetProfile> AspnetProfile { get; set; }
        public virtual DbSet<AspnetRoles> AspnetRoles { get; set; }
        public virtual DbSet<AspnetSchemaVersions> AspnetSchemaVersions { get; set; }
        public virtual DbSet<AspnetUsers> AspnetUsers { get; set; }
        public virtual DbSet<AspnetUsersInRoles> AspnetUsersInRoles { get; set; }
        public virtual DbSet<AspnetWebEventEvents> AspnetWebEventEvents { get; set; }
        public virtual DbSet<Beneficiarios> Beneficiarios { get; set; }
        public virtual DbSet<Bloques> Bloques { get; set; }
        public virtual DbSet<CatalogoDepartamentos> CatalogoDepartamentos { get; set; }
        public virtual DbSet<CatalogoMunicipios> CatalogoMunicipios { get; set; }
        public virtual DbSet<CatalogoPreguntas> CatalogoPreguntas { get; set; }
        public virtual DbSet<Consulta> Consulta { get; set; }
        public virtual DbSet<ControlAccesoUsuarios> ControlAccesoUsuarios { get; set; }
        public virtual DbSet<DatosEmpresa> DatosEmpresa { get; set; }
        public virtual DbSet<ErrorSql> ErrorSql { get; set; }
        public virtual DbSet<ErroresSistema> ErroresSistema { get; set; }
        public virtual DbSet<Importacion> Importacion { get; set; }
        public virtual DbSet<Importacion2> Importacion2 { get; set; }
        public virtual DbSet<Importacion3> Importacion3 { get; set; }
        public virtual DbSet<Lotes> Lotes { get; set; }
        public virtual DbSet<Mora> Mora { get; set; }
        public virtual DbSet<Morosos> Morosos { get; set; }
        public virtual DbSet<Pagos> Pagos { get; set; }
        public virtual DbSet<Proformas> Proformas { get; set; }
        public virtual DbSet<Seguimientos> Seguimientos { get; set; }
        public virtual DbSet<Ubicaciones> Ubicaciones { get; set; }
        public virtual DbSet<ViewAsignacionesLotes> ViewAsignacionesLotes { get; set; }
        public virtual DbSet<ViewAsignacionesSaldo> ViewAsignacionesSaldo { get; set; }
        public virtual DbSet<ViewBloquesUbicacion> ViewBloquesUbicacion { get; set; }
        public virtual DbSet<ViewConsolidadoBloques> ViewConsolidadoBloques { get; set; }
        public virtual DbSet<ViewConsolidadoUbicaciones> ViewConsolidadoUbicaciones { get; set; }
        public virtual DbSet<ViewDashboard1> ViewDashboard1 { get; set; }
        public virtual DbSet<ViewDepartamentosMunicipios> ViewDepartamentosMunicipios { get; set; }
        public virtual DbSet<ViewGraficoPagos> ViewGraficoPagos { get; set; }
        public virtual DbSet<ViewLotes> ViewLotes { get; set; }
        public virtual DbSet<ViewPagosAsignaciones> ViewPagosAsignaciones { get; set; }
        public virtual DbSet<ViewReporteMorosos> ViewReporteMorosos { get; set; }
        public virtual DbSet<ViewReportePlanPago> ViewReportePlanPago { get; set; }
        public virtual DbSet<ViewReporteTicketPago> ViewReporteTicketPago { get; set; }
        public virtual DbSet<ViewTotalAbonadoAsignaciones> ViewTotalAbonadoAsignaciones { get; set; }
        public virtual DbSet<ViewUsuariosSistema> ViewUsuariosSistema { get; set; }
        public virtual DbSet<VwAspnetApplications> VwAspnetApplications { get; set; }
        public virtual DbSet<VwAspnetMembershipUsers> VwAspnetMembershipUsers { get; set; }
        public virtual DbSet<VwAspnetProfiles> VwAspnetProfiles { get; set; }
        public virtual DbSet<VwAspnetRoles> VwAspnetRoles { get; set; }
        public virtual DbSet<VwAspnetUsers> VwAspnetUsers { get; set; }
        public virtual DbSet<VwAspnetUsersInRoles> VwAspnetUsersInRoles { get; set; }
        public virtual DbSet<VwAspnetWebPartStatePaths> VwAspnetWebPartStatePaths { get; set; }
        public virtual DbSet<VwAspnetWebPartStateShared> VwAspnetWebPartStateShared { get; set; }
        public virtual DbSet<VwAspnetWebPartStateUser> VwAspnetWebPartStateUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-R6CMHVH;Database=PayLots;Trusted_Connection=True;MultipleActiveResultSets=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asignaciones>(entity =>
            {
                entity.HasKey(e => e.IdAsignacion);

                entity.Property(e => e.CuotaMinima).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Far)
                    .HasColumnName("FAR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaInicioPago).HasColumnType("smalldatetime");

                entity.Property(e => e.Fua)
                    .HasColumnName("FUA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.MontoTotal).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Prima).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TasaInteres).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Uar)
                    .IsRequired()
                    .HasColumnName("UAR");

                entity.Property(e => e.Uua)
                    .IsRequired()
                    .HasColumnName("UUA");

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

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles1>(entity =>
            {
                entity.ToTable("AspNetRoles");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers1>(entity =>
            {
                entity.ToTable("AspNetUsers");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspnetApplications>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK__aspnet_A__C93A4C98A944788B")
                    .IsClustered(false);

                entity.ToTable("aspnet_Applications");

                entity.HasIndex(e => e.ApplicationName)
                    .HasName("UQ__aspnet_A__30910331D5193993")
                    .IsUnique();

                entity.HasIndex(e => e.LoweredApplicationName)
                    .HasName("UQ__aspnet_A__17477DE473C17A67")
                    .IsUnique();

                entity.Property(e => e.ApplicationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspnetMembership>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_M__1788CC4D6D0B4B87")
                    .IsClustered(false);

                entity.ToTable("aspnet_Membership");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredEmail).HasMaxLength(256);

                entity.Property(e => e.MobilePin)
                    .HasColumnName("MobilePIN")
                    .HasMaxLength(16);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetMembership)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__Appli__6D0D32F4");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetMembership)
                    .HasForeignKey<AspnetMembership>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__UserI__6EF57B66");
            });

            modelBuilder.Entity<AspnetPaths>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("PK__aspnet_P__CD67DC5817BEF13A")
                    .IsClustered(false);

                entity.ToTable("aspnet_Paths");

                entity.Property(e => e.PathId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LoweredPath)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetPaths)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pa__Appli__6FE99F9F");
            });

            modelBuilder.Entity<AspnetPersonalizationAllUsers>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("PK__aspnet_P__CD67DC599A9AC319");

                entity.ToTable("aspnet_PersonalizationAllUsers");

                entity.Property(e => e.PathId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PageSettings)
                    .IsRequired()
                    .HasColumnType("image");

                entity.HasOne(d => d.Path)
                    .WithOne(p => p.AspnetPersonalizationAllUsers)
                    .HasForeignKey<AspnetPersonalizationAllUsers>(d => d.PathId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pe__PathI__70DDC3D8");
            });

            modelBuilder.Entity<AspnetPersonalizationPerUser>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__aspnet_P__3214EC06DDEA9310")
                    .IsClustered(false);

                entity.ToTable("aspnet_PersonalizationPerUser");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PageSettings)
                    .IsRequired()
                    .HasColumnType("image");

                entity.HasOne(d => d.Path)
                    .WithMany(p => p.AspnetPersonalizationPerUser)
                    .HasForeignKey(d => d.PathId)
                    .HasConstraintName("FK__aspnet_Pe__PathI__71D1E811");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetPersonalizationPerUser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__aspnet_Pe__UserI__72C60C4A");
            });

            modelBuilder.Entity<AspnetProfile>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_P__1788CC4C2F93D8AB");

                entity.ToTable("aspnet_Profile");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PropertyNames)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.PropertyValuesBinary)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.PropertyValuesString)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetProfile)
                    .HasForeignKey<AspnetProfile>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pr__UserI__73BA3083");
            });

            modelBuilder.Entity<AspnetRoles>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__aspnet_R__8AFACE1BB751397C")
                    .IsClustered(false);

                entity.ToTable("aspnet_Roles");

                entity.Property(e => e.RoleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetRoles)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Ro__Appli__74AE54BC");
            });

            modelBuilder.Entity<AspnetSchemaVersions>(entity =>
            {
                entity.HasKey(e => new { e.Feature, e.CompatibleSchemaVersion })
                    .HasName("PK__aspnet_S__5A1E6BC1A7BF36D8");

                entity.ToTable("aspnet_SchemaVersions");

                entity.Property(e => e.Feature).HasMaxLength(128);

                entity.Property(e => e.CompatibleSchemaVersion).HasMaxLength(128);
            });

            modelBuilder.Entity<AspnetUsers>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_U__1788CC4D57AEF7FD")
                    .IsClustered(false);

                entity.ToTable("aspnet_Users");

                entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetUsers)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__Appli__75A278F5");
            });

            modelBuilder.Entity<AspnetUsersInRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK__aspnet_U__AF2760AD201C749D");

                entity.ToTable("aspnet_UsersInRoles");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspnetUsersInRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__RoleI__76969D2E");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetUsersInRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__UserI__778AC167");
            });

            modelBuilder.Entity<AspnetWebEventEvents>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK__aspnet_W__7944C810FE03D5B7");

                entity.ToTable("aspnet_WebEvent_Events");

                entity.Property(e => e.EventId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ApplicationPath).HasMaxLength(256);

                entity.Property(e => e.ApplicationVirtualPath).HasMaxLength(256);

                entity.Property(e => e.Details).HasColumnType("ntext");

                entity.Property(e => e.EventOccurrence).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.EventSequence).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.EventTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.EventType)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ExceptionType).HasMaxLength(256);

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Message).HasMaxLength(1024);

                entity.Property(e => e.RequestUrl).HasMaxLength(1024);
            });

            modelBuilder.Entity<Beneficiarios>(entity =>
            {
                entity.HasKey(e => e.IdBeneficiario);

                entity.Property(e => e.Far)
                    .HasColumnName("FAR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Fua)
                    .HasColumnName("FUA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NombreCompleto).IsRequired();

                entity.Property(e => e.Uar)
                    .IsRequired()
                    .HasColumnName("UAR");

                entity.Property(e => e.Uua)
                    .IsRequired()
                    .HasColumnName("UUA");
            });

            modelBuilder.Entity<Bloques>(entity =>
            {
                entity.HasKey(e => e.IdBloque);

                entity.Property(e => e.Bloque)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Far)
                    .HasColumnName("FAR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Fua)
                    .HasColumnName("FUA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Uar)
                    .IsRequired()
                    .HasColumnName("UAR");

                entity.Property(e => e.Uua)
                    .IsRequired()
                    .HasColumnName("UUA");

                entity.HasOne(d => d.IdUbicacionNavigation)
                    .WithMany(p => p.Bloques)
                    .HasForeignKey(d => d.IdUbicacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bloques_Ubicaciones");
            });

            modelBuilder.Entity<CatalogoDepartamentos>(entity =>
            {
                entity.HasKey(e => e.DepartamentoId);

                entity.ToTable("Catalogo_Departamentos");

                entity.Property(e => e.DepartamentoId).HasColumnName("Departamento_Id");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Far)
                    .HasColumnName("FAR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Fua)
                    .HasColumnName("FUA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Uar)
                    .IsRequired()
                    .HasColumnName("UAR")
                    .HasMaxLength(50);

                entity.Property(e => e.Uua)
                    .IsRequired()
                    .HasColumnName("UUA")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CatalogoMunicipios>(entity =>
            {
                entity.HasKey(e => e.MunicipioId);

                entity.ToTable("Catalogo_Municipios");

                entity.Property(e => e.MunicipioId).HasColumnName("Municipio_Id");

                entity.Property(e => e.DepartamentoId).HasColumnName("Departamento_Id");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Far)
                    .HasColumnName("FAR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Fua)
                    .HasColumnName("FUA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Uar)
                    .IsRequired()
                    .HasColumnName("UAR")
                    .HasMaxLength(50);

                entity.Property(e => e.Uua)
                    .IsRequired()
                    .HasColumnName("UUA")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Departamento)
                    .WithMany(p => p.CatalogoMunicipios)
                    .HasForeignKey(d => d.DepartamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Catalogo_Municipios_Catalogo_Departamentos");
            });

            modelBuilder.Entity<CatalogoPreguntas>(entity =>
            {
                entity.HasKey(e => e.IdCatalogoPregunta);

                entity.ToTable("Catalogo_Preguntas");

                entity.Property(e => e.Far)
                    .HasColumnName("FAR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Pregunta).IsRequired();

                entity.Property(e => e.Uar)
                    .HasColumnName("UAR")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Consulta>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Area).HasColumnName("AREA");

                entity.Property(e => e.Beneficiario)
                    .HasColumnName("BENEFICIARIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Bloque)
                    .HasColumnName("BLOQUE")
                    .HasMaxLength(255);

                entity.Property(e => e.Cedula)
                    .HasColumnName("CEDULA")
                    .HasMaxLength(255);

                entity.Property(e => e.Culminacion).HasColumnName("CULMINACION");

                entity.Property(e => e.Cuota).HasColumnName("CUOTA");

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(255);

                entity.Property(e => e.Donado)
                    .HasColumnName("DONADO")
                    .HasMaxLength(255);

                entity.Property(e => e.Errores)
                    .HasColumnName("ERRORES")
                    .HasMaxLength(255);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Fecha1).HasColumnType("datetime");

                entity.Property(e => e.Fecha10).HasColumnType("datetime");

                entity.Property(e => e.Fecha11).HasColumnType("datetime");

                entity.Property(e => e.Fecha12).HasColumnType("datetime");

                entity.Property(e => e.Fecha13).HasMaxLength(255);

                entity.Property(e => e.Fecha14).HasMaxLength(255);

                entity.Property(e => e.Fecha15).HasMaxLength(255);

                entity.Property(e => e.Fecha2).HasColumnType("datetime");

                entity.Property(e => e.Fecha3).HasColumnType("datetime");

                entity.Property(e => e.Fecha4).HasColumnType("datetime");

                entity.Property(e => e.Fecha5).HasColumnType("datetime");

                entity.Property(e => e.Fecha6).HasColumnType("datetime");

                entity.Property(e => e.Fecha7).HasColumnType("datetime");

                entity.Property(e => e.Fecha8).HasColumnType("datetime");

                entity.Property(e => e.Fecha9).HasColumnType("datetime");

                entity.Property(e => e.Fechainiciopago)
                    .HasColumnName("FECHAINICIOPAGO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Grupo)
                    .HasColumnName("GRUPO")
                    .HasMaxLength(255);

                entity.Property(e => e.Lote)
                    .HasColumnName("LOTE")
                    .HasMaxLength(255);

                entity.Property(e => e.Monto13).HasMaxLength(255);

                entity.Property(e => e.Monto14).HasMaxLength(255);

                entity.Property(e => e.Monto15).HasMaxLength(255);

                entity.Property(e => e.PlazoDeterminado)
                    .HasColumnName("PLAZO DETERMINADO ")
                    .HasMaxLength(255);

                entity.Property(e => e.Recaudado)
                    .HasColumnName("RECAUDADO")
                    .HasMaxLength(255);

                entity.Property(e => e.Recibo).HasMaxLength(255);

                entity.Property(e => e.Recibo1).HasMaxLength(255);

                entity.Property(e => e.Recibo10).HasMaxLength(255);

                entity.Property(e => e.Recibo11).HasMaxLength(255);

                entity.Property(e => e.Recibo12).HasMaxLength(255);

                entity.Property(e => e.Recibo13).HasMaxLength(255);

                entity.Property(e => e.Recibo14).HasMaxLength(255);

                entity.Property(e => e.Recibo15).HasMaxLength(255);

                entity.Property(e => e.Recibo2).HasMaxLength(255);

                entity.Property(e => e.Recibo3).HasMaxLength(255);

                entity.Property(e => e.Recibo4).HasMaxLength(255);

                entity.Property(e => e.Recibo5).HasMaxLength(255);

                entity.Property(e => e.Recibo6).HasMaxLength(255);

                entity.Property(e => e.Recibo7).HasMaxLength(255);

                entity.Property(e => e.Recibo8).HasMaxLength(255);

                entity.Property(e => e.Recibo9).HasMaxLength(255);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(255);

                entity.Property(e => e.Total).HasColumnName("TOTAL");

                entity.Property(e => e.Total1).HasColumnName("TOTAL1");
            });

            modelBuilder.Entity<ControlAccesoUsuarios>(entity =>
            {
                entity.HasKey(e => e.IdLogueo);

                entity.ToTable("Control_Acceso_Usuarios");

                entity.Property(e => e.Far)
                    .HasColumnName("FAR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Pc).HasColumnName("PC");

                entity.Property(e => e.SesionId).HasColumnName("Sesion_Id");
            });

            modelBuilder.Entity<DatosEmpresa>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DatosEmpresaId).ValueGeneratedOnAdd();

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Far)
                    .HasColumnName("FAR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Fua)
                    .HasColumnName("FUA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Logo).HasColumnType("image");

                entity.Property(e => e.Ruc).HasMaxLength(100);

                entity.Property(e => e.Telefono).HasMaxLength(50);

                entity.Property(e => e.Uar)
                    .HasColumnName("UAR")
                    .HasMaxLength(50);

                entity.Property(e => e.Uua)
                    .HasColumnName("UUA")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ErrorSql>(entity =>
            {
                entity.HasKey(e => e.IdErrorSql);

                entity.ToTable("ErrorSQL");

                entity.Property(e => e.IdErrorSql).HasColumnName("IdErrorSQL");

                entity.Property(e => e.ErrorSql1)
                    .IsRequired()
                    .HasColumnName("ErrorSQL");

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdentityUser).IsRequired();
            });

            modelBuilder.Entity<ErroresSistema>(entity =>
            {
                entity.HasKey(e => e.IdErrorSistema);

                entity.Property(e => e.CodError).IsRequired();

                entity.Property(e => e.Error).IsRequired();

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Pantalla).IsRequired();

                entity.Property(e => e.Usuario).IsRequired();
            });

            modelBuilder.Entity<Importacion>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Area)
                    .HasColumnName("AREA")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Beneficiario).HasColumnName("BENEFICIARIO");

                entity.Property(e => e.Bloque).HasColumnName("BLOQUE");

                entity.Property(e => e.Cedula).HasColumnName("CEDULA");

                entity.Property(e => e.Costototal)
                    .HasColumnName("COSTOTOTAL")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Culminacion)
                    .HasColumnName("CULMINACION")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Cuota)
                    .HasColumnName("CUOTA")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Direccion).HasColumnName("DIRECCION");

                entity.Property(e => e.Donado).HasColumnName("DONADO");

                entity.Property(e => e.Errores).HasColumnName("ERRORES");

                entity.Property(e => e.FechaAbr2019)
                    .HasColumnName("FechaABR2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaAgo2019)
                    .HasColumnName("FechaAGO2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaDic2018)
                    .HasColumnName("FechaDIC2018")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaDic2019)
                    .HasColumnName("FechaDIC2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaEne2019)
                    .HasColumnName("FechaENE2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaFeb2019)
                    .HasColumnName("FechaFEB2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaJul2019)
                    .HasColumnName("FechaJUL2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaJun2019)
                    .HasColumnName("FechaJUN2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaMar2019)
                    .HasColumnName("FechaMAR2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaMay2019)
                    .HasColumnName("FechaMAY2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaNov2018)
                    .HasColumnName("FechaNOV2018")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaNov2019)
                    .HasColumnName("FechaNOV2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaOct2018)
                    .HasColumnName("FechaOCT2018")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaOct2019)
                    .HasColumnName("FechaOCT2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaSep2018)
                    .HasColumnName("FechaSEP2018")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaSep2019)
                    .HasColumnName("FechaSEP2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fechainiciopago)
                    .HasColumnName("FECHAINICIOPAGO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Grupo).HasColumnName("GRUPO");

                entity.Property(e => e.Lote).HasColumnName("LOTE");

                entity.Property(e => e.MontoAbr2019)
                    .HasColumnName("MontoABR2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoAgo2019)
                    .HasColumnName("MontoAGO2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoDic2018)
                    .HasColumnName("MontoDIC2018")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoDic2019)
                    .HasColumnName("MontoDIC2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoEne2019)
                    .HasColumnName("MontoENE2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoFeb2019)
                    .HasColumnName("MontoFEB2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoJul2019)
                    .HasColumnName("MontoJUL2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoJun2019)
                    .HasColumnName("MontoJUN2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoMar2019)
                    .HasColumnName("MontoMAR2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoMay2019)
                    .HasColumnName("MontoMAY2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoNov2018)
                    .HasColumnName("MontoNOV2018")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoNov2019)
                    .HasColumnName("MontoNOV2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoOct2018)
                    .HasColumnName("MontoOCT2018")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoOct2019).HasColumnName("MontoOCT2019");

                entity.Property(e => e.MontoSep2018)
                    .HasColumnName("MontoSEP2018")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoSep2019)
                    .HasColumnName("MontoSEP2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PlazoDeterminado).HasColumnName("PLAZO DETERMINADO ");

                entity.Property(e => e.Recaudado).HasColumnName("RECAUDADO");

                entity.Property(e => e.ReciboAbr2019).HasColumnName("ReciboABR2019");

                entity.Property(e => e.ReciboAgo2019).HasColumnName("ReciboAGO2019");

                entity.Property(e => e.ReciboDic2018).HasColumnName("ReciboDIC2018");

                entity.Property(e => e.ReciboDic2019).HasColumnName("ReciboDIC2019");

                entity.Property(e => e.ReciboEne2019).HasColumnName("ReciboENE2019");

                entity.Property(e => e.ReciboFeb2019).HasColumnName("ReciboFEB2019");

                entity.Property(e => e.ReciboJul2019).HasColumnName("ReciboJUL2019");

                entity.Property(e => e.ReciboJun2019).HasColumnName("ReciboJUN2019");

                entity.Property(e => e.ReciboMar2019).HasColumnName("ReciboMAR2019");

                entity.Property(e => e.ReciboMay2019).HasColumnName("ReciboMAY2019");

                entity.Property(e => e.ReciboNov2018).HasColumnName("ReciboNOV2018");

                entity.Property(e => e.ReciboNov2019).HasColumnName("ReciboNOV2019");

                entity.Property(e => e.ReciboOct2018).HasColumnName("ReciboOCT2018");

                entity.Property(e => e.ReciboOct2019).HasColumnName("ReciboOCT2019");

                entity.Property(e => e.ReciboSep2018).HasColumnName("ReciboSEP2018");

                entity.Property(e => e.ReciboSep2019).HasColumnName("ReciboSEP2019");

                entity.Property(e => e.Telefono).HasColumnName("TELEFONO");

                entity.Property(e => e.Total1)
                    .HasColumnName("TOTAL1")
                    .HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<Importacion2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Area)
                    .HasColumnName("AREA")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Beneficiario).HasColumnName("BENEFICIARIO");

                entity.Property(e => e.Bloque).HasColumnName("BLOQUE");

                entity.Property(e => e.Cedula).HasColumnName("CEDULA");

                entity.Property(e => e.Costototal)
                    .HasColumnName("COSTOTOTAL")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Culminacion)
                    .HasColumnName("CULMINACION")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Cuota)
                    .HasColumnName("CUOTA")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Direccion).HasColumnName("DIRECCION");

                entity.Property(e => e.Donado).HasColumnName("DONADO");

                entity.Property(e => e.Errores).HasColumnName("ERRORES");

                entity.Property(e => e.FechaAbr2019)
                    .HasColumnName("FechaABR2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaAgo2019)
                    .HasColumnName("FechaAGO2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaDic2018)
                    .HasColumnName("FechaDIC2018")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaDic2019)
                    .HasColumnName("FechaDIC2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaEne2019)
                    .HasColumnName("FechaENE2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaFeb2019)
                    .HasColumnName("FechaFEB2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaJul2019)
                    .HasColumnName("FechaJUL2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaJun2019)
                    .HasColumnName("FechaJUN2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaMar2019)
                    .HasColumnName("FechaMAR2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaMay2019)
                    .HasColumnName("FechaMAY2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaNov2018)
                    .HasColumnName("FechaNOV2018")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaNov2019)
                    .HasColumnName("FechaNOV2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaOct2018)
                    .HasColumnName("FechaOCT2018")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaOct2019)
                    .HasColumnName("FechaOCT2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaSep2018)
                    .HasColumnName("FechaSEP2018")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaSep2019)
                    .HasColumnName("FechaSEP2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fechainiciopago)
                    .HasColumnName("FECHAINICIOPAGO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Grupo).HasColumnName("GRUPO");

                entity.Property(e => e.Lote).HasColumnName("LOTE");

                entity.Property(e => e.MontoAbr2019)
                    .HasColumnName("MontoABR2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoAgo2019)
                    .HasColumnName("MontoAGO2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoDic2018)
                    .HasColumnName("MontoDIC2018")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoDic2019)
                    .HasColumnName("MontoDIC2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoEne2019)
                    .HasColumnName("MontoENE2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoFeb2019)
                    .HasColumnName("MontoFEB2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoJul2019)
                    .HasColumnName("MontoJUL2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoJun2019)
                    .HasColumnName("MontoJUN2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoMar2019)
                    .HasColumnName("MontoMAR2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoMay2019)
                    .HasColumnName("MontoMAY2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoNov2018)
                    .HasColumnName("MontoNOV2018")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoNov2019)
                    .HasColumnName("MontoNOV2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoOct2018)
                    .HasColumnName("MontoOCT2018")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoOct2019).HasColumnName("MontoOCT2019");

                entity.Property(e => e.MontoSep2018)
                    .HasColumnName("MontoSEP2018")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoSep2019)
                    .HasColumnName("MontoSEP2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PlazoDeterminado).HasColumnName("PLAZO DETERMINADO ");

                entity.Property(e => e.Recaudado).HasColumnName("RECAUDADO");

                entity.Property(e => e.ReciboAbr2019).HasColumnName("ReciboABR2019");

                entity.Property(e => e.ReciboAgo2019).HasColumnName("ReciboAGO2019");

                entity.Property(e => e.ReciboDic2018).HasColumnName("ReciboDIC2018");

                entity.Property(e => e.ReciboDic2019).HasColumnName("ReciboDIC2019");

                entity.Property(e => e.ReciboEne2019).HasColumnName("ReciboENE2019");

                entity.Property(e => e.ReciboFeb2019).HasColumnName("ReciboFEB2019");

                entity.Property(e => e.ReciboJul2019).HasColumnName("ReciboJUL2019");

                entity.Property(e => e.ReciboJun2019).HasColumnName("ReciboJUN2019");

                entity.Property(e => e.ReciboMar2019).HasColumnName("ReciboMAR2019");

                entity.Property(e => e.ReciboMay2019).HasColumnName("ReciboMAY2019");

                entity.Property(e => e.ReciboNov2018).HasColumnName("ReciboNOV2018");

                entity.Property(e => e.ReciboNov2019).HasColumnName("ReciboNOV2019");

                entity.Property(e => e.ReciboOct2018).HasColumnName("ReciboOCT2018");

                entity.Property(e => e.ReciboOct2019).HasColumnName("ReciboOCT2019");

                entity.Property(e => e.ReciboSep2018).HasColumnName("ReciboSEP2018");

                entity.Property(e => e.ReciboSep2019).HasColumnName("ReciboSEP2019");

                entity.Property(e => e.Telefono).HasColumnName("TELEFONO");

                entity.Property(e => e.Total1)
                    .HasColumnName("TOTAL1")
                    .HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<Importacion3>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Area)
                    .HasColumnName("AREA")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Beneficiario).HasColumnName("BENEFICIARIO");

                entity.Property(e => e.Bloque).HasColumnName("BLOQUE");

                entity.Property(e => e.Cedula).HasColumnName("CEDULA");

                entity.Property(e => e.Costototal)
                    .HasColumnName("COSTOTOTAL")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Culminacion)
                    .HasColumnName("CULMINACION")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Cuota)
                    .HasColumnName("CUOTA")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Direccion).HasColumnName("DIRECCION");

                entity.Property(e => e.Donado).HasColumnName("DONADO");

                entity.Property(e => e.Errores).HasColumnName("ERRORES");

                entity.Property(e => e.FechaAbr2019)
                    .HasColumnName("FechaABR2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaAgo2019)
                    .HasColumnName("FechaAGO2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaDic2018)
                    .HasColumnName("FechaDIC2018")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaDic2019)
                    .HasColumnName("FechaDIC2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaEne2019)
                    .HasColumnName("FechaENE2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaFeb2019)
                    .HasColumnName("FechaFEB2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaJul2019)
                    .HasColumnName("FechaJUL2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaJun2019)
                    .HasColumnName("FechaJUN2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaMar2019)
                    .HasColumnName("FechaMAR2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaMay2019)
                    .HasColumnName("FechaMAY2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaNov2018)
                    .HasColumnName("FechaNOV2018")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaNov2019)
                    .HasColumnName("FechaNOV2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaOct2018)
                    .HasColumnName("FechaOCT2018")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaOct2019)
                    .HasColumnName("FechaOCT2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaSep2018)
                    .HasColumnName("FechaSEP2018")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaSep2019)
                    .HasColumnName("FechaSEP2019")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fechainiciopago)
                    .HasColumnName("FECHAINICIOPAGO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Grupo).HasColumnName("GRUPO");

                entity.Property(e => e.Lote).HasColumnName("LOTE");

                entity.Property(e => e.MontoAbr2019)
                    .HasColumnName("MontoABR2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoAgo2019)
                    .HasColumnName("MontoAGO2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoDic2018)
                    .HasColumnName("MontoDIC2018")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoDic2019)
                    .HasColumnName("MontoDIC2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoEne2019)
                    .HasColumnName("MontoENE2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoFeb2019)
                    .HasColumnName("MontoFEB2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoJul2019)
                    .HasColumnName("MontoJUL2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoJun2019)
                    .HasColumnName("MontoJUN2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoMar2019)
                    .HasColumnName("MontoMAR2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoMay2019)
                    .HasColumnName("MontoMAY2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoNov2018)
                    .HasColumnName("MontoNOV2018")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoNov2019)
                    .HasColumnName("MontoNOV2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoOct2018)
                    .HasColumnName("MontoOCT2018")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoOct2019).HasColumnName("MontoOCT2019");

                entity.Property(e => e.MontoSep2018)
                    .HasColumnName("MontoSEP2018")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoSep2019)
                    .HasColumnName("MontoSEP2019")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PlazoDeterminado).HasColumnName("PLAZO DETERMINADO ");

                entity.Property(e => e.Recaudado).HasColumnName("RECAUDADO");

                entity.Property(e => e.ReciboAbr2019).HasColumnName("ReciboABR2019");

                entity.Property(e => e.ReciboAgo2019).HasColumnName("ReciboAGO2019");

                entity.Property(e => e.ReciboDic2018).HasColumnName("ReciboDIC2018");

                entity.Property(e => e.ReciboDic2019).HasColumnName("ReciboDIC2019");

                entity.Property(e => e.ReciboEne2019).HasColumnName("ReciboENE2019");

                entity.Property(e => e.ReciboFeb2019).HasColumnName("ReciboFEB2019");

                entity.Property(e => e.ReciboJul2019).HasColumnName("ReciboJUL2019");

                entity.Property(e => e.ReciboJun2019).HasColumnName("ReciboJUN2019");

                entity.Property(e => e.ReciboMar2019).HasColumnName("ReciboMAR2019");

                entity.Property(e => e.ReciboMay2019).HasColumnName("ReciboMAY2019");

                entity.Property(e => e.ReciboNov2018).HasColumnName("ReciboNOV2018");

                entity.Property(e => e.ReciboNov2019).HasColumnName("ReciboNOV2019");

                entity.Property(e => e.ReciboOct2018).HasColumnName("ReciboOCT2018");

                entity.Property(e => e.ReciboOct2019).HasColumnName("ReciboOCT2019");

                entity.Property(e => e.ReciboSep2018).HasColumnName("ReciboSEP2018");

                entity.Property(e => e.ReciboSep2019).HasColumnName("ReciboSEP2019");

                entity.Property(e => e.Telefono).HasColumnName("TELEFONO");

                entity.Property(e => e.Total1)
                    .HasColumnName("TOTAL1")
                    .HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<Lotes>(entity =>
            {
                entity.HasKey(e => e.IdLote);

                entity.Property(e => e.Area).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Far)
                    .HasColumnName("FAR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Fua)
                    .HasColumnName("FUA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NumeroLote)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Uar).HasColumnName("UAR");

                entity.Property(e => e.Uua).HasColumnName("UUA");

                entity.HasOne(d => d.IdBloqueNavigation)
                    .WithMany(p => p.Lotes)
                    .HasForeignKey(d => d.IdBloque)
                    .HasConstraintName("FK_Lotes_Bloques");
            });

            modelBuilder.Entity<Mora>(entity =>
            {
                entity.HasKey(e => e.IdMora);

                entity.Property(e => e.Far)
                    .HasColumnName("FAR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Fua)
                    .HasColumnName("FUA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Porcentaje).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Uar)
                    .HasColumnName("UAR")
                    .HasMaxLength(50);

                entity.Property(e => e.Uua)
                    .HasColumnName("UUA")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Morosos>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FechaGenerado).HasColumnType("smalldatetime");

                entity.Property(e => e.InteresAcumulado).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoCuotasVencidas).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MoraAcumulada).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<Pagos>(entity =>
            {
                entity.HasKey(e => e.IdPago);

                entity.Property(e => e.Far)
                    .HasColumnName("FAR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaRecibo).HasColumnType("smalldatetime");

                entity.Property(e => e.Fua)
                    .HasColumnName("FUA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Interés).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MesPagado).IsRequired();

                entity.Property(e => e.Moneda).HasMaxLength(50);

                entity.Property(e => e.MontoEfectivo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoPago).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Mora).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TasaCambio).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Uar)
                    .IsRequired()
                    .HasColumnName("UAR");

                entity.Property(e => e.Uua)
                    .IsRequired()
                    .HasColumnName("UUA");

                entity.HasOne(d => d.IdAsignacionNavigation)
                    .WithMany(p => p.Pagos)
                    .HasForeignKey(d => d.IdAsignacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pagos_Asignaciones");
            });

            modelBuilder.Entity<Proformas>(entity =>
            {
                entity.HasKey(e => e.IdProforma);

                entity.Property(e => e.Area).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Cuota).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Far)
                    .HasColumnName("FAR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Financiar).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Fua)
                    .HasColumnName("FUA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.InteresAcumulado).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Lote).HasMaxLength(50);

                entity.Property(e => e.PrecioVara).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Prima).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Total).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotalApagar)
                    .HasColumnName("TotalAPagar")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Uar)
                    .IsRequired()
                    .HasColumnName("UAR");

                entity.Property(e => e.Uua)
                    .IsRequired()
                    .HasColumnName("UUA");
            });

            modelBuilder.Entity<Seguimientos>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Far)
                    .HasColumnName("FAR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdSeguimiento).ValueGeneratedOnAdd();

                entity.Property(e => e.IndexSql).HasColumnName("IndexSQL");

                entity.Property(e => e.Observaciones).IsRequired();

                entity.Property(e => e.Tipo).IsRequired();

                entity.Property(e => e.Uar)
                    .HasColumnName("UAR")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Ubicaciones>(entity =>
            {
                entity.HasKey(e => e.IdUbicacion);

                entity.Property(e => e.Direccion).IsRequired();

                entity.Property(e => e.Far)
                    .HasColumnName("FAR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Fua)
                    .HasColumnName("FUA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdMunicipio).HasColumnName("Id_Municipio");

                entity.Property(e => e.Uar)
                    .IsRequired()
                    .HasColumnName("UAR");

                entity.Property(e => e.Uua)
                    .IsRequired()
                    .HasColumnName("UUA");
            });

            modelBuilder.Entity<ViewAsignacionesLotes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Asignaciones_Lotes");

                entity.Property(e => e.Area).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CuotaMinima).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Departamento)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.FechaInicioPago).HasColumnType("smalldatetime");

                entity.Property(e => e.MontoTotal).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.NombreCompleto).IsRequired();

                entity.Property(e => e.NombreLote).HasMaxLength(81);

                entity.Property(e => e.Prima).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TasaInteres).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<ViewAsignacionesSaldo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Asignaciones_Saldo");

                entity.Property(e => e.Abonado).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.CuotaMinima).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Departamento)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.FechaInicioPago).HasColumnType("smalldatetime");

                entity.Property(e => e.MontoTotal).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.NombreCompleto).IsRequired();

                entity.Property(e => e.NombreLote).HasMaxLength(81);

                entity.Property(e => e.Prima).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Saldo).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.TasaInteres).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<ViewBloquesUbicacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Bloques_Ubicacion");

                entity.Property(e => e.Bloque).IsRequired();

                entity.Property(e => e.Departamento)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Direccion).IsRequired();

                entity.Property(e => e.IdMunicipio).HasColumnName("Id_Municipio");

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<ViewConsolidadoBloques>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Consolidado_Bloques");

                entity.Property(e => e.Bloque)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Direccion).IsRequired();

                entity.Property(e => e.IdMunicipio).HasColumnName("Id_Municipio");
            });

            modelBuilder.Entity<ViewConsolidadoUbicaciones>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Consolidado_Ubicaciones");

                entity.Property(e => e.Direccion).IsRequired();

                entity.Property(e => e.IdMunicipio).HasColumnName("Id_Municipio");
            });

            modelBuilder.Entity<ViewDashboard1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Dashboard_1");

                entity.Property(e => e.Bloque)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Far)
                    .HasColumnName("FAR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.MesPagado).IsRequired();

                entity.Property(e => e.MontoTotal).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NombreLote).IsRequired();

                entity.Property(e => e.Pagado).HasColumnType("numeric(20, 2)");

                entity.Property(e => e.Saldo).HasColumnType("numeric(38, 2)");
            });

            modelBuilder.Entity<ViewDepartamentosMunicipios>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Departamentos_Municipios");

                entity.Property(e => e.Departamento)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.DepartamentoId).HasColumnName("Departamento_Id");

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.MunicipioId).HasColumnName("Municipio_Id");
            });

            modelBuilder.Entity<ViewGraficoPagos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_GraficoPagos");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Pagado).HasColumnType("numeric(38, 2)");
            });

            modelBuilder.Entity<ViewLotes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Lotes");

                entity.Property(e => e.Area).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Bloque)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Departamento)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.IdMunicipio).HasColumnName("Id_Municipio");

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.NombreLote).HasMaxLength(81);

                entity.Property(e => e.NumeroLote)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ViewPagosAsignaciones>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Pagos_Asignaciones");

                entity.Property(e => e.Abonado).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.FechaRecibo).HasColumnType("smalldatetime");

                entity.Property(e => e.Interés).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Moneda).HasMaxLength(50);

                entity.Property(e => e.MontoEfectivo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoPago).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoTotal).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Mora).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NombreCompleto).IsRequired();

                entity.Property(e => e.NombreLote).HasMaxLength(81);

                entity.Property(e => e.NumeroRecibo).IsRequired();

                entity.Property(e => e.Observaciones).IsRequired();

                entity.Property(e => e.Prima).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Saldo).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.TasaCambio).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotalRecibo).HasColumnType("numeric(20, 2)");
            });

            modelBuilder.Entity<ViewReporteMorosos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Reporte_Morosos");

                entity.Property(e => e.Beneficiario).IsRequired();

                entity.Property(e => e.FechaInicioPago).HasColumnType("smalldatetime");

                entity.Property(e => e.NombreLote).HasMaxLength(81);
            });

            modelBuilder.Entity<ViewReportePlanPago>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Reporte_PlanPago");

                entity.Property(e => e.AreaLote).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FechaCuota).HasColumnType("smalldatetime");

                entity.Property(e => e.Interes).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoMinimo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoPagado).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Mora).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Prima).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Saldo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SaldoInicial).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Total).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotalPagar).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<ViewReporteTicketPago>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Reporte_TicketPago");

                entity.Property(e => e.Cajero).IsRequired();

                entity.Property(e => e.FechaRecibo).HasColumnType("smalldatetime");

                entity.Property(e => e.Interes).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MesPagado).IsRequired();

                entity.Property(e => e.MontoPago).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Mora).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Prima).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Saldo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SaldoInicial).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotalPagar).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<ViewTotalAbonadoAsignaciones>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Total_Abonado_Asignaciones");

                entity.Property(e => e.Abonado).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.NumeroLote)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ViewUsuariosSistema>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Usuarios_Sistema");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetApplications>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Applications");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetMembershipUsers>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_MembershipUsers");

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredEmail).HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.MobilePin)
                    .HasColumnName("MobilePIN")
                    .HasMaxLength(16);

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetProfiles>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Profiles");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwAspnetRoles>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Roles");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetUsers>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Users");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetUsersInRoles>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_UsersInRoles");
            });

            modelBuilder.Entity<VwAspnetWebPartStatePaths>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_Paths");

                entity.Property(e => e.LoweredPath)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetWebPartStateShared>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_Shared");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwAspnetWebPartStateUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_User");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
