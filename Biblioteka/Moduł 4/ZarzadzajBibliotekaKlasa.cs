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

                    string query = @"INSERT INTO ksiazka (tytul, autor, gatunek, opis, liczba_stron, wydawnictwo, rok_wydania, cena, liczba_sztuk, status) " +
                           "VALUES (@tytul, @autor, @gatunek, @opis, @liczbaStron, @wydawnictwo, @rokWydania, @cena, @liczbaSztuk, @status)";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@tytul", tytul);
                    command.Parameters.AddWithValue("@autor", autor);
                    command.Parameters.AddWithValue("@gatunek", gatunek);
                    command.Parameters.AddWithValue("@opis", opis);
                    command.Parameters.AddWithValue("@liczbaStron", liczbaStron);
                    command.Parameters.AddWithValue("@wydawnictwo", wydawnictwo);
                    command.Parameters.AddWithValue("@rokWydania", rokWydania);
                    command.Parameters.AddWithValue("@cena", cena);
                    command.Parameters.AddWithValue("@liczbaSztuk", liczbaSztuk);
                    command.Parameters.AddWithValue("@status", "Niedostępna");
      

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

       public void EdytujKsiazke(int id, string tytul, string autor, string gatunek, string opis,
         int liczbaStron, string wydawnictwo, int rokWydania, decimal cena, int liczbaSztuk)
{
    try
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();
            string query = @"UPDATE ksiazka 
                             SET tytul=@tytul, autor=@autor, gatunek=@gatunek, opis=@opis, liczba_stron=@liczbaStron, 
                                 wydawnictwo=@wydawnictwo, rok_wydania=@rokWydania, cena=@cena, liczba_sztuk=@liczbaSztuk ";

            // Jeśli liczba sztuk wynosi 0, ustaw status na "Niedostępna"
            if (liczbaSztuk == 0)
            {
                query += ", status='Niedostępna' ";
            }

            query += "WHERE id_ksiazka=@id";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@tytul", tytul);
                command.Parameters.AddWithValue("@autor", autor);
                command.Parameters.AddWithValue("@gatunek", gatunek);
                command.Parameters.AddWithValue("@opis", opis);
                command.Parameters.AddWithValue("@liczbaStron", liczbaStron);
                command.Parameters.AddWithValue("@wydawnictwo", wydawnictwo);
                command.Parameters.AddWithValue("@rokWydania", rokWydania);
                command.Parameters.AddWithValue("@cena", cena);
                command.Parameters.AddWithValue("@liczbaSztuk", liczbaSztuk);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Książka została pomyślnie zaktualizowana.");
                }
                else
                {
                    Console.WriteLine("Nie udało się zaktualizować książki.");
                }
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Błąd: {ex.Message}");
        throw;
    }
}

    }
}
