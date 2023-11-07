using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PDM_TeamProject.Classes
{
    public class SerieService
    {
        HttpClient httpClient;
        JsonSerializerOptions serializerOptions;

        public SerieService()
        {
            httpClient = new HttpClient();
            serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }

        public async Task<List<SerieJson>> GetTvSeries()
        {
            List<SerieJson> tvSeries = new List<SerieJson>();

            //string UriString = $"{Constants.ApiUri}/movie/popular?api_key={Constants.ApiKey}";
            string UriString = $"https://api.themoviedb.org/3/discover/tv?api_key=4b0a2fb7163ed78a586c2826e03cd05f";
            Uri uri = new Uri(UriString);
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    TvSeriesJson tvSeriesJson = JsonSerializer.Deserialize<TvSeriesJson>(content, serializerOptions);
                    tvSeries = tvSeriesJson.results;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return tvSeries;
        }

    }
}
