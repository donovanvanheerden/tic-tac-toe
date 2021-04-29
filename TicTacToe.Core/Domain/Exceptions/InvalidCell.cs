using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Core.Domain.Exceptions
{
    public class InvalidCell : Exception
    {
        public InvalidCell() : base("Invalid Cell") { }
        public InvalidCell(string message = "Invalid Cell") : base(message) { }
    }
}
