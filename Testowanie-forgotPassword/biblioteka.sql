-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 21, 2024 at 07:11 PM
-- Wersja serwera: 10.4.32-MariaDB
-- Wersja PHP: 8.2.12

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
-- Struktura tabeli dla tabeli `autor`
--

CREATE TABLE `autor` (
  `id_autor` int(11) NOT NULL,
  `imie` varchar(150) NOT NULL,
  `nazwisko` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_polish_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `gatunek`
--

CREATE TABLE `gatunek` (
  `id_gatunek` int(11) NOT NULL,
  `nazwa` varchar(70) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_polish_ci;

--
-- Dumping data for table `gatunek`
--

INSERT INTO `gatunek` (`id_gatunek`, `nazwa`) VALUES
(1, 'fantasy'),
(2, 'science fiction'),
(3, 'kryminał'),
(4, 'romans'),
(5, 'thriller'),
(6, 'słownik'),
(7, 'biografia'),
(8, 'komiks');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `hasla_generowane`
--

CREATE TABLE `hasla_generowane` (
  `id_hasla` int(11) NOT NULL,
  `id_uzytkownik` int(11) NOT NULL,
  `ostatnieGenerowaneHaslo` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `hasla_generowane`
--

INSERT INTO `hasla_generowane` (`id_hasla`, `id_uzytkownik`, `ostatnieGenerowaneHaslo`) VALUES
(3, 7, 'D6W$$qdoQ7'),
(4, 7, 'QFrc#&Y3s1'),
(5, 7, 'kA*f4s-UT9'),
(6, 7, 'C$Sb&zJt40'),
(7, 7, 'nkLX$vM41#'),
(8, 7, 'MsuBx$*4R8'),
(9, 7, '*u1daCWI7-');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `ksiazka`
--

CREATE TABLE `ksiazka` (
  `id_ksiazka` int(11) NOT NULL,
  `tytul` varchar(253) NOT NULL,
  `autor` int(11) NOT NULL,
  `gatunek` int(11) NOT NULL,
  `opis` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_polish_ci;

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
(87, 4, 3);

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
(4, 'Modyfikacja użytkownika');

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
(7, 'Renata', 'Gołąbek', 'golab@wp.pl', 129098188, 'Warszawa', '12-123', 'Ptasia', '12', '98', '12345678909', '2004-04-11', '1', 'golab', '<\\g<U*k2n3Y3');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `autor`
--
ALTER TABLE `autor`
  ADD PRIMARY KEY (`id_autor`);

--
-- Indeksy dla tabeli `gatunek`
--
ALTER TABLE `gatunek`
  ADD PRIMARY KEY (`id_gatunek`);

--
-- Indeksy dla tabeli `hasla_generowane`
--
ALTER TABLE `hasla_generowane`
  ADD PRIMARY KEY (`id_hasla`),
  ADD KEY `id_uzytkownik` (`id_uzytkownik`);

--
-- Indeksy dla tabeli `ksiazka`
--
ALTER TABLE `ksiazka`
  ADD PRIMARY KEY (`id_ksiazka`),
  ADD UNIQUE KEY `gatunek` (`gatunek`),
  ADD UNIQUE KEY `gatunek_2` (`gatunek`),
  ADD KEY `gatunek_3` (`gatunek`),
  ADD KEY `autor` (`autor`);

--
-- Indeksy dla tabeli `pary_uprawnienia`
--
ALTER TABLE `pary_uprawnienia`
  ADD PRIMARY KEY (`id_pary`),
  ADD KEY `id_uprawnienia` (`id_uprawnienia`),
  ADD KEY `id_uzytkownik` (`id_uzytkownik`);

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
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `autor`
--
ALTER TABLE `autor`
  MODIFY `id_autor` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `gatunek`
--
ALTER TABLE `gatunek`
  MODIFY `id_gatunek` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `hasla_generowane`
--
ALTER TABLE `hasla_generowane`
  MODIFY `id_hasla` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `ksiazka`
--
ALTER TABLE `ksiazka`
  MODIFY `id_ksiazka` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `pary_uprawnienia`
--
ALTER TABLE `pary_uprawnienia`
  MODIFY `id_pary` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=88;

--
-- AUTO_INCREMENT for table `uzytkownik`
--
ALTER TABLE `uzytkownik`
  MODIFY `id_uzytkownik` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `hasla_generowane`
--
ALTER TABLE `hasla_generowane`
  ADD CONSTRAINT `hasla_generowane_ibfk_1` FOREIGN KEY (`id_uzytkownik`) REFERENCES `uzytkownik` (`id_uzytkownik`);

--
-- Constraints for table `ksiazka`
--
ALTER TABLE `ksiazka`
  ADD CONSTRAINT `ksiazka_ibfk_1` FOREIGN KEY (`gatunek`) REFERENCES `gatunek` (`id_gatunek`),
  ADD CONSTRAINT `ksiazka_ibfk_2` FOREIGN KEY (`autor`) REFERENCES `autor` (`id_autor`);

--
-- Constraints for table `pary_uprawnienia`
--
ALTER TABLE `pary_uprawnienia`
  ADD CONSTRAINT `pary_uprawnienia_ibfk_1` FOREIGN KEY (`id_uprawnienia`) REFERENCES `uprawnienia` (`id_uprawnienia`),
  ADD CONSTRAINT `pary_uprawnienia_ibfk_2` FOREIGN KEY (`id_uzytkownik`) REFERENCES `uzytkownik` (`id_uzytkownik`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
