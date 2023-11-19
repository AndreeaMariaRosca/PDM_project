
using PDM_TeamProject.Classes;

namespace PDM_TeamProject.Pages;

public partial class BrowserSeriesPage : ContentPage
{
    /*SerieService SerieService;*/
    List<TvSerie> tvSeries = new();

   /* public BrowserSeriesPage(SerieService serieService)
    {
        InitializeComponent();
        SerieService = serieService;
    }*/

    public BrowserSeriesPage()
    {
        InitializeComponent();
     
    }

    protected override async void OnAppearing()
    {
        SerieService SerieService = new SerieService();
        tvSeries = await SerieService.GetTvSeries();
        listViewTvSeries.ItemsSource = tvSeries;
    }

    private async void ListViewTvSeries_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
       /* PopularMovieJson clickedMovie = e.SelectedItem as PopularMovieJson;
        MovieDetailsJson movieDetails = await MovieService.GetMovieDetails(clickedMovie.id);

        Dictionary<string, object> dataToPass = new()
        {
            { "MovieDetails", movieDetails }
        };

        await Shell.Current.GoToAsync("MovieDetailsPage", dataToPass);*/
    }

    private async void AddButton_Clicked(object sender, EventArgs e)
    {

        ((Shell)Application.Current.MainPage).GoToAsync("ReviewList");
    }

}
