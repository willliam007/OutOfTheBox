using OutOfTheBox.ViewModels;

namespace OutOfTheBox.Pages;

public partial class RegisterPage : ContentPage
{
	public RegisterPage(RegisterViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
    }
}