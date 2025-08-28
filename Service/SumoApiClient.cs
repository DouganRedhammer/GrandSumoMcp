namespace GrandSumoMcp.Service
{
    public class SumoApiClient
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://sumo-api.com/api";

        public SumoApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetRikishiByNameENAsync(string name)
        {
            var url = $"{BaseUrl}/rikishis?shikonaEn={name}";
           
            return await SendGetRequestAsync(url);
        }

        public async Task<string> GetRikishiDetailsAsync(int rikishiId)
        {
            var url = $"{BaseUrl}/rikishi/{rikishiId}";
            return await SendGetRequestAsync(url);
        }

        public async Task<string> GetBashoScheduleAsync(int bashoId, string division, int day)
        {
            var url = $"{BaseUrl}/basho/{bashoId}/torikumi/{division}/{day}";
            return await SendGetRequestAsync(url);
        }

        public async Task<string> GetRikishiStatsAsync(int rikishiId)
        {
            var url = $"{BaseUrl}/rikishi/{rikishiId}/stats";
            return await SendGetRequestAsync(url);
        }

        public async Task<string> GetRikishiMatchesAsync(int rikishiId)
        {
            var url = $"{BaseUrl}/rikishi/{rikishiId}/matches";
            return await SendGetRequestAsync(url);
        }

        public async Task<string> GetKimariteDetailsAsync(string kimarite)
        {
            var url = $"{BaseUrl}/kimarite/{kimarite}";
            return await SendGetRequestAsync(url);
        }

        private async Task<string> SendGetRequestAsync(string url)
        {
            try
            {
                var response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException ex)
            {
                return $"Request failed: {ex.Message}";
            }
        }
    }
}
