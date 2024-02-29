using MyApp.Shared.Services.Dto.Base;
using Newtonsoft.Json;
using Refit;
using System.Text.Json.Serialization;

namespace MyApp.Service.Dto.Response
{
    public class ResponseDto : BaseResponseDto
    {
        [JsonPropertyName("cep")]
        public string ZipCode { get; set; }

        [JsonPropertyName("logradouro")]
        public string Street { get; set; }

        [JsonPropertyName("complemento")]
        public string Complement { get; set; }

        [JsonPropertyName("bairro")]
        public string neighborhood { get; set; }

        [JsonPropertyName("localidade")]
        public string City { get; set; }

        [JsonPropertyName("uf")]
        public string State { get; set; }

        [JsonPropertyName("ibge")]
        public string Ibge { get; set; }

        [JsonPropertyName("gia")]
        public string Gia { get; set; }

        [JsonPropertyName("ddd")]
        public string Ddd { get; set; }

        [JsonPropertyName("siafi")]
        public string Siafi { get; set; }
    }
}
