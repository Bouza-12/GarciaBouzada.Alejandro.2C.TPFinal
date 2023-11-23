using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    internal class ErrorEnConcexionSQLException : Exception
    {
        /// <summary>
        /// Excepción en la concexión en la base de Datos
        /// </summary>
        /// <param name="message">mensaje para mostrar</param>
        public ErrorEnConcexionSQLException(string? message) : base(message)
        {
        }
        /// <summary>
        /// Excepción en la concexión en la base de Datos
        /// </summary>
        /// <param name="message">mensaje para mostrar</param>
        /// <param name="innerException"></param>
        public ErrorEnConcexionSQLException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
