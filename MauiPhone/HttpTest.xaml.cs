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
        _ = functionBody();
    }

    private async void RefreshData(object sender, EventArgs e)
    {
        await functionBody();
    }

    private async Task functionBody()
    {
        try
        {
            string urlK = "http://192.168.0.47:7109/Kosilica";
            string urlPp = "http://192.168.0.47:7109/Ostava";
            string urlO = "http://192.168.0.47:7109/PoslovniPartner";

            var kosilice =
                await _httpClient.GetFromJsonAsync<List<Kosilica>>(urlK);

            var ostave =
                await _httpClient.GetFromJsonAsync<List<Ostava>>(urlPp);

            var pp =
                await _httpClient.GetFromJsonAsync<List<PoslovniPartner>>(urlO);

            KosiliceLabel.Text = kosilice?.Count.ToString();
            OstaveLabel.Text = ostave?.Count.ToString() ?? "0";
            PoslovniPartneriLabel.Text = pp?.Count.ToString() ?? "0";

            ResultLabel.Text = "Podaci uspešno učitani.";
        }
        catch (Exception ex)
        {
            ResultLabel.Text = ex.ToString();
        }
    }

    private async void OnGetDataClicked()
    {
       await functionBody();
    }
}