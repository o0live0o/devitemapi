using System;
using System.Runtime.Serialization;

namespace devitemapi.Infrastructure.Exceptions
{
    public class ItemException : Exception
    {
        public ItemException(string message) : base(message)
        {
        }

        public ItemException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}