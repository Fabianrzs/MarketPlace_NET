﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using AccesoDatos.Datos;

namespace AccesoDatos.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210922034832_cambiosEnImagen")]
    partial class cambiosEnImagen
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "6.0.0-preview.7.21378.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Modelos.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MostrarOrden")
                        .HasColumnType("int");

                    b.Property<string>("NombreCategoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("Modelos.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("DescripcionCorta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescripcionProducto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagenUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreProducto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.Property<int>("TipoAplicacionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("TipoAplicacionId");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("Modelos.TipoAplicacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoAplicacion");
                });

            modelBuilder.Entity("Modelos.Producto", b =>
                {
                    b.HasOne("Modelos.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelos.TipoAplicacion", "TipoAplicacion")
                        .WithMany()
                        .HasForeignKey("TipoAplicacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("TipoAplicacion");
                });
#pragma warning restore 612, 618
        }
    }
}
