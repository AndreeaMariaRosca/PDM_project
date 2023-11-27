using System.Reflection;
using PDM_TeamProject.Pages;

namespace PDM_TeamProject.Pages;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
     private async void OnAllSeriesListClicked(object sender, EventArgs e)
    {
        ((Shell)Application.Current.MainPage).GoToAsync("BrowserSeriesPage");
    }

     private async void OnStatisticsClicked(object sender, EventArgs e)
    {
        ((Shell)Application.Current.MainPage).GoToAsync("StatisticsPage");
    }
    private async void OnAboutUsClicked(object sender, EventArgs e)
    {
       await Navigation.PushAsync(new AboutUsPage());
    }
}