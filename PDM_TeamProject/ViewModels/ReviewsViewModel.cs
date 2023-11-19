using CommunityToolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using PDM_TeamProject.Classes;
using PDM_TeamProject.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDM_TeamProject.ViewModels
{
    public partial class ReviewsViewModel : ObservableObject
    {
        public ObservableCollection<Review> Reviews { get; set; } = new ObservableCollection<Review>();

        public readonly ReviewService _reviewService;

        public ReviewsViewModel(ReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [ICommand]
        public async void GetReviewsList()
        {
            var reviews = await _reviewService.GetEmployeesList();
            if(reviews?.Count() > 0)
            {
                Reviews.Clear();
                foreach(var review in reviews)
                {
                    Reviews.Add(review);
                }
            }
        }

        [RelayCommand]
        public async void AddUpdateReview()
        {
            await AppShell.Current.GoToAsync(nameof(AddReview));
        }

        [RelayCommand]
        public async void DisplayAction(Review review)
        {

            var response = await AppShell.Current.DisplayActionSheet("Select option", null, "Edit", "Delete");

            if (response == "Edit")
            {
                var navParam = new Dictionary<string, object>();
                navParam.Add("addReview", review);

                await AppShell.Current.GoToAsync(nameof(AddReview), navParam);
            }
            if (response == "Delete")
            {
                var deleteResponse = await _reviewService.DeleteReview(review);

                if (deleteResponse > 0)
                {
                    GetReviewsList();
                }
            }
        }
    }
}
