using SmartGreenhouse.Views;

namespace SmartGreenhouse.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry?.Text?.Trim() ?? "";
            string password = PasswordEntry?.Text?.Trim() ?? "";

            if (username == "admin" && password == "password")
            {
                await DisplayAlert("Success", "Login Successful!", "OK");
                await Navigation.PushAsync(new DashboardPage());
            }
            else
            {
                await DisplayAlert("Login failed", "Use admin / password", "OK");
            }
        }
    }
}
