using System.Reflection;
using PDM_TeamProject.Pages;

namespace PDM_TeamProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
         private async void OnAllSeriesListClicked(object sender, EventArgs e)
        {
            var browserSeriesPage = new BrowserSeriesPage();
            await Navigation.PushAsync(browserSeriesPage);
        }
    }
}