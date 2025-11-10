using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using OutOfTheBox.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutOfTheBox.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _username = string.Empty;

        [ObservableProperty]
        private string _password = string.Empty;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(PasswordIcon))]
        private bool _isPassword = true;

        [ObservableProperty]
        private bool _isLoggingIn;

        public string PasswordIcon => IsPassword ? "eyeclosed.png" : "eye.png";

        [RelayCommand]
        private void TogglePasswordVisibility()
        {
            IsPassword = !IsPassword;
        }

        [RelayCommand]
        private async Task NavigationToRegisterpageAsync()
        {
            await Shell.Current.GoToAsync(nameof(RegisterPage));
        }

        [RelayCommand]
        private async Task LoginAsync()
        {
            if (IsLoggingIn)
                return;

            IsLoggingIn = true;

            // Simule un appel réseau
            await Task.Delay(2000);

            //Login validation 
            //api consommation

            await Shell.Current.GoToAsync($"//{nameof(MainPage)}");

            IsLoggingIn = false;
        }
    }
}
