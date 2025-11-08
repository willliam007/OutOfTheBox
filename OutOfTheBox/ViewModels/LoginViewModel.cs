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
        private  string _username;

        [ObservableProperty]
        private string _password;

        [RelayCommand]
        private async Task NavigationToRegisterpageAsync()
        {
            await Shell.Current.GoToAsync(nameof(RegisterPage));
        }

        [RelayCommand]
        private async Task LoginAsync()
        {
            //Login validation 
            //api consommation

            await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
        }
    }
}
