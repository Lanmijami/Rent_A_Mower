using Domain;
using System.Text;
using System.Text.Json;
using ZXing.Net.Maui;

namespace MauiPhone;

public partial class QrScannerPage : ContentPage
{
    public Kosilica jsonKosilica { get; set; }
    private readonly HttpClient _httpClient;
    public QrScannerPage()
    {
        InitializeComponent();
        AddKosilicaBtn.IsEnabled = false;
        AddKosilicaBtn.BackgroundColor = Colors.Gray;
        _httpClient = new HttpClient();

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

                await DisplayAlert(
                    "QR Kod je skeniran",
                    "Dodaj kosilicu!",
                    "OK");
            }
            else
            {
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var jsonObject = JsonSerializer.Deserialize<Kosilica>(result.Value, options);
                jsonKosilica = jsonObject;

                // Safely retrieve the model string or provide a fallback if null
                string modelText = jsonObject?.Model?.ToString() ?? "Nepoznat model / Neispravan JSON";

                await DisplayAlert(
                    "QR KOd je skeniran",
                    modelText,
                    "OK");

                AddKosilicaBtn.IsEnabled = true;
                AddKosilicaBtn.BackgroundColor = Colors.MediumPurple;
            }
        });
    }

    private async void AddKosilica(object sender, EventArgs e)
    {
        string jsonString = JsonSerializer.Serialize(jsonKosilica);
        using var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

        using var httpClient = new HttpClient();
        HttpResponseMessage response = await httpClient.PostAsync("http://192.168.0.47:7109/kosilica", content);

        if (response.IsSuccessStatusCode)
        {
            string responseBody = await response.Content.ReadAsStringAsync();
            await DisplayAlert("Uspeh!", jsonKosilica.Model + " je dodata!", "OK");
        }
        else
        {
            await DisplayAlert("Greska!", response.StatusCode.ToString(), "OK");
        }
    }
}