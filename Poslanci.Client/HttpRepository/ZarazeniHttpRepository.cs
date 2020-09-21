using Entities.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Poslanci.Client.HttpRepository
{
    public class ZarazeniHttpRepository : IZarazeniHttpRepository
    {
        private readonly HttpClient _client;

        public ZarazeniHttpRepository(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<ZarazeniDto>> GetZarazeni(short id)
        {
            var response = await _client.GetAsync("zarazeni/" + id);
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            var zarazeni = JsonSerializer.Deserialize<List<ZarazeniDto>>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return zarazeni;
        }

        public async Task<List<ZarazeniDto>> GetClenstvi(short id)
        {
            var response = await _client.GetAsync("zarazeni/" + id + "/clenstvi");
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            var clenstvi = JsonSerializer.Deserialize<List<ZarazeniDto>>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return clenstvi;
        }

        public async Task<List<ZarazeniDto>> GetFunkce(short id)
        {
            var response = await _client.GetAsync("zarazeni/" + id + "/funkce");
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            var funkce = JsonSerializer.Deserialize<List<ZarazeniDto>>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return funkce;
        }
    }
}
