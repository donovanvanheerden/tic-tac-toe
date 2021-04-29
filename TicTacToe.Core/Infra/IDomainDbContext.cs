using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Threading;
using System.Threading.Tasks;
using TicTacToe.Core.Domain.Entities;

namespace TicTacToe.Core.Infra
{
    public interface IDomainDbContext
    {
        DatabaseFacade Database { get; }

        DbSet<Game> Games { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
