using PDM_TeamProject.ViewModels;

namespace PDM_TeamProject.Pages;

public partial class ReviewList : ContentPage
{
    public ReviewsViewModel _viewModel;

    public ReviewList(ReviewsViewModel viewModel)
    {
        InitializeComponent();

        _viewModel = viewModel;

        this.BindingContext = viewModel;
    }

    protected override void OnAppearing()
    {
        _viewModel.GetReviewsListCommand.Execute(null);
    }

}