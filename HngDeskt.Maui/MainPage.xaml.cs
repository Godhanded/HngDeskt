namespace HngDeskt.Maui
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OpenGitHub(object sender, EventArgs e)
        {
            string url = "https://github.com/YourRepoHere";
            await Launcher.OpenAsync(url);
        }

        private async void OpenHNGHire(object sender, EventArgs e)
        {
            string url = "https://hng.tech/hire/mobile-developers";
            await Launcher.OpenAsync(url);
        }

        private async void OpenTelex(object sender, EventArgs e)
        {
            string url = "https://telex.hng.tech";
            await Launcher.OpenAsync(url);
        }

        private async void OpenDelve(object sender, EventArgs e)
        {
            string url = "https://delve.hng.tech";
            await Launcher.OpenAsync(url);
        }
    }

}
