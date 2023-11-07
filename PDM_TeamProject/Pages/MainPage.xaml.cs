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
        /*var browserSeriesPage = new BrowserSeriesPage();
        await Navigation.PushAsync(browserSeriesPage);*/

        ((Shell)Application.Current.MainPage).GoToAsync("BrowserSeriesPage");
    }
}