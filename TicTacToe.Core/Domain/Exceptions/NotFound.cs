using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Core.Domain.Exceptions
{
    public class NotFound : Exception
    {
        public NotFound() : base("Resource not found") { }
        public NotFound(string message = "Resource not found") : base(message) { }
    }
}
