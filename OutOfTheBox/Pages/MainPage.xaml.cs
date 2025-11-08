using OutOfTheBox.ViewModels;

namespace OutOfTheBox.Pages
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage(HomeViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        
    }

}
