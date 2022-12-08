﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using teste_.Models;

#nullable disable

namespace teste_.Migrations
{
    [DbContext(typeof(BancoDB))]
    [Migration("20221208181959_Teste_")]
    partial class Teste_
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("teste_.Models.Cidade", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("codigo");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Codigo"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nome");

                    b.HasKey("Codigo");

                    b.ToTable("Cidade");
                });

            modelBuilder.Entity("teste_.Models.Cliente", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("codigo");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Codigo"), 1L, 1);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<int>("CidadeId")
                        .HasColumnType("int")
                        .HasColumnName("codigo_cidade");

                    b.Property<DateTime?>("DataNascimento")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_nascimento");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nome");

                    b.HasKey("Codigo");

                    b.HasIndex("CidadeId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("teste_.Models.Cliente", b =>
                {
                    b.HasOne("teste_.Models.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");
                });
#pragma warning restore 612, 618
        }
    }
}
