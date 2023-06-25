using System.Runtime.Serialization;

namespace HttpRequestException
{
  [Serializable]
  public class NotAuthorizedException : Exception
  {
    public NotAuthorizedException(string message, Exception innerException = null) : base(message, innerException)
    {
    }

    protected NotAuthorizedException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
  }
}
