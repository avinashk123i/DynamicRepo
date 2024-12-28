using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace WebApplication1.Pages
{
    public class HumanResourceModel : PageModel
    {
        [BindProperty]
        public List<WeatherForecastDTO> WeatherForecasts { get; set; } = new List<WeatherForecastDTO>();

        private readonly IHttpClientFactory _httpClientFactory;

        public HumanResourceModel(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            
        }

        public async Task OnGet()
        
        {
            var client = _httpClientFactory.CreateClient("HttpClient");

            
            var token = await client.PostAsJsonAsync("Authentication/api", new Credentials()
            {
                username = "Avinash",
                password = "123"
            } );

            token.EnsureSuccessStatusCode();

            var test = await token.Content.ReadAsStringAsync();

            
            client.DefaultRequestHeaders.Authorization =  new System.Net.Http.Headers.AuthenticationHeaderValue ("Bearer" , test);

            WeatherForecasts = await client?.GetFromJsonAsync<List<WeatherForecastDTO>>("/WeatherForecast");
        }


    }

    public class WeatherForecastDTO
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
