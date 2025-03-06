using CRUDMVVM.ViewModels;

namespace CRUDMVVM.Views;

public partial class MainView : ContentPage
{
	private MainViewModel viewModel;
	public MainView()
	{
		InitializeComponent();
        viewModel = new MainViewModel();
        this.BindingContext = viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        viewModel.GetAll();
    }
}