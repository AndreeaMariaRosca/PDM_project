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
        await Navigation.PushAsync(new BrowserSeriesPage());

    }


    private async void OnAboutUsPageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AboutUsPage());
    }

    private async void OnStatisticsPageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StatisticsPage());
    }
}