﻿// <auto-generated />
using System;
using CRUD_Vacinas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRUD_Vacinas.Migrations
{
    [DbContext(typeof(VacinasContext))]
    partial class VacinasContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("CRUD_Vacinas.Models.Cidade", b =>
                {
                    b.Property<int>("CodCidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Aniversario")
                        .HasColumnType("DATETIME");

                    b.Property<int?>("CodEstado")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(33)
                        .HasColumnType("varchar(33)");

                    b.Property<int>("Populacao")
                        .HasColumnType("INTEGER");

                    b.HasKey("CodCidade");

                    b.HasIndex("CodEstado");

                    b.ToTable("Cidades");
                });

            modelBuilder.Entity("CRUD_Vacinas.Models.Estado", b =>
                {
                    b.Property<int>("CodEstado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Fundacao")
                        .HasColumnType("DATETIME");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)");

                    b.Property<int>("Populacao")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("CHAR(2)")
                        .HasColumnName("UF");

                    b.HasKey("CodEstado");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("CRUD_Vacinas.Models.Cidade", b =>
                {
                    b.HasOne("CRUD_Vacinas.Models.Estado", "NomeEstado")
                        .WithMany("Cidades")
                        .HasForeignKey("CodEstado")
                        .HasConstraintName("CodEstado")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("NomeEstado");
                });

            modelBuilder.Entity("CRUD_Vacinas.Models.Estado", b =>
                {
                    b.Navigation("Cidades");
                });
#pragma warning restore 612, 618
        }
    }
}
