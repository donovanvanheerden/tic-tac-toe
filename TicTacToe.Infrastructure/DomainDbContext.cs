using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TicTacToe.Core.Domain.Entities;
using TicTacToe.Core.Infra;

namespace TicTacToe.Infrastructure
{
    public class DomainDbContext : DbContext, IDomainDbContext
    {
        public DomainDbContext(DbContextOptions<DomainDbContext> options) : base(options) { }

        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(DomainDbContext)));
        }
    }
}
