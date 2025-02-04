using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace HngDeskt.Maui.PageModels
{
    public partial class MainPageModel : ObservableObject
    {

        [ObservableProperty]
        bool _isRefreshing;

        [ObservableProperty]
        private string _today = DateTime.Now.ToString("g");

        [RelayCommand]
        private async Task OpenGitHub()
        {
            string url = "https://github.com/Godhanded/HngDeskt";
            await Launcher.OpenAsync(url);
        }

        [RelayCommand]
        private async Task OpenHNGHire()
        {
            string url = "https://hng.tech/hire/mobile-developers";
            await Launcher.OpenAsync(url);
        }

        [RelayCommand]
        private async Task OpenTelex()
        {
            string url = "https://telex.hng.tech";
            await Launcher.OpenAsync(url);
        }

        [RelayCommand]
        private async Task OpenDelve()
        {
            string url = "https://delve.hng.tech";
            await Launcher.OpenAsync(url);
        }

        [RelayCommand]
        private async Task Refresh()
        {
            try
            {
                IsRefreshing = true;
                await Task.Delay(500);
            }
            catch (Exception e)
            {

            }
            finally
            {
                IsRefreshing = false;
            }
        }
    }
}
