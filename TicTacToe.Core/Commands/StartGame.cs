using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TicTacToe.Core.Domain.Entities;
using TicTacToe.Core.Infra;

namespace TicTacToe.Core.Commands
{
    public class StartGame : IRequest<Game>
    {
        public string PlayerName { get; set; }

        public class Handler : IRequestHandler<StartGame, Game>
        {
            private readonly IDomainDbContext _db;

            public Handler(IDomainDbContext db)
            {
                _db = db;
            }

            public async Task<Game> Handle(StartGame request, CancellationToken cancellationToken)
            {
                var game = new Game()
                {
                    Player1Name = request.PlayerName,
                };

                await _db.Games.AddAsync(game);
                await _db.SaveChangesAsync(cancellationToken);

                return await Task.FromResult(game);
            }
        }
    }
}
