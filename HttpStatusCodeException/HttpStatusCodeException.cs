using System.Net;
using System.Runtime.Serialization;


namespace HttpRequestException
{
  //
  // Summary:
  //     The http status code exception.
  [Serializable]
  public class HttpStatusCodeException : DomainException
  {
    //
    // Summary:
    //     Gets or sets the status code.
    //
    // Value:
    //     The status code.
    public HttpStatusCode StatusCode { get; set; }

    //
    // Summary:
    //     Initializes a new instance of the .Common.Exceptions.HttpStatusCodeException
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
    public HttpStatusCodeException(HttpStatusCode statusCode, string message = null, Exception innerException = null)
        : base(message, innerException)
    {
      StatusCode = statusCode;
    }

    //
    // Summary:
    //     Initializes a new instance of the .Common.Exceptions.HttpStatusCodeException
    //     class.
    public HttpStatusCodeException()
        : this(null)
    {
    }

    //
    // Summary:
    //     Initializes a new instance of the .Common.Exceptions.HttpStatusCodeException
    //     class.
    //
    // Parameters:
    //   message:
    //     The message that describes the error.
    public HttpStatusCodeException(string message)
        : this(message, null)
    {
    }

    //
    // Summary:
    //     Initializes a new instance of the .Common.Exceptions.HttpStatusCodeException
    //     class.
    //
    // Parameters:
    //   message:
    //     The error message that explains the reason for the exception.
    //
    //   innerException:
    //     The exception that is the cause of the current exception, or a null reference
    //     (Nothing in Visual Basic) if no inner exception is specified.
    public HttpStatusCodeException(string message, Exception innerException)
        : this(HttpStatusCode.InternalServerError, message, innerException)
    {
    }

    //
    // Summary:
    //     Initializes a new instance of the .Common.Exceptions.HttpStatusCodeException
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
    protected HttpStatusCodeException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
      StatusCode = (HttpStatusCode)info.GetInt32("StatusCode");
    }

    //
    // Summary:
    //     When overridden in a derived class, sets the System.Runtime.Serialization.SerializationInfo
    //     with information about the exception.
    //
    // Parameters:
    //   info:
    //     The System.Runtime.Serialization.SerializationInfo that holds the serialized
    //     object data about the exception being thrown.
    //
    //   context:
    //     The System.Runtime.Serialization.StreamingContext that contains contextual information
    //     about the source or destination.
    //
    // Exceptions:
    //   T:System.ArgumentNullException:
    //     info.
    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      if (info == null)
      {
        throw new ArgumentNullException("info");
      }

      info.AddValue("StatusCode", (int)StatusCode);
      base.GetObjectData(info, context);
    }
  }
}
