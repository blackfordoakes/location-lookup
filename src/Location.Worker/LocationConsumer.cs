using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Location.Models;
using MassTransit;

namespace Location.Worker
{
    public class LocationConsumer : IConsumer<GeocodeRequest>
    {
        private const string API_KEY = "your-key";
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task Consume(ConsumeContext<GeocodeRequest> context)
        {
            var request = context.Message;
            Console.WriteLine($"Recieved request to geocode {request.City}.");

            GeocodeResponse location = null;

            // geocode with PC*Miler Web Services
            if (!_httpClient.DefaultRequestHeaders.Contains("Authorization"))
            {
                _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", API_KEY);
            }

            var url = $"https://pcmiler.alk.com/APIs/REST/v1.0/service.svc/locations?city={request.City}&state={request.State}&postcode={request.PostalCode}&region={request.Region}";
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var responseText = await response.Content.ReadAsStringAsync();
                var tmp = JsonSerializer.Deserialize<List<GeocodeResponse>>(responseText);
                location = tmp.FirstOrDefault();
            }

            await context.RespondAsync(location);
        }
    }
}
