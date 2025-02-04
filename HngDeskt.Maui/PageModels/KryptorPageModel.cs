using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HngDeskt.Maui.Services;

namespace HngDeskt.Maui.PageModels
{
    public partial class KryptorPageModel : ObservableObject
    {
        [ObservableProperty]
        private string inputText;

        [ObservableProperty]
        private string key;

        [ObservableProperty]
        private string encryptedText;

        [ObservableProperty]
        private string decryptedText;



        [RelayCommand]
        public async Task Encrypt()
        {
            if (!string.IsNullOrEmpty(InputText) && !string.IsNullOrEmpty(Key))
            {
                EncryptedText = CustomEncryptor.Encrypt(InputText, Key);
            }
            else
            {

                await Shell.Current.DisplayAlert("Error", "Ensure you've provided the text and your secrete key", "Ok");
            }
        }

        [RelayCommand]
        public async Task Decrypt()
        {
            if (!string.IsNullOrEmpty(EncryptedText) && !string.IsNullOrEmpty(Key))
            {

                try
                {
                    DecryptedText = CustomEncryptor.Decrypt(EncryptedText, Key);

                }
                catch
                {
                    await Shell.Current.DisplayAlert("Error", "Ensure you provided a valid base64 encoded encryption string", "Ok");
                }
            }
            else
            {


                await Shell.Current.DisplayAlert("Error", "Ensure you've provided the encrypted text and your secrete key", "Ok");
            }

        }
    }
}
