using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Biblioteka.Moduł_4
{
    public class WypozyczeniaKsiazekKlasa
    {
        private const string ConnectionString = "Server=localhost;Database=biblioteka;Uid=root;Pwd=;";

        public void DodajWypozyczenie(string imie, string nazwisko, string adres, string numerTelefonu, int ksiazkaId, DateTime dataWypozyczenia, int okresWypozyczenia)
        {
            
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    DateTime dataZwrotu = dataWypozyczenia.AddDays(okresWypozyczenia);

                    // Zapis do tabeli wypozyczenia
                    string queryWypozyczenia = "INSERT INTO wypozyczenia (w_imie, w_nazwisko, w_adres, w_telefon, w_dataWypozyczenia, w_okresWypozyczenia, w_dataZwrotu, w_statusWypozyczenia) " +
                           "VALUES (@Imie, @Nazwisko, @Adres, @Telefon, @DataWypozyczenia, @OkresWypozyczenia, @DataZwrotu, 'Nowe')";


                    using (MySqlCommand commandWypozyczenia = new MySqlCommand(queryWypozyczenia, connection))
                    {
                        commandWypozyczenia.Parameters.AddWithValue("@Imie", imie);
                        commandWypozyczenia.Parameters.AddWithValue("@Nazwisko", nazwisko);
                        commandWypozyczenia.Parameters.AddWithValue("@Adres", adres);
                        commandWypozyczenia.Parameters.AddWithValue("@Telefon", numerTelefonu);
                        commandWypozyczenia.Parameters.AddWithValue("@DataWypozyczenia", dataWypozyczenia);
                        commandWypozyczenia.Parameters.AddWithValue("@OkresWypozyczenia", okresWypozyczenia);
                        commandWypozyczenia.Parameters.AddWithValue("@DataZwrotu", dataZwrotu);



                        commandWypozyczenia.ExecuteNonQuery();

                        // Pobierz ID nowo wstawionego wypożyczenia
                        long wypozyczenieId;
                        string getLastInsertedIdQuery = "SELECT LAST_INSERT_ID();";
                        using (MySqlCommand commandGetLastInsertedId = new MySqlCommand(getLastInsertedIdQuery, connection))
                        {
                            wypozyczenieId = Convert.ToInt32(commandGetLastInsertedId.ExecuteScalar());
                        }

                        // Zapis do tabeli biblioteka_pary_wypozyczenia
                        string queryParyWypozyczenia = "INSERT INTO pary_wypozyczenia (id_wypozyczenia, id_ksiazki) " +
                                "VALUES (@IdWypozyczenia, @IdKsiazki)";

                        using (MySqlCommand commandParyWypozyczenia = new MySqlCommand(queryParyWypozyczenia, connection))
                        {
                            commandParyWypozyczenia.Parameters.AddWithValue("@IdWypozyczenia", wypozyczenieId);
                            commandParyWypozyczenia.Parameters.AddWithValue("@IdKsiazki", ksiazkaId);

                            commandParyWypozyczenia.ExecuteNonQuery();
                        }


                       
                    }

                    // Po zapisie pomyślnym możesz wyświetlić komunikat
                    Console.WriteLine("Wypożyczenie zarejestrowane pomyślnie!");
                }
                catch (Exception ex)
                {
                    // Obsługa błędu, np. logowanie lub zgłoszenie użytkownikowi
                    Console.WriteLine("Błąd podczas zapisu do bazy danych: " + ex.Message);
                    throw; // Możesz rzucać wyjątek dalej dla obsługi w innym miejscu
                }
            }
        }

    }
}
    
