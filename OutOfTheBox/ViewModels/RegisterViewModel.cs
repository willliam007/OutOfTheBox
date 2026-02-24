using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using OutOfTheBox.Pages;
using System.Threading.Tasks;

namespace OutOfTheBox.ViewModels
{
    public partial class RegisterViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _username = string.Empty;

        [ObservableProperty]
        private string _email = string.Empty;

        [ObservableProperty]
        private string _password = string.Empty;

        [ObservableProperty]
        private bool _isLoggingIn;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(PasswordIcon))]
        private bool _isPassword = true;

        public string PasswordIcon => IsPassword ? "eyeclosed.png" : "eye.png";

        [RelayCommand]
        private void TogglePasswordVisibility()
        {
            IsPassword = !IsPassword;
        }

        [RelayCommand]
        private async Task NavigationToLoginPageAsync()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
