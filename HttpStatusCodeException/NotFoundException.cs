using System.Runtime.Serialization;

namespace HttpRequestException
{
  [Serializable]
  public class NotFoundException : Exception
  {
    public NotFoundException() : this("Not found")
    {
    }

    public NotFoundException(string message, Exception innerException = null) : base(message, innerException)
    {
    }

    protected NotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
  }
}
