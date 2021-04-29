﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Core.Domain.Entities
{
    public class Game
    {
        public Game() 
        { 
            Id = Guid.NewGuid(); 
        }

        public Guid Id { get; }

        public string Player1Name { get; set; }
        public string Player2Name { get; set; }

        public string Cell1 { get; set; }
        public string Cell2 { get; set; }
        public string Cell3 { get; set; }
        public string Cell4 { get; set; }
        public string Cell5 { get; set; }
        public string Cell6 { get; set; }
        public string Cell7 { get; set; }
        public string Cell8 { get; set; }
        public string Cell9 { get; set; }

    }
}
