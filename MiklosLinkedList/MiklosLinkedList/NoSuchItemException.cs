using System;
using System.Runtime.Serialization;

namespace MiklosLinkedList
{
    [Serializable]
    internal class NoSuchItemException : Exception
    {
        public NoSuchItemException()
        {
        }

        public NoSuchItemException(string message) : base(message)
        {
        }

        public NoSuchItemException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoSuchItemException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}