using System.Runtime.Serialization;

namespace Ej2
{
    [Serializable]
    internal class CodigoInvalidoException : Exception
    {
        public CodigoInvalidoException() : base ("El codigo introducido no es válido")
        {
        }

        public CodigoInvalidoException(string? message) : base(message)
        {
        }

        public CodigoInvalidoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CodigoInvalidoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}