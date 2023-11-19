using PDM_TeamProject.ViewModels;

namespace PDM_TeamProject.Pages;

public partial class AddReview : ContentPage
{
    public AddReviewViewModel vm;
    public AddReview(AddReviewViewModel viewModel)
    {
        InitializeComponent();

        this.BindingContext = vm = viewModel;
    }

    public string employeeId { get; set; }
    public string EmployeeId
    {
        get => employeeId;
        set
        {
            employeeId = value;
            //BindingContext = vm = new AddReviewViewModel(int.Parse(Uri.UnescapeDataString(value)));
        }
    }
}