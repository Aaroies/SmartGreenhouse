using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace SmartGreenhouse.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string? _username;
        private string? _password;
        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLogin);
        }

        public string? Username { get => _username; set => Set(ref _username, value); }
        public string? Password { get => _password; set => Set(ref _password, value); }

        private async void OnLogin()
        {
            if (Username == "admin" && Password == "password")
            {
                await Application.Current.MainPage.Navigation.PushAsync(new Views.DashboardPage());
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Login failed", "Use admin / password", "OK");
            }
        }
    }
}
