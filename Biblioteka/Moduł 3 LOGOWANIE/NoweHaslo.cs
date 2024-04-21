using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Biblioteka
{
    public partial class NoweHaslo : KryptonForm
    {
        public NoweHaslo()
        {
            InitializeComponent();
        }

        private void NoweHaslo_Load(object sender, EventArgs e)
        {

        }
        private void buttonSavePass_Click(object sender, EventArgs e)
        {
            
        }

        // Metoda do walidacji hasła
        private bool ValidatePassword(string password)
        {
            // Sprawdzenie długości hasła
            if (password.Length < 8 || password.Length > 15)
            {
                return false;
            }

            // Sprawdzenie, czy hasło zawiera przynajmniej jedną dużą literę, małą literę, cyfrę i znak specjalny
            bool hasUpperCase = password.Any(char.IsUpper);
            bool hasLowerCase = password.Any(char.IsLower);
            bool hasDigit = password.Any(char.IsDigit);
            bool hasSpecialChar = password.Any(ch => !char.IsLetterOrDigit(ch));

            if (!hasUpperCase || !hasLowerCase || !hasDigit || !hasSpecialChar)
            {
                return false;
            }

            return true;
        }

        private void buttonSavePass_Click_1(object sender, EventArgs e)
        {
            string newPassword = textBoxNewPass.Text;
            string newPasswordRepeated = textBoxNewPass2.Text;

            // Walidacja nowego hasła
            if (!ValidatePassword(newPassword))
            {
                MessageBox.Show("Nowe hasło nie spełnia wymagań walidacji.");
                return;
            }

            // Sprawdzenie czy oba wpisane hasła się zgadzają
            if (newPassword != newPasswordRepeated)
            {
                MessageBox.Show("Wpisane hasła nie są identyczne.");
                return;
            }

            // Zapisanie nowego hasła w bazie danych
            PolaczenieBazyKlasa polaczenie = new PolaczenieBazyKlasa();
            string email = polaczenie.GetLoggedInUserEmail();
            if (polaczenie.UpdatePassword(email, newPassword, false)) // Ustaw flagę isGeneratedPassword na false
            {
                MessageBox.Show("Hasło zostało pomyślnie zmienione.");
                this.Close();
                Start start = new Start();
                start.Show();
            }
            else
            {
                MessageBox.Show("Wystąpił problem podczas zmiany hasła. Spróbuj ponownie później.");
            }
        }
    }
}
