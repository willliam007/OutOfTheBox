using OutOfTheBox.Pages;

namespace OutOfTheBox
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(RegisterPage),typeof(RegisterPage)); 
        }
    }
}
