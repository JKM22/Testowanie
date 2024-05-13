-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Maj 14, 2024 at 12:59 AM
-- Wersja serwera: 10.4.32-MariaDB
-- Wersja PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `biblioteka`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `hasla`
--

CREATE TABLE `hasla` (
  `id_hasla` int(11) NOT NULL,
  `id_uzytkownik` int(11) NOT NULL,
  `haslo` varchar(255) NOT NULL,
  `czy_generowane` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `hasla`
--

INSERT INTO `hasla` (`id_hasla`, `id_uzytkownik`, `haslo`, `czy_generowane`) VALUES
(4, 7, 'QFrc#&Y3s1', 0),
(5, 7, 'kA*f4s-UT9', 0),
(6, 7, 'C$Sb&zJt40', 0),
(7, 7, 'nkLX$vM41#', 0),
(8, 7, 'MsuBx$*4R8', 0),
(9, 7, '*u1daCWI7-', 0),
(10, 7, 'w*06qBCjL*', 0),
(11, 7, '1JJ2#-mgrT', 1),
(12, 7, 'R7hqRh&$3P', 1),
(13, 7, '123Siema1!', 0),
(14, 7, 'yOzcZL0#-0', 1),
(15, 7, '1JJ2#-mgrT', 0),
(16, 7, '28Duh&#JmQ', 1),
(17, 7, '4qh3FVe*L$', 1),
(18, 7, 'nywW6H0$Z_', 1),
(19, 7, '#Z$chvCU90', 1),
(20, 7, 'Qtx55*NN*c', 1),
(21, 7, 'b&P-2mQ9kI', 1),
(22, 7, 'UXqk#$16Fx', 1),
(23, 7, '5T#n2Tc-xB', 1),
(24, 7, 'T4$hd_p6RR', 1),
(25, 7, 'un7R3&P&uF', 1),
(26, 7, '$5hB9j_LVx', 1),
(27, 7, '*KI4lFj4$k', 1),
(28, 7, '$5xZmm#J7H', 1);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `ksiazka`
--

CREATE TABLE `ksiazka` (
  `id_ksiazka` int(11) NOT NULL,
  `tytul` varchar(200) NOT NULL,
  `autor` varchar(200) NOT NULL,
  `gatunek` varchar(200) NOT NULL,
  `opis` varchar(1500) NOT NULL,
  `liczba_stron` int(11) NOT NULL,
  `wydawnictwo` varchar(200) NOT NULL,
  `rok_wydania` int(11) NOT NULL,
  `cena` int(11) NOT NULL,
  `liczba_sztuk` int(11) NOT NULL,
  `status` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `ksiazka`
--

INSERT INTO `ksiazka` (`id_ksiazka`, `tytul`, `autor`, `gatunek`, `opis`, `liczba_stron`, `wydawnictwo`, `rok_wydania`, `cena`, `liczba_sztuk`, `status`) VALUES
(1, 'Szeptucha', 'Anna Kozłowska', 'Fantasy', 'Wciągająca opowieść o młodej dziewczynie posiadającej nadnaturalne moce, która staje w obronie swojej wioski przed złowrogimi siłami.', 420, 'Fabryka Słów', 2023, 50, 1, 'Dostępna'),
(2, 'Pole grawitacyjne', 'Jacek Dukaj', 'Science fiction', 'Niezwykła podróż po alternatywnej historii Polski, gdzie technologia zmienia oblicze społeczeństwa.', 736, 'Wydawnictwo Literackie', 2022, 60, 100, 'Dostępna'),
(3, 'Słodki dom', 'Wojciech Chmielarz', 'Kryminał', 'Trzymający w napięciu thriller o zbrodni popełnionej w z pozoru spokojnej okolicy, której śledztwo odkrywa mroczne sekrety mieszkańców.', 360, 'Wydawnictwo Literackie', 2024, 40, 90, 'Niedostępna'),
(4, 'Zaginiona księga', 'Dan Brown', 'Thriller', 'Robert Langdon powraca, by rozwikłać zagadkę zniknięcia starożytnej księgi, która może zmienić bieg historii.', 512, 'C&T', 2023, 45, 70, 'Dostępna'),
(5, 'Nocna muzyka', 'Jojo Moyes', 'Literatura obyczajowa', 'Wzruszająca opowieść o miłości, marzeniach i przeznaczeniu, które prowadzi bohaterów przez życie pełne wyzwań i nieoczekiwanych zwrotów.', 480, 'Znak', 2023, 35, 120, 'Dostępna'),
(6, 'Ostatnia przysięga', 'Karolina Ramqvist', 'Literatura kobieca', 'Historia odkrywania siły, odwagi i determinacji przez kobietę, która zostaje samotną matką po śmierci męża.', 320, 'Wydawnictwo Literackie', 2024, 30, 60, 'Dostępna'),
(7, 'Synowie chaosu', 'Brandon Sanderson', 'Fantasy', 'Pierwszy tom nowej epickiej sagi fantasy, która przenosi czytelnika do świata pełnego magii, intryg i niebezpieczeństwa.', 800, 'Nasza Księgarnia', 2022, 65, 85, 'Niedostępna'),
(8, 'Władca Mroków', 'Andrzej Sapkowski', 'Fantasy', 'Kontynuacja sagi o Wiedźminie, która ponownie zabiera czytelnika do świata zamieszkałego przez potwory, magię i polityczne intrygi.', 560, 'SuperNowa', 2023, 55, 100, 'Dostępna'),
(9, 'Lament w przeciwgwieźdnej nocy', 'Liu Cixin', 'Science fiction', 'Niezwykła podróż przez kosmos, gdzie ludzkość staje w obliczu zagrożenia ze strony obcych cywilizacji i musi znaleźć sposób na przetrwanie.', 672, 'Wydawnictwo SQN', 2024, 60, 80, 'Niedostępna'),
(10, 'Wiatr zimy', 'Hannah Richell', 'Literatura obyczajowa', 'Poruszająca historia dwóch kobiet, których losy splatają się na tle zapierającego dech pejzażu Islandii.', 400, 'Czarna Owca', 2023, 43, 110, 'Dostępna');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `lista_rejestracji_ksiazek`
--

CREATE TABLE `lista_rejestracji_ksiazek` (
  `id_rejestracji` int(11) NOT NULL,
  `id_r_ksiazki` int(11) DEFAULT NULL,
  `data_rejestracji` timestamp NOT NULL DEFAULT current_timestamp(),
  `id_r_uzytkownika` int(11) DEFAULT NULL,
  `status_rejestracji` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `lista_rejestracji_ksiazek`
--

INSERT INTO `lista_rejestracji_ksiazek` (`id_rejestracji`, `id_r_ksiazki`, `data_rejestracji`, `id_r_uzytkownika`, `status_rejestracji`) VALUES
(1, 1, '2024-05-13 17:11:05', 1, 'Książka zarejestrowana'),
(2, 2, '2024-05-13 17:11:13', 1, 'Książka zarejestrowana'),
(3, 5, '2024-05-13 17:12:00', 1, 'Książka zarejestrowana'),
(4, 6, '2024-05-13 17:12:04', 1, 'Książka zarejestrowana'),
(5, 10, '2024-05-13 17:12:07', 1, 'Książka zarejestrowana'),
(6, 8, '2024-05-13 22:50:44', 1, 'Książka zarejestrowana');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `pary_uprawnienia`
--

CREATE TABLE `pary_uprawnienia` (
  `id_pary` int(11) NOT NULL,
  `id_uprawnienia` int(11) DEFAULT NULL,
  `id_uzytkownik` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `pary_uprawnienia`
--

INSERT INTO `pary_uprawnienia` (`id_pary`, `id_uprawnienia`, `id_uzytkownik`) VALUES
(85, 1, 1),
(86, 3, 2),
(87, 4, 3),
(88, 5, 9),
(89, 6, 10),
(90, 7, 10),
(91, 7, 9);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `pary_wypozyczenia`
--

CREATE TABLE `pary_wypozyczenia` (
  `id_w_pary` int(11) NOT NULL,
  `id_wypozyczenia` int(11) NOT NULL,
  `id_ksiazki` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `pary_wypozyczenia`
--

INSERT INTO `pary_wypozyczenia` (`id_w_pary`, `id_wypozyczenia`, `id_ksiazki`) VALUES
(16, 18, 6),
(17, 19, 2);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `uprawnienia`
--

CREATE TABLE `uprawnienia` (
  `id_uprawnienia` int(11) NOT NULL,
  `uprawnienia` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `uprawnienia`
--

INSERT INTO `uprawnienia` (`id_uprawnienia`, `uprawnienia`) VALUES
(1, 'Administrator'),
(2, 'Użytkownik zalogowany'),
(3, 'Zmień uprawnienia'),
(4, 'Modyfikacja użytkownika'),
(5, 'Rejestracja książek'),
(6, 'Lista rejestracji książek'),
(7, 'Lista książek'),
(8, 'Rejestracja wypożyczeń');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `uzytkownik`
--

CREATE TABLE `uzytkownik` (
  `id_uzytkownik` int(11) NOT NULL,
  `u_imie` varchar(70) NOT NULL,
  `u_nazwisko` varchar(150) NOT NULL,
  `u_email` varchar(255) NOT NULL,
  `u_telefon` int(9) NOT NULL,
  `u_miejscowosc` varchar(200) NOT NULL,
  `u_kod` varchar(10) NOT NULL,
  `u_ulica` varchar(200) DEFAULT NULL,
  `u_nr_posesji` varchar(200) NOT NULL,
  `u_nr_lokalu` varchar(200) DEFAULT NULL,
  `u_pesel` varchar(11) NOT NULL,
  `u_data_ur` date NOT NULL,
  `u_plec` varchar(10) NOT NULL,
  `u_login` varchar(100) NOT NULL,
  `u_haslo` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_polish_ci;

--
-- Dumping data for table `uzytkownik`
--

INSERT INTO `uzytkownik` (`id_uzytkownik`, `u_imie`, `u_nazwisko`, `u_email`, `u_telefon`, `u_miejscowosc`, `u_kod`, `u_ulica`, `u_nr_posesji`, `u_nr_lokalu`, `u_pesel`, `u_data_ur`, `u_plec`, `u_login`, `u_haslo`) VALUES
(1, 'Jakub', 'Kowalski', 'mail@mail.com', 123456789, 'Rogów', '00-001', 'ul. Wielka', '33', NULL, '73110743682', '1994-03-09', 'Kobieta', 'kubakowal123', 'password111'),
(2, 'Joanna', 'Wilk', 'mail123@mail.com', 987654321, 'Warszawa', '00-002', 'ul. Łódzka', '14', '21', '00220879196', '2004-08-20', 'Kobieta', 'asiaaisa', 'password222'),
(3, 'Mariusz', 'Pudzianowski', 'pudzian@mail.com', 123123123, 'Poznań', '00-003', 'ul. Mała', '12', NULL, '87080361313', '1997-02-07', 'Mężczyzna', 'pudzianator', 'password333'),
(4, 'Test', 'Testowy', 'test@testmail.com', 123456789, 'Test', '00-001', 'Testowa', '3', '3', '73110743682', '1994-03-09', 'Kobieta', 'Test', 'Testpassword'),
(7, 'Renata', 'Gołąbek', 'bibliotekapasswordreset@outlook.com', 129098188, 'Warszawa', '12-123', 'Ptasia', '12', '98', '12345678909', '2004-04-11', '1', 'golab', '$5xZmm#J7H'),
(9, 'Janina', 'Nowak', 'bibliotekarz@gmail.com', 111222333, 'Łódź', '00-004', 'Piotrkowska', '22', '2', '67040212348', '1967-04-02', 'Kobieta', 'bibliotekarz', 'Bibliotekarz@'),
(10, 'Jan', 'Kot', 'jankot@gmail.com', 222111333, 'Warszawa', '00-008', 'Jutrzennki', '1', '2', '76111512336', '1976-11-15', 'Mężczyzna', 'jankot', 'Manager1@');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `wypozyczenia`
--

CREATE TABLE `wypozyczenia` (
  `id_wypozyczenia` int(11) NOT NULL,
  `w_imie` varchar(100) NOT NULL,
  `w_nazwisko` varchar(100) NOT NULL,
  `w_adres` varchar(200) NOT NULL,
  `w_telefon` int(9) NOT NULL,
  `w_dataWypozyczenia` timestamp NULL DEFAULT NULL,
  `w_okresWypozyczenia` int(11) DEFAULT NULL,
  `w_dataZwrotu` timestamp NULL DEFAULT current_timestamp(),
  `w_statusWypozyczenia` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `wypozyczenia`
--

INSERT INTO `wypozyczenia` (`id_wypozyczenia`, `w_imie`, `w_nazwisko`, `w_adres`, `w_telefon`, `w_dataWypozyczenia`, `w_okresWypozyczenia`, `w_dataZwrotu`, `w_statusWypozyczenia`) VALUES
(18, 'Jan', 'Kolo', 'warszawa', 3, '2024-05-13 22:37:45', 14, '2024-05-27 22:37:45', 'Nowe'),
(19, 'Janina', 'Kowalska', 'lodz ', 123456789, '2024-05-13 22:46:53', 14, '2024-05-27 22:46:53', 'Nowe');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `hasla`
--
ALTER TABLE `hasla`
  ADD PRIMARY KEY (`id_hasla`),
  ADD KEY `id_uzytkownik` (`id_uzytkownik`);

--
-- Indeksy dla tabeli `ksiazka`
--
ALTER TABLE `ksiazka`
  ADD PRIMARY KEY (`id_ksiazka`);

--
-- Indeksy dla tabeli `lista_rejestracji_ksiazek`
--
ALTER TABLE `lista_rejestracji_ksiazek`
  ADD PRIMARY KEY (`id_rejestracji`),
  ADD KEY `id_r_ksiazki` (`id_r_ksiazki`),
  ADD KEY `id_r_uzytkownika` (`id_r_uzytkownika`);

--
-- Indeksy dla tabeli `pary_uprawnienia`
--
ALTER TABLE `pary_uprawnienia`
  ADD PRIMARY KEY (`id_pary`),
  ADD KEY `id_uprawnienia` (`id_uprawnienia`),
  ADD KEY `id_uzytkownik` (`id_uzytkownik`);

--
-- Indeksy dla tabeli `pary_wypozyczenia`
--
ALTER TABLE `pary_wypozyczenia`
  ADD PRIMARY KEY (`id_w_pary`),
  ADD KEY `fk_pw_wypozyczenia` (`id_wypozyczenia`),
  ADD KEY `fk_pw_ksiazka` (`id_ksiazki`);

--
-- Indeksy dla tabeli `uprawnienia`
--
ALTER TABLE `uprawnienia`
  ADD PRIMARY KEY (`id_uprawnienia`);

--
-- Indeksy dla tabeli `uzytkownik`
--
ALTER TABLE `uzytkownik`
  ADD PRIMARY KEY (`id_uzytkownik`);

--
-- Indeksy dla tabeli `wypozyczenia`
--
ALTER TABLE `wypozyczenia`
  ADD PRIMARY KEY (`id_wypozyczenia`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `hasla`
--
ALTER TABLE `hasla`
  MODIFY `id_hasla` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT for table `lista_rejestracji_ksiazek`
--
ALTER TABLE `lista_rejestracji_ksiazek`
  MODIFY `id_rejestracji` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `pary_uprawnienia`
--
ALTER TABLE `pary_uprawnienia`
  MODIFY `id_pary` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=92;

--
-- AUTO_INCREMENT for table `pary_wypozyczenia`
--
ALTER TABLE `pary_wypozyczenia`
  MODIFY `id_w_pary` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `uzytkownik`
--
ALTER TABLE `uzytkownik`
  MODIFY `id_uzytkownik` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `wypozyczenia`
--
ALTER TABLE `wypozyczenia`
  MODIFY `id_wypozyczenia` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `hasla`
--
ALTER TABLE `hasla`
  ADD CONSTRAINT `hasla_ibfk_1` FOREIGN KEY (`id_uzytkownik`) REFERENCES `uzytkownik` (`id_uzytkownik`);

--
-- Constraints for table `lista_rejestracji_ksiazek`
--
ALTER TABLE `lista_rejestracji_ksiazek`
  ADD CONSTRAINT `lista_rejestracji_ksiazek_ibfk_1` FOREIGN KEY (`id_r_ksiazki`) REFERENCES `ksiazka` (`id_ksiazka`),
  ADD CONSTRAINT `lista_rejestracji_ksiazek_ibfk_2` FOREIGN KEY (`id_r_uzytkownika`) REFERENCES `uzytkownik` (`id_uzytkownik`);

--
-- Constraints for table `pary_uprawnienia`
--
ALTER TABLE `pary_uprawnienia`
  ADD CONSTRAINT `pary_uprawnienia_ibfk_1` FOREIGN KEY (`id_uprawnienia`) REFERENCES `uprawnienia` (`id_uprawnienia`),
  ADD CONSTRAINT `pary_uprawnienia_ibfk_2` FOREIGN KEY (`id_uzytkownik`) REFERENCES `uzytkownik` (`id_uzytkownik`);

--
-- Constraints for table `pary_wypozyczenia`
--
ALTER TABLE `pary_wypozyczenia`
  ADD CONSTRAINT `fk_pw_ksiazka` FOREIGN KEY (`id_ksiazki`) REFERENCES `ksiazka` (`id_ksiazka`),
  ADD CONSTRAINT `fk_pw_wypozyczenia` FOREIGN KEY (`id_wypozyczenia`) REFERENCES `wypozyczenia` (`id_wypozyczenia`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
