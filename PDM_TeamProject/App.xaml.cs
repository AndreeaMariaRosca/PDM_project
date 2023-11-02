using PDM_TeamProject.Pages;

namespace PDM_TeamProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            Routing.RegisterRoute(nameof(StatisticsPage), typeof(StatisticsPage));
            Routing.RegisterRoute(nameof(MyListPage), typeof(MyListPage));
            Routing.RegisterRoute(nameof(BrowseSeriesPage), typeof(BrowseSeriesPage));
            Routing.RegisterRoute(nameof(AddSeriesPage), typeof(AddSeriesPage));
            Routing.RegisterRoute(nameof(SeriesDetailsPage), typeof(SeriesDetailsPage));

        }
    }
}