using Entities.DataTransferObjects;
using Entities.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Poslanci.Server.HttpRepository
{
    public class PoslanciHttpRepository : IPoslanciHttpRepository
    {
        private readonly HttpClient _client;

        public PoslanciHttpRepository(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<PoslanecDto>> GetCurrentPoslanci()
        {
            var response = await _client.GetAsync("poslanec");
            var content = await response.Content.ReadAsStringAsync();

            var poslanci = JsonSerializer.Deserialize<List<PoslanecDto>>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return poslanci;
        }
    }
}
