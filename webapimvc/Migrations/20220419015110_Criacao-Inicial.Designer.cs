// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using webapimvc.Models;

#nullable disable

namespace webapimvc.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220419015110_Criacao-Inicial")]
    partial class CriacaoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("webapimvc.Models.Email", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("referencia")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("webapimvc.Models.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("bairro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("cidade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("endereco")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("numero")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Fornecedores");
                });

            modelBuilder.Entity("webapimvc.Models.Item", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<float>("quantidade")
                        .HasColumnType("real");

                    b.Property<float>("valor")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("webapimvc.Models.Pedido", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<DateTime>("dataHora")
                        .HasColumnType("timestamp with time zone");

                    b.Property<float>("desconto")
                        .HasColumnType("real");

                    b.Property<int>("idTransportadora")
                        .HasColumnType("integer");

                    b.Property<string>("notaFiscal")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("valorFrete")
                        .HasColumnType("real");

                    b.Property<float>("valorTotal")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("webapimvc.Models.Produto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("webapimvc.Models.Telefone", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("ddd")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("numero")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("referencia")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Telefones");
                });

            modelBuilder.Entity("webapimvc.Models.Transportadora", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Transportadoras");
                });
#pragma warning restore 612, 618
        }
    }
}
