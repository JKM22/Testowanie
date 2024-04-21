using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Biblioteka
{
    internal class ModyfikacjaUzytkownikaKlasa
    {
        private const string ConnectionString = "Server=localhost;Database=biblioteka;Uid=root;Pwd=;";
        public void DodajUzytkownika(string imie, string nazwisko, string email, string telefon, string miejscowosc, string kodPocztowy, string ulica, string nrPosesji, string nrLokalu, string pesel, string dataUrodzenia, string plec, string login, string haslo)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO uzytkownik (u_imie, u_nazwisko, u_email, u_telefon, u_miejscowosc, u_kod, u_ulica, u_nr_posesji, u_nr_lokalu, u_pesel, u_data_ur, u_plec, u_login, u_haslo) VALUES (@imie, @nazwisko, @email, @telefon, @miejscowosc, @kod, @ulica, @nr_posesji, @nr_lokalu, @pesel, @data_ur, @plec, @login, @haslo)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@imie", imie);
                        command.Parameters.AddWithValue("@nazwisko", nazwisko);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@telefon", telefon);
                        command.Parameters.AddWithValue("@miejscowosc", miejscowosc);
                        command.Parameters.AddWithValue("@kod", kodPocztowy);
                        command.Parameters.AddWithValue("@ulica", ulica);
                        command.Parameters.AddWithValue("@nr_posesji", nrPosesji);
                        command.Parameters.AddWithValue("@nr_lokalu", nrLokalu);
                        command.Parameters.AddWithValue("@pesel", pesel);
                        command.Parameters.AddWithValue("@data_ur", dataUrodzenia);
                        command.Parameters.AddWithValue("@plec", plec);
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@haslo", haslo);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }
        public void AktualizujDaneUzytkownika(string imie, string nazwisko, string email, string telefon, string miejscowosc, string kodPocztowy, string ulica, string nrPosesji, string nrLokalu, string pesel, string dataUrodzenia, string plec, string login, string haslo, string id_uzytkownik)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Uzytkownik SET u_imie=@Imie, u_nazwisko=@Nazwisko, u_email=@Email, u_telefon=@Telefon, u_miejscowosc=@Miejscowosc, u_kod=@KodPocztowy, u_ulica=@Ulica, u_nr_posesji=@NrPosesji, u_nr_lokalu=@NrLokalu, u_pesel=@Pesel, u_data_ur=@DataUrodzenia, u_plec=@Plec, u_login=@Login, u_haslo=@Haslo WHERE id_uzytkownik=@id_uzytkownik";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Imie", imie);
                        command.Parameters.AddWithValue("@Nazwisko", nazwisko);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Telefon", telefon);
                        command.Parameters.AddWithValue("@Miejscowosc", miejscowosc);
                        command.Parameters.AddWithValue("@KodPocztowy", kodPocztowy);
                        command.Parameters.AddWithValue("@Ulica", ulica);
                        command.Parameters.AddWithValue("@NrPosesji", nrPosesji);
                        command.Parameters.AddWithValue("@NrLokalu", nrLokalu);
                        command.Parameters.AddWithValue("@Pesel", pesel);
                        command.Parameters.AddWithValue("@DataUrodzenia", dataUrodzenia);
                        command.Parameters.AddWithValue("@Plec", plec);
                        command.Parameters.AddWithValue("@Login", login);
                        command.Parameters.AddWithValue("@Haslo", haslo);
                        command.Parameters.AddWithValue("@id_uzytkownik", id_uzytkownik);

                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("Zaktualizowano dane.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
            }
        }



    }
}

    