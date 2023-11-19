using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PDM_TeamProject.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDM_TeamProject.ViewModels
{
    [QueryProperty(nameof(AddReview), "AddReview")]
    public partial class AddReviewViewModel : ObservableObject
    {
        [ObservableProperty]
        public Review reviewDetails;

        private readonly ReviewService _reviewService;
        public AddReviewViewModel( ReviewService reviewService)
        {
            _reviewService = reviewService;
            ReviewDetails = new Review();
             
        }

        [RelayCommand]
        public async void AddReview()
        {
            var response = await _reviewService.AddReview(reviewDetails); 
            if (response > 0)
            {
                await Shell.Current.DisplayAlert("Record Added", "Review Details successfully submitted", "OK");
            }
            else
            {
                await Shell.Current.DisplayAlert("Not Added", "Something went wrong", "OK");
            }
            await Shell.Current.GoToAsync("..");

        }


    }
}
