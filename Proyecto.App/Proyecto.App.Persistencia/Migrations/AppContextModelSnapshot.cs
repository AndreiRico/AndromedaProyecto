﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto.App.Persistencia;

namespace Proyecto.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Proyecto.App.Dominio.Apellidos", b =>
                {
                    b.Property<int>("apellidosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("apellidosId");

                    b.ToTable("apellidos");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.Direccion", b =>
                {
                    b.Property<int>("direccionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("tipoVivienda")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("direccionId");

                    b.ToTable("direccion");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.Documento", b =>
                {
                    b.Property<int>("documentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("documentoId");

                    b.HasIndex("Descripcion")
                        .IsUnique();

                    b.ToTable("documento");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.Email", b =>
                {
                    b.Property<int>("emailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("emailId");

                    b.ToTable("email");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.Genero", b =>
                {
                    b.Property<int>("generoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("generoId");

                    b.ToTable("genero");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.Nombres", b =>
                {
                    b.Property<int>("nombresId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("nombresId");

                    b.ToTable("nombres");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.RH", b =>
                {
                    b.Property<int>("rhId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.HasKey("rhId");

                    b.ToTable("rh");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.Telefono", b =>
                {
                    b.Property<int>("telefonoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("telefono")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("telefonoId");

                    b.ToTable("telefono");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.TipoDocumento", b =>
                {
                    b.Property<int>("tipoDocumentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("tipoDocumentoId");

                    b.ToTable("tipoDocumento");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.UsuarioDireccion", b =>
                {
                    b.Property<int>("usuarioDireccionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha")
                        .HasMaxLength(5)
                        .HasColumnType("Date");

                    b.Property<int?>("direccionId")
                        .HasColumnType("int");

                    b.Property<int?>("usuariosId")
                        .HasColumnType("int");

                    b.HasKey("usuarioDireccionId");

                    b.HasIndex("direccionId");

                    b.HasIndex("usuariosId");

                    b.ToTable("usuarioDireccion");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.UsuarioFuncionario", b =>
                {
                    b.Property<int>("usuarioFuncionarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Activo")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("AreaSucursal")
                        .HasMaxLength(5)
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("Date");

                    b.Property<int?>("usuariosId")
                        .HasColumnType("int");

                    b.HasKey("usuarioFuncionarioId");

                    b.HasIndex("usuariosId");

                    b.ToTable("usuarioFuncionario");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.UsuarioJerarquia", b =>
                {
                    b.Property<int>("usuarioJerarquiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Jerarquia")
                        .HasMaxLength(5)
                        .HasColumnType("int");

                    b.Property<int?>("usuariosId")
                        .HasColumnType("int");

                    b.HasKey("usuarioJerarquiaId");

                    b.HasIndex("usuariosId");

                    b.ToTable("usuarioJerarquia");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.UsuarioTelefono", b =>
                {
                    b.Property<int>("usuarioTelefonoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("telefonoId")
                        .HasColumnType("int");

                    b.Property<int?>("usuariosId")
                        .HasColumnType("int");

                    b.HasKey("usuarioTelefonoId");

                    b.HasIndex("telefonoId");

                    b.HasIndex("usuariosId");

                    b.ToTable("usuarioTelefono");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.Usuarios", b =>
                {
                    b.Property<int>("usuariosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Nacimiento")
                        .HasColumnType("Date");

                    b.Property<int?>("documentoId")
                        .HasColumnType("int");

                    b.Property<int?>("generoId")
                        .HasColumnType("int");

                    b.Property<int?>("rhId")
                        .HasColumnType("int");

                    b.Property<int?>("tipoDocumentoId")
                        .HasColumnType("int");

                    b.HasKey("usuariosId");

                    b.HasIndex("documentoId");

                    b.HasIndex("generoId");

                    b.HasIndex("rhId");

                    b.HasIndex("tipoDocumentoId");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.UsuariosApellidos", b =>
                {
                    b.Property<int>("usuariosApellidosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("apellidosId")
                        .HasColumnType("int");

                    b.Property<int?>("usuariosId")
                        .HasColumnType("int");

                    b.HasKey("usuariosApellidosId");

                    b.HasIndex("apellidosId");

                    b.HasIndex("usuariosId");

                    b.ToTable("usuariosApellidos");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.UsuariosEmail", b =>
                {
                    b.Property<int>("usuariosEmailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("emailId")
                        .HasColumnType("int");

                    b.Property<int?>("usuariosId")
                        .HasColumnType("int");

                    b.HasKey("usuariosEmailId");

                    b.HasIndex("emailId");

                    b.HasIndex("usuariosId");

                    b.ToTable("usuariosEmail");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.UsuariosNombres", b =>
                {
                    b.Property<int>("usuariosNombresId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("nombresId")
                        .HasColumnType("int");

                    b.Property<int?>("usuariosId")
                        .HasColumnType("int");

                    b.HasKey("usuariosNombresId");

                    b.HasIndex("nombresId");

                    b.HasIndex("usuariosId");

                    b.ToTable("usuariosNombres");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.UsuarioDireccion", b =>
                {
                    b.HasOne("Proyecto.App.Dominio.Direccion", "direccion")
                        .WithMany("usuarioDireccionId")
                        .HasForeignKey("direccionId");

                    b.HasOne("Proyecto.App.Dominio.Usuarios", "usuarios")
                        .WithMany("usuarioDireccionId")
                        .HasForeignKey("usuariosId");

                    b.Navigation("direccion");

                    b.Navigation("usuarios");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.UsuarioFuncionario", b =>
                {
                    b.HasOne("Proyecto.App.Dominio.Usuarios", "usuarios")
                        .WithMany("usuarioFuncionarioId")
                        .HasForeignKey("usuariosId");

                    b.Navigation("usuarios");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.UsuarioJerarquia", b =>
                {
                    b.HasOne("Proyecto.App.Dominio.Usuarios", "usuarios")
                        .WithMany("usuarioJerarquiaId")
                        .HasForeignKey("usuariosId");

                    b.Navigation("usuarios");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.UsuarioTelefono", b =>
                {
                    b.HasOne("Proyecto.App.Dominio.Telefono", "telefono")
                        .WithMany("usuarioTelefono")
                        .HasForeignKey("telefonoId");

                    b.HasOne("Proyecto.App.Dominio.Usuarios", "usuarios")
                        .WithMany("usuarioTelefono")
                        .HasForeignKey("usuariosId");

                    b.Navigation("telefono");

                    b.Navigation("usuarios");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.Usuarios", b =>
                {
                    b.HasOne("Proyecto.App.Dominio.Documento", "documento")
                        .WithMany("Usuarios")
                        .HasForeignKey("documentoId");

                    b.HasOne("Proyecto.App.Dominio.Genero", "genero")
                        .WithMany("usuariosId")
                        .HasForeignKey("generoId");

                    b.HasOne("Proyecto.App.Dominio.RH", "Rh")
                        .WithMany("Usuarios")
                        .HasForeignKey("rhId");

                    b.HasOne("Proyecto.App.Dominio.TipoDocumento", "tipoDocumento")
                        .WithMany("Usuarios")
                        .HasForeignKey("tipoDocumentoId");

                    b.Navigation("documento");

                    b.Navigation("genero");

                    b.Navigation("Rh");

                    b.Navigation("tipoDocumento");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.UsuariosApellidos", b =>
                {
                    b.HasOne("Proyecto.App.Dominio.Apellidos", "apellidos")
                        .WithMany("usuariosIdApellidos")
                        .HasForeignKey("apellidosId");

                    b.HasOne("Proyecto.App.Dominio.Usuarios", "usuarios")
                        .WithMany("usuariosIdApellidos")
                        .HasForeignKey("usuariosId");

                    b.Navigation("apellidos");

                    b.Navigation("usuarios");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.UsuariosEmail", b =>
                {
                    b.HasOne("Proyecto.App.Dominio.Email", "email")
                        .WithMany()
                        .HasForeignKey("emailId");

                    b.HasOne("Proyecto.App.Dominio.Usuarios", "usuarios")
                        .WithMany("usuariosIdEmail")
                        .HasForeignKey("usuariosId");

                    b.Navigation("email");

                    b.Navigation("usuarios");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.UsuariosNombres", b =>
                {
                    b.HasOne("Proyecto.App.Dominio.Nombres", "nombres")
                        .WithMany("usuariosNombresId")
                        .HasForeignKey("nombresId");

                    b.HasOne("Proyecto.App.Dominio.Usuarios", "usuarios")
                        .WithMany("usuariosNombresId")
                        .HasForeignKey("usuariosId");

                    b.Navigation("nombres");

                    b.Navigation("usuarios");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.Apellidos", b =>
                {
                    b.Navigation("usuariosIdApellidos");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.Direccion", b =>
                {
                    b.Navigation("usuarioDireccionId");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.Documento", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.Genero", b =>
                {
                    b.Navigation("usuariosId");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.Nombres", b =>
                {
                    b.Navigation("usuariosNombresId");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.RH", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.Telefono", b =>
                {
                    b.Navigation("usuarioTelefono");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.TipoDocumento", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.Usuarios", b =>
                {
                    b.Navigation("usuarioDireccionId");

                    b.Navigation("usuarioFuncionarioId");

                    b.Navigation("usuarioJerarquiaId");

                    b.Navigation("usuariosIdApellidos");

                    b.Navigation("usuariosIdEmail");

                    b.Navigation("usuariosNombresId");

                    b.Navigation("usuarioTelefono");
                });
#pragma warning restore 612, 618
        }
    }
}
