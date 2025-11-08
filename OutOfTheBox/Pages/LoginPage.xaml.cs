using OutOfTheBox.ViewModels;

namespace OutOfTheBox.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;	
    }
}