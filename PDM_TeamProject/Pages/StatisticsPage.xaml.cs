using Microcharts;
using SkiaSharp;
using System.Collections.Generic;
using PDM_TeamProject.Classes;

namespace PDM_TeamProject.Pages
{
    public partial class StatisticsPage : ContentPage
    {
        public StatisticsPage()
        {
            InitializeComponent();
            LoadChartData();
        }
        SerieService serieService = new SerieService();

        private async void LoadChartData()
        {
            var movies = await serieService.GetTvSeries();
            List<ChartEntry> chartEntries = new List<ChartEntry>();

            foreach (var movie in movies)
            {
                chartEntries.Add(new ChartEntry((float)movie.vote_average)
                {
                    Label = movie.name,
                    ValueLabel = movie.vote_average.ToString(),
                    Color = SKColor.Parse("#266489")
                });
            }

            var chart = new BarChart { Entries = chartEntries };
            chartView.Chart = chart;
        }
    }
}