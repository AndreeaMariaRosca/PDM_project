using PDM_TeamProject.ViewModels;

namespace PDM_TeamProject.Pages;

[QueryProperty(nameof(ReviewId), nameof(reviewId))]
public partial class AddReview : ContentPage
{
    public AddReviewViewModel vm;
    public AddReview(AddReviewViewModel viewModel)
    {
        // InitializeComponent();

        this.BindingContext = vm = viewModel;
    }

    public string reviewId { get; set; }
    public string ReviewId
    {
        get => reviewId;
        set
        {
            reviewId = value;
            /*BindingContext = vm = new AddReviewViewModel(int.Parse(Uri.UnescapeDataString(value)));*/
        }
    }
}