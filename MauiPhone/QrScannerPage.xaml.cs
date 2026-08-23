using ZXing.Net.Maui;

namespace MauiPhone;

public partial class QrScannerPage : ContentPage
{
    public QrScannerPage()
    {
        InitializeComponent();

        CameraView.Options = new BarcodeReaderOptions
        {
            Formats = BarcodeFormats.TwoDimensional,
            AutoRotate = true,
            Multiple = false
        };
    }

    private void CameraView_BarcodesDetected(
        object sender,
        BarcodeDetectionEventArgs e)
    {
        var result = e.Results.FirstOrDefault();

        if (result == null)
            return;

        MainThread.BeginInvokeOnMainThread(async () =>
        {
            CameraView.IsDetecting = false;

            if (Uri.TryCreate(result.Value, UriKind.Absolute, out Uri? uri) &&
                (uri.Scheme == Uri.UriSchemeHttp ||
                 uri.Scheme == Uri.UriSchemeHttps))
            {
                ResultLabel.Text = result.Value;

                await DisplayAlert(
                    "QR Kod je skeniran",
                    "Dodaj kosilicu!",
                    "OK");
            }
            else
            {
                ResultLabel.Text = result.Value;

                await DisplayAlert(
                    "QR KOd je skeniran",
                    result.Value,
                    "OK");
            }
        });
    }

    private async void ResultLabel_Tapped(object sender, EventArgs e)
    {
        if (Uri.TryCreate(ResultLabel.Text, UriKind.Absolute, out Uri? uri))
        {
            await Launcher.Default.OpenAsync(uri);
        }
    }
}