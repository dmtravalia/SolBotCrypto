﻿// <auto-generated />
using System;
using BotCrypto.ColetaInformacao.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BotCrypto.ColetaInformacao.Data.Migrations
{
    [DbContext(typeof(ColetaInformacaoContext))]
    partial class ColetaInformacaoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BotCrypto.ColetaInformacao.Domain.Ticker", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataModificacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateNormal")
                        .HasColumnType("datetime2");

                    b.Property<int>("TipoMoeda")
                        .HasColumnType("int");

                    b.Property<double>("buy")
                        .HasColumnType("float");

                    b.Property<int>("date")
                        .HasColumnType("int");

                    b.Property<double>("high")
                        .HasColumnType("float");

                    b.Property<double>("last")
                        .HasColumnType("float");

                    b.Property<double>("low")
                        .HasColumnType("float");

                    b.Property<double>("sell")
                        .HasColumnType("float");

                    b.Property<double>("vol")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Tickers");
                });
#pragma warning restore 612, 618
        }
    }
}
