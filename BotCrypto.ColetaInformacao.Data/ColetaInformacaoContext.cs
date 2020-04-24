using BotCrypto.ColetaInformacao.Domain;
using BotCrypto.Core.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BotCrypto.ColetaInformacao.Data
{
    public class ColetaInformacaoContext : DbContext, IUnitOfWork
    {
        public ColetaInformacaoContext(DbContextOptions<ColetaInformacaoContext> options) : base(options) { }

        public DbSet<Ticker> Tickers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ColetaInformacaoContext).Assembly);
        }

        public async Task<bool> Commit()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCriacao").CurrentValue = DateTime.Now;
                    entry.Property("DataModificacao").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCriacao").IsModified = false;
                    entry.Property("DataModificacao").CurrentValue = DateTime.Now;
                }
            }

            return await base.SaveChangesAsync() > 0;
        }
    }
}
