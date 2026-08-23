using Domain;
using System.Net.Http.Json;

namespace MauiPhone;

public partial class HttpTest : ContentPage
{
    private readonly HttpClient _httpClient;

    public HttpTest()
    {
        InitializeComponent();

        _httpClient = new HttpClient();
    }

    private async void OnGetKosiliceClicked(object sender, EventArgs e)
    {
        try
        {
            string url = "http://192.168.0.49:7109/Kosilica";
            //string url = "http://localhost:7109/Kosilica";

            var kosilice = await _httpClient
                .GetFromJsonAsync<List<Kosilica>>(url);

            if (kosilice != null)
            {
                ResultLabel.Text = $"Postoji {kosilice.Count} kosilica.";
            }
        }
        catch (Exception ex)
        {
            ResultLabel.Text = ex.ToString();
        }
    }
}