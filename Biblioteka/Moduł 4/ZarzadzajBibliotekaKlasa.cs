using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
namespace Biblioteka.Moduł_4
{
    internal class ZarzadzajBibliotekaKlasa
    {
        private const string ConnectionString = "Server=localhost;Database=biblioteka;Uid=root;Pwd=;";

        public void DodajKsiazke(string tytul, string autor, string gatunek, string opis,
            int liczbaStron, string wydawnictwo, int rokWydania, decimal cena, int liczbaSztuk)
        {
            try
            {
                

                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = @"INSERT INTO ksiazka (tytul, autor, gatunek, opis, liczba_stron, wydawnictwo, rok_wydania, cena, liczba_sztuk)
                                    VALUES (@tytul, @autor, @gatunek, @opis, @liczba_stron, 
                                    @wydawnictwo, @rok_wydania, @cena, @liczba_sztuk)";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@tytul", tytul);
                    command.Parameters.AddWithValue("@autor", autor);
                    command.Parameters.AddWithValue("@gatunek", gatunek);
                    command.Parameters.AddWithValue("@opis", opis);
                    command.Parameters.AddWithValue("@liczba_stron", liczbaStron);
                    command.Parameters.AddWithValue("@wydawnictwo", wydawnictwo);
                    command.Parameters.AddWithValue("@rok_wydania", rokWydania);
                    command.Parameters.AddWithValue("@cena", cena);
                    command.Parameters.AddWithValue("@liczba_sztuk", liczbaSztuk);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Książka została pomyślnie dodana do bazy danych.");
                        
                    }

                    else
                    {
                        Console.WriteLine("Nie udało się dodać książki do bazy danych.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
                throw; // Przekaż wyjątek dalej, aby zapewnić pełniejsze informacje o błędzie
            }
        }
    }
}
