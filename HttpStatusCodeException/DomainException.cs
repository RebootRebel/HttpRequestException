using System;
using System.Runtime.Serialization;

namespace HttpRequestException
{
  //
  // Summary:
  //     The base domain exception.
  [Serializable]
  public class DomainException : Exception
  {
    //
    // Summary:
    //     Initializes a new instance of the .Common.Exceptions.DomainException class.
    public DomainException()
    {
    }

    //
    // Summary:
    //     Initializes a new instance of the .Common.Exceptions.DomainException class.
    //
    // Parameters:
    //   message:
    //     The message that describes the error.
    public DomainException(string message)
        : base(message)
    {
    }

    //
    // Summary:
    //     Initializes a new instance of the .Common.Exceptions.DomainException class.
    //
    // Parameters:
    //   message:
    //     The error message that explains the reason for the exception.
    //
    //   innerException:
    //     The exception that is the cause of the current exception, or a null reference
    //     (Nothing in Visual Basic) if no inner exception is specified.
    public DomainException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    //
    // Summary:
    //     Initializes a new instance of the .Common.Exceptions.DomainException class.
    //
    // Parameters:
    //   info:
    //     The System.Runtime.Serialization.SerializationInfo that holds the serialized
    //     object data about the exception being thrown.
    //
    //   context:
    //     The System.Runtime.Serialization.StreamingContext that contains contextual information
    //     about the source or destination.
    protected DomainException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
  }
}
