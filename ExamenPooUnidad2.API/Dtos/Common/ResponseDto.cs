using System.Text.Json.Serialization;

namespace ExamenPooUnidad2.API.Dtos.Common
{
    public class ResponseDto<T>
    {
        [JsonIgnore] // Para que solo yo lo mire 
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public bool Status { get; set; }
        public T Data { get; set; }
    }
}
