using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ScoutSport.Models;

namespace ScoutSport.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Clube> Clubes { get; set; }

        public DbSet<Jogador> Jogadores { get; set; }

        public DbSet<Observacao> Observacoes { get; set; }

        public DbSet<Avaliacao> Avaliacoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(optionsBuilder.IsConfigured)
            {
                return;
            }
            var configuration = new ConfigurationBuilder()
                .AddUserSecrets<AppDbContext>()
                .AddEnvironmentVariables()
                .Build();

            var connectionString = configuration.GetConnectionString("ScoutSportDB");

            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException("A ligação à base de dados não esta configurada.");
            }

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}

            