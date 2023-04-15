using System.Net;

namespace Net.API.Exceptions
{
    [Serializable]
    public class CustomException : Exception 
    {
        public CustomException(string message) : base(message)  {
            Detalle = message;
        }
        public string Mensaje { get; } = "Ha ocurrido un error inesperado en el aplicativo";
        public string Detalle {get;}
        public HttpStatusCode StatusCode => HttpStatusCode.BadRequest;

        public override string ToString() => "Mensaje: " + this.Mensaje +"\nDetalle: " +this.Detalle;         
    }
}
