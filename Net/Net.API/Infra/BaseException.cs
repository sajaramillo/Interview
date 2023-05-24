using System.Net;

namespace Net.API.Infra
{

	[Serializable]
	public class BaseException : Exception
	{
		public BaseException() { }
		public BaseException(string message) : base(message) { }
		public BaseException(string message, Exception inner) : base(message, inner) { }
		protected BaseException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

        public virtual HttpStatusCode StatusCode => HttpStatusCode.BadRequest;

        public override string Message => "Ha ocurrido un error inesperado en el aplicativo";

        public override string ToString()
        {
            return Message;
        }
    }
}
