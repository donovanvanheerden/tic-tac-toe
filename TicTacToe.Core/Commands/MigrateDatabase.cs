using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TicTacToe.Core.Infra;

namespace TicTacToe.Core.Commands
{
    public class MigrateDatabase : IRequest
    {
        public class Handler : IRequestHandler<MigrateDatabase>
        {
            private readonly IDomainDbContext _db;

            public Handler(IDomainDbContext db)
            {
                _db = db;
            }

            public async Task<Unit> Handle(MigrateDatabase request, CancellationToken cancellationToken)
            {
                var migrations = await _db.Database.GetPendingMigrationsAsync();

                if (migrations.ToList().Count == 0) return Unit.Value;

                await _db.Database.MigrateAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
