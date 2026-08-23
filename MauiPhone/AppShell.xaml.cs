namespace MauiPhone
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("HttpTest", typeof(HttpTest));
            Routing.RegisterRoute("QrScannerPage", typeof(QrScannerPage));
        }
    }
}
