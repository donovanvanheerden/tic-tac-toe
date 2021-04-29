using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TicTacToe.Core.Domain.Exceptions;
using TicTacToe.Core.Dtos;
using TicTacToe.Core.Infra;

namespace TicTacToe.Core.Commands
{
    public class PlayMove : IRequest<Move>
    {
        public Guid GameId { get; set; }
        public int Cell { get; set; }
        public string Value { get; set; }

        public class Handler : IRequestHandler<PlayMove, Move>
        {
            private readonly IDomainDbContext _db;

            public Handler(IDomainDbContext db)
            {
                _db = db;
            }

            public async Task<Move> Handle(PlayMove request, CancellationToken cancellationToken)
            {
                var game = await _db.Games.FirstOrDefaultAsync(g => g.Id.Equals(request.GameId));

                if (game == null) throw new NotFound("Game not found");

                if (request.Cell == 0 || request.Cell > 9) throw new InvalidCell("Cell is not valid");

                game.SetCell(request.Cell, request.Value);
                
                
                Random rng = new Random();

                var cell = rng.Next(1, 9);

                while (game.CellHasValue(cell)) cell = rng.Next(1, 9);

                game.SetCell(cell, "O");

                
                _db.Games.Update(game);

                await _db.SaveChangesAsync(cancellationToken);

                return new Move {
                    Cell = cell,
                    Value = "O"
                };
            }
        }
    }
}
