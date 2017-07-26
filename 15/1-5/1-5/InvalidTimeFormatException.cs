using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace _1_5
{
    [Serializable]
    class InvalidTimeFormatException : ApplicationException
    {
        public InvalidTimeFormatException()
        {
        }

        public InvalidTimeFormatException(string message) : base(message)
        {
        }

        public InvalidTimeFormatException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public InvalidTimeFormatException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
