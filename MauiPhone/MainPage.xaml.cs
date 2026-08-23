using Domain;

namespace MauiPhone
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Redirect(object sender, EventArgs e)
        {
            //DisplayAlert("Clicked", "You've clicked a button", "Ok");
            //Controller.Instance.PrijaviOstava

            await Shell.Current.GoToAsync("QrScannerPage");
        }

        private async void HttpRedirect(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("HttpTest");
        }
    }

}
