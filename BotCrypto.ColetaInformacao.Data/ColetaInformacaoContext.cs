﻿using BotCrypto.ColetaInformacao.Domain;
using BotCrypto.Core.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotCrypto.ColetaInformacao.Data
{
    public class ColetaInformacaoContext : DbContext, IUnitOfWork
    {
        public ColetaInformacaoContext(DbContextOptions<ColetaInformacaoContext> options) : base(options) { }

        public DbSet<Ticker> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
            //    e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
            //    property.Relational().ColumnType = "varchar(100)";

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ColetaInformacaoContext).Assembly);
        }

        public async Task<bool> Commit()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("dtCriacao").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("dtCriacao").IsModified = false;
                }
            }

            return await base.SaveChangesAsync() > 0;
        }
    }
}
