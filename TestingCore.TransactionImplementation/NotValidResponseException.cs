using System;
using System.Runtime.Serialization;

namespace TestingCore.TransactionImplementation
{
    public class NotValidResponseException : Exception
    {
        public NotValidResponseException()
        {
        }

        public NotValidResponseException(string message) : base(message)
        {
        }

        public NotValidResponseException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotValidResponseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
