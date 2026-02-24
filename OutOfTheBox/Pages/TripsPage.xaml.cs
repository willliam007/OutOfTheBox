using OutOfTheBox.ViewModels;

namespace OutOfTheBox.Pages;

public partial class TripsPage : ContentPage
{
	public TripsPage(TripViewModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}