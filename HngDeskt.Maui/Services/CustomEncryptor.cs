using System.Text;

namespace HngDeskt.Maui.Services
{
    public static class CustomEncryptor
    {
        public static string Encrypt(string input, string key)
        {
            if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(key))
                throw new ArgumentException("Input and key must not be empty");

            StringBuilder encryptedText = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                char encryptedChar = (char)(input[i] + key[i % key.Length]);
                encryptedText.Append(encryptedChar);
            }
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(encryptedText.ToString()));
        }

        public static string Decrypt(string encryptedInput, string key)
        {
            if (string.IsNullOrEmpty(encryptedInput) || string.IsNullOrEmpty(key))
                throw new ArgumentException("Encrypted input and key must not be empty");

            string decodedText = Encoding.UTF8.GetString(Convert.FromBase64String(encryptedInput));
            StringBuilder decryptedText = new StringBuilder();
            for (int i = 0; i < decodedText.Length; i++)
            {
                char decryptedChar = (char)(decodedText[i] - key[i % key.Length]);
                decryptedText.Append(decryptedChar);
            }
            return decryptedText.ToString();
        }
    }
}
