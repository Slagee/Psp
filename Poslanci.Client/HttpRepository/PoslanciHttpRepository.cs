﻿using Entities.DataTransferObjects;
using Entities.RequestFeatures;
using Microsoft.AspNetCore.WebUtilities;
using Poslanci.Client.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Poslanci.Client.HttpRepository
{
    public class PoslanciHttpRepository : IPoslanciHttpRepository
    {
        private readonly HttpClient _client;

        public PoslanciHttpRepository(HttpClient client)
        {
            _client = client;
        }

        public async Task<PagingResponse<PoslanecDto>> GetCurrentPoslanci(PoslanciParameters poslanciParameters)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = poslanciParameters.PageNumber.ToString(),
                ["searchTerm"] = poslanciParameters.SearchTerm == null ? "" : poslanciParameters.SearchTerm,
                ["orderBy"] = poslanciParameters.OrderBy,
                ["houses"] = poslanciParameters.Houses.ToString()
            };

            var response = await _client.GetAsync(QueryHelpers.AddQueryString("poslanec", queryStringParam));
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            var pagingResponse = new PagingResponse<PoslanecDto>
            {
                Items = JsonSerializer.Deserialize<List<PoslanecDto>>(content, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }),
                MetaData = JsonSerializer.Deserialize<MetaData>(response.Headers.GetValues("X-Pagination").First(), new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                })
            };

            return pagingResponse;
        }

        public async Task<PoslanecDto> GetPoslanec(string id)
        {
            var response = await _client.GetAsync("poslanec/" +id);
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            var poslanec = JsonSerializer.Deserialize<PoslanecDto>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return poslanec;
        }
    }
}
