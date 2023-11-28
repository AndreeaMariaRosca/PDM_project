using Microsoft.Extensions.Logging;
using PDM_TeamProject.Classes;
using PDM_TeamProject.Pages;
using PDM_TeamProject.ViewModels;
using Microcharts.Maui;

namespace PDM_TeamProject
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMicrocharts()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif
            //Services
            builder.Services.AddSingleton<ReviewService>();

            //Views
            builder.Services.AddSingleton<ReviewList>();
            builder.Services.AddTransient<AddReview>();

            //View Models
            builder.Services.AddSingleton<ReviewsViewModel>();
            builder.Services.AddTransient<AddReviewViewModel>();

            return builder.Build();
        }
    }
}   