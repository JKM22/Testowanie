using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Biblioteka
{
    public partial class OdzyskiwanieHasla : KryptonForm
    {
        private PolaczenieBazyKlasa polaczenie = new PolaczenieBazyKlasa();

        public OdzyskiwanieHasla()
        {
            InitializeComponent();
        }

        private void OdzyskiwanieHasla_Load(object sender, EventArgs e)
        {
        }

        private async void buttonSendEmail_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string newPassword = GeneratePassword();

            if (!polaczenie.UserExists(email, textBoxLogin.Text))
            {
                MessageBox.Show("Nieprawidłowy adres email lub login.");
                return;
            }

            if (polaczenie.UpdatePassword(email, newPassword))
            {
                await SendEmailAsync(email, "New Password", $"Your new password is: {newPassword}");
                this.Hide();
                Login loginForm = new Login();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Wystąpił problem podczas zmiany hasła. Spróbuj ponownie później.");
            }
        }

        private string GeneratePassword()
        {
            string uppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercaseLetters = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialCharacters = "-_!*#$&";

            Random random = new Random();

            string randomUppercase = new string(Enumerable.Repeat(uppercaseLetters, 3)
                                                          .Select(s => s[random.Next(s.Length)]).ToArray());
            string randomLowercase = new string(Enumerable.Repeat(lowercaseLetters, 3)
                                                          .Select(s => s[random.Next(s.Length)]).ToArray());
            string randomDigits = new string(Enumerable.Repeat(digits, 2)
                                                       .Select(s => s[random.Next(s.Length)]).ToArray());
            string randomSpecialCharacters = new string(Enumerable.Repeat(specialCharacters, 2)
                                                                  .Select(s => s[random.Next(s.Length)]).ToArray());

            string combinedCharacters = randomUppercase + randomLowercase + randomDigits + randomSpecialCharacters;

            string shuffledPassword = new string(combinedCharacters.ToCharArray().OrderBy(c => random.Next()).ToArray());

            return shuffledPassword;
        }

        private async Task SendEmailAsync(string recipient, string subject, string body)
        {
            try
            {
                var apiKey = "YourMailtrapApiKey"; // Zastąp swoim kluczem API Mailtrap
                var client = new HttpClient();
                client.DefaultRequestHeaders.Add("Api-Token", apiKey);

                var content = new StringContent($"{{\"recipient\":\"{recipient}\",\"subject\":\"{subject}\",\"body\":\"{body}\"}}");
                content.Headers.ContentType.MediaType = "application/json";

                var response = await client.PostAsync("https://mailtrap.io/api/v1/inboxes/YourInboxId/forward", content); // Zastąp swoim identyfikatorem skrzynki odbiorczej

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Hasło zostało wysłane na podany adres e-mailowy.");
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd podczas wysyłania wiadomości e-mail.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas wysyłania wiadomości e-mail: " + ex.Message);
            }
        }

        private void button_wroc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
