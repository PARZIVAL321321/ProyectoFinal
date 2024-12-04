-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 04, 2024 at 06:21 AM
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
-- Database: `proyecto`
--

-- --------------------------------------------------------

--
-- Table structure for table `personas`
--

CREATE TABLE `personas` (
  `ID` int(11) NOT NULL,
  `Nombre` varchar(100) DEFAULT NULL,
  `Cuenta` varchar(100) DEFAULT NULL,
  `Contra` varchar(100) DEFAULT NULL,
  `Monto` int(11) DEFAULT NULL,
  `Tipo` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `personas`
--

INSERT INTO `personas` (`ID`, `Nombre`, `Cuenta`, `Contra`, `Monto`, `Tipo`) VALUES
(1, 'Patron', 'admin', 'admin', 0, 0),
(2, 'Amigo', 'invitado', 'invitado', 0, 1),
(3, 'Eduardo Arturo Alegria Vela', 'Alegria', 'Alegria', 0, 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `personas`
--
ALTER TABLE `personas`
  ADD PRIMARY KEY (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
