using PDM_TeamProject.Classes;
namespace PDM_TeamProject.Pages;

public partial class MainPage : ContentPage
{
    SerieService MovieService;
    SerieDatabase MovieDatabase;

    public MainPage(SerieService movieService, SerieDatabase movieDatabase)
    {
        // InitializeComponent();
        MovieService = movieService;
        MovieDatabase = movieDatabase;
    }

    protected override async void OnAppearing()
    {
        //List<Genre> genres = await SerieService.GetGenres();
        //SerieDatabase.Genres.InsertOrUpdateGenres(genres);
    }

    private void OnBrowseMoviesClick(object sender, EventArgs e)
    {
        ((Shell)Application.Current.MainPage).GoToAsync("BrowseSeriesPage");
    }

    private void OnMyListClicked(object sender, EventArgs e)
    {
        ((Shell)Application.Current.MainPage).GoToAsync("MyListPage");
    }

    private void OnStatisticsClicked(object sender, EventArgs e)
    {
        ((Shell)Application.Current.MainPage).GoToAsync("StatisticsPage");
    }
}
