﻿using System.Runtime.Serialization;

namespace Entidades.Excepciones
{
    [Serializable]
    internal class NoPudoLeerElArchivoException : Exception
    {
        public NoPudoLeerElArchivoException()
        {
        }
        /// <summary>
        /// No encontró el archivo para leer
        /// </summary>
        /// <param name="message">mensaje</param>
        public NoPudoLeerElArchivoException(string? message) : base(message)
        {
        }

        public NoPudoLeerElArchivoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NoPudoLeerElArchivoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}