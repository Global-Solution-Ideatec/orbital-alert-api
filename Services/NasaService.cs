using OrbitalAlert.API.DTOs;

namespace OrbitalAlert.API.Services
{
    public class NasaService
    {
        private readonly HttpClient _httpClient;

        public NasaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<NasaApodDto> GetApodAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<NasaApodDto>(
                "https://api.nasa.gov/planetary/apod?api_key=DEMO_KEY");

            return response;
        }
    }
}