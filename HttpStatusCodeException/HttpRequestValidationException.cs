using System.Runtime.Serialization;

namespace HttpRequestException
{
  [Serializable]
  public class ValidationException : Exception
  {
    public ValidationException(string message, Exception innerException = null) : base(message, innerException)
    {
    }

    protected ValidationException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
  }
}
