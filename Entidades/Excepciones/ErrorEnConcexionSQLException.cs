using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    internal class ErrorEnConcexionSQLException : Exception
    {
        public ErrorEnConcexionSQLException(string? message) : base(message)
        {
        }

        public ErrorEnConcexionSQLException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
