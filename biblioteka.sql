-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 18, 2024 at 04:07 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

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
-- Table structure for table `autor`
--

CREATE TABLE `autor` (
  `id_autor` int(11) NOT NULL,
  `imie` varchar(150) NOT NULL,
  `nazwisko` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_polish_ci;

-- --------------------------------------------------------

--
-- Table structure for table `gatunek`
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
-- Table structure for table `ksiazka`
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
-- Table structure for table `uzytkownik`
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
(1, 'Jakub', 'Kowalski', 'mail@mail.com', 123456789, 'Rogów', '00-001', 'ul. Wielka', '33', NULL, '73110743682', '1994-03-09', 'Mezczyzna', 'kubakowal123', 'db3fc40e6439d4d972870252ccc72f62'),
(2, 'Joanna', 'Wilk', 'mail123@mail.com', 987654321, 'Warszawa', '00-002', 'ul. Łódzka', '14', '21', '00220879196', '2004-08-20', 'Kobieta', 'asiaaisa', '241190129fd7bab5b857c600dac6e2c5'),
(3, 'Mariusz', 'Pudzianowski', 'pudzian@mail.com', 123123123, 'Poznań', '00-003', 'ul. Mała', '12', NULL, '87080361313', '1997-02-07', 'Mężczyzna', 'pudzianator', '7c8a7c5f8338b02d82840d64e23e47e6');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `autor`
--
ALTER TABLE `autor`
  ADD PRIMARY KEY (`id_autor`);

--
-- Indexes for table `gatunek`
--
ALTER TABLE `gatunek`
  ADD PRIMARY KEY (`id_gatunek`);

--
-- Indexes for table `ksiazka`
--
ALTER TABLE `ksiazka`
  ADD PRIMARY KEY (`id_ksiazka`),
  ADD UNIQUE KEY `gatunek` (`gatunek`),
  ADD UNIQUE KEY `gatunek_2` (`gatunek`),
  ADD KEY `gatunek_3` (`gatunek`),
  ADD KEY `autor` (`autor`);

--
-- Indexes for table `uzytkownik`
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
-- AUTO_INCREMENT for table `ksiazka`
--
ALTER TABLE `ksiazka`
  MODIFY `id_ksiazka` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `uzytkownik`
--
ALTER TABLE `uzytkownik`
  MODIFY `id_uzytkownik` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `ksiazka`
--
ALTER TABLE `ksiazka`
  ADD CONSTRAINT `ksiazka_ibfk_1` FOREIGN KEY (`gatunek`) REFERENCES `gatunek` (`id_gatunek`),
  ADD CONSTRAINT `ksiazka_ibfk_2` FOREIGN KEY (`autor`) REFERENCES `autor` (`id_autor`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
