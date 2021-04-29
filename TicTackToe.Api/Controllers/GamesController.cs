using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicTacToe.Core.Commands;
using TicTacToe.Core.Domain.Entities;

namespace TicTackToe.Api.Controllers
{
    [Route("api/games")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GamesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("history")]
        public async Task History()
        {

        }

        [HttpPost("start")]
        public async Task<Game> StartGame(StartGame cmd)
        {
            return await _mediator.Send(cmd);
        }

        [HttpPost("play-move")]
        public async Task PlayMove()
        {

        }

        [HttpPost("reset/{id}")]
        public async Task ResetGame(string id)
        {

        }

        [HttpPost("load/{id}")]
        public async Task LoadGame(string id)
        {

        }

    }
}
