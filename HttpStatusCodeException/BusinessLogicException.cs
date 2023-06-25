using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace HttpRequestException
{
  [Serializable]
  public class BusinessLogicException : Exception
  {
    public BusinessLogicException(string message, IDictionary<string, object> errorDetails, Exception innerException = null) : base(message, innerException)
    {
      ErrorDetails = errorDetails;
    }

    public BusinessLogicException(string message, Exception innerException = null) : base(message, innerException)
    {
    }

    public IDictionary<string, object> ErrorDetails { get; }

    [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      if (info == null)
      {
        throw new ArgumentNullException(nameof(info));
      }

      info.AddValue(nameof(ErrorDetails), ErrorDetails);

      base.GetObjectData(info, context);
    }
  }
}
