using System.Net;
using System.Runtime.Serialization;

namespace HttpRequestException;
//
// Summary:
//     The bad request exception.
[Serializable]
public class BadRequestException : HttpStatusCodeException
{
  //
  // Summary:
  //     Initializes a new instance of the 
  //     class.
  //
  // Parameters:
  //   message:
  //     The error message that explains the reason for the exception.
  //
  //   innerException:
  //     The exception that is the cause of the current exception, or a null reference
  //     (Nothing in Visual Basic) if no inner exception is specified.
  public BadRequestException(string message, Exception innerException)
      : this(HttpStatusCode.BadRequest, message, innerException)
  {
  }

  //
  // Summary:
  //     Initializes a new instance of the HttpRequestException.BadRequestException
  //     class.
  public BadRequestException()
      : this(null)
  {
  }

  //
  // Summary:
  //     Initializes a new instance of the HttpRequestException.BadRequestException
  //     class.
  //
  // Parameters:
  //   message:
  //     The message that describes the error.
  public BadRequestException(string message)
      : this(HttpStatusCode.BadRequest, message, null)
  {
  }

  //
  // Summary:
  //     Initializes a new instance of the HttpRequestException.BadRequestException
  //     class.
  //
  // Parameters:
  //   statusCode:
  //     The status code.
  //
  //   message:
  //     The message.
  //
  //   innerException:
  //     The inner exception.
  protected BadRequestException(HttpStatusCode statusCode, string message = null, Exception innerException = null)
      : base(statusCode, message, innerException)
  {
  }

  //
  // Summary:
  //     Initializes a new instance
  //     class.
  //
  // Parameters:
  //   info:
  //     The System.Runtime.Serialization.SerializationInfo that holds the serialized
  //     object data about the exception being thrown.
  //
  //   context:
  //     The System.Runtime.Serialization.StreamingContext that contains contextual information
  //     about the source or destination.
  protected BadRequestException(SerializationInfo info, StreamingContext context)
      : base(info, context)
  {
  }
}
