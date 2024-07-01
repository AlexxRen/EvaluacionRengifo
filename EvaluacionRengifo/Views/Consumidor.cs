using EvaluacionRengifo.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EvaluacionRengifo.Views
{
    internal class Consumidor :ApiConsumo
    {
        public class RestService:ApiConsumo
        {
            HttpClient _client;
            JsonSerializerOptions _serializerOptions;

            public List<ApiConsumo> Items { get;set; }

            public RestService()
            {
                _client = new HttpClient();
                _serializerOptions = new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    WriteIndented = true
                };

            }
            public async Task<List<ApiConsumo>> RefreshDataAsync()
            {
                Items = new List<ApiConsumo>();

                Uri uri = new Uri(string.Format("https://api.chucknorris.io/jokes/random", string.Empty));
                try
                {
                    HttpResponseMessage response = await _client.GetAsync(uri);
                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        Items = JsonSerializer.Deserialize<List<ApiConsumo>>(content, _serializerOptions);
                    }
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }

                return Items;
            }
        }
    }
}


