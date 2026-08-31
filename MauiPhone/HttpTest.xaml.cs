using Domain;
using System.Net.Http.Json;

namespace MauiPhone;

public partial class HttpTest : ContentPage
{
    private readonly HttpClient _httpClient;
    public string kosiliceString { get; set; }
    public string ostaveString { get; set; }
    public string poslovniPartneriString { get; set; }

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


            kosilice.ForEach((k) =>
            {
                kosiliceString += k.Model + " - " + k.Boja + '\n';
            });

            ostave.ForEach((o) =>
            {
                ostaveString += o.KorisnickoIme + " - " + o.DatumOtvaranja.ToString("d") + '\n';
            });

            pp.ForEach((p) =>
            {
                poslovniPartneriString += p.Ime + " " + p.Prezime + '\n';
            });

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

    private async void OnKosiliceLabelClicked(object sender, TappedEventArgs e)
    {
        if(KosiliceLabel.Text != "0")
        {
            await DisplayAlert("Kosilice", kosiliceString.ToString(), "OK");
        }
    }

    private async void OnPoslovniPartneriLabelClicked(object sender, TappedEventArgs e)
    {
        if (KosiliceLabel.Text != "0")
        {
            await DisplayAlert("Poslovni partneri", poslovniPartneriString.ToString(), "OK");
        }
    }

    private async void OnOstaveLabelClicked(object sender, TappedEventArgs e)
    {
        if (KosiliceLabel.Text != "0")
        {
            await DisplayAlert("Ostave", ostaveString.ToString(), "OK");
        }
    }
}