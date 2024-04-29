using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Net;
using System.Net.Mail;
using System.Linq;
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

            if (polaczenie.UpdatePassword(email, newPassword, true))
            {
                SendEmail(newPassword);
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
            bool walidacja_pass = false;
            do
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
                //walidacja
                bool hasUpperCase = shuffledPassword.Any(char.IsUpper);
                bool hasLowerCase = shuffledPassword.Any(char.IsLower);
                bool hasDigit = shuffledPassword.Any(char.IsDigit);
                bool hasSpecialChar = shuffledPassword.Any(ch => !char.IsLetterOrDigit(ch));

                if (shuffledPassword.Length == 10)
                {
                    walidacja_pass = false;
                }
                else if (!hasUpperCase || !hasLowerCase || !hasDigit || !hasSpecialChar)
                {
                    walidacja_pass = false;
                }
                else
                {
                    walidacja_pass = true;
                }
                return shuffledPassword;
            } while (walidacja_pass == false);
        }

        private void SendEmail(string newPassword)
        {
                var fromMail = new MailAddress("bibliotekapasswordreset@outlook.com", "Zmiana hasła biblioteka");
                var toMail = new MailAddress(textBoxEmail.Text);

                string subject = "Resetowanie Hasła";
                string body = $"Twoje nowe hasło to: {newPassword}";

                string email = "bibliotekapasswordreset@outlook.com";
                string haslo = "alamakota123";
                string Host = "smtp.office365.com";
                int Port = 587;

                using (MailMessage mail = new MailMessage(fromMail.ToString(), toMail.ToString(), subject, body))
                {
                    using (SmtpClient smtp = new SmtpClient(Host, Port))
                    {
                        smtp.UseDefaultCredentials = false;
                        smtp.EnableSsl = true;
                        smtp.Credentials = new NetworkCredential(email, haslo);
                        smtp.Send(mail);
                        MessageBox.Show("Hasło zostało zresetowane. \n" +
                            "Wiadomość została wysłana na adres email, w przypadku braku wiadomości sprawdź spam.", "Success");
                    }
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
