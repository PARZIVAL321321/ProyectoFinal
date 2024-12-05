-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 06, 2024 at 12:45 AM
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
-- Table structure for table `juegos`
--

CREATE TABLE `juegos` (
  `ID` int(11) NOT NULL,
  `Nombre` varchar(50) DEFAULT NULL,
  `Imagen` varchar(50) DEFAULT NULL,
  `Genero` varchar(50) DEFAULT NULL,
  `Plataforma` varchar(50) DEFAULT NULL,
  `Modalidad` varchar(50) DEFAULT NULL,
  `Precio` int(11) DEFAULT NULL,
  `Stock` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `juegos`
--

INSERT INTO `juegos` (`ID`, `Nombre`, `Imagen`, `Genero`, `Plataforma`, `Modalidad`, `Precio`, `Stock`) VALUES
(1, 'Call of Duty', 'COD.jpg', 'Accion', 'Xbox', 'Multiplayer', 1200, 15),
(2, 'Minecraft', 'Minecraft.jpg', 'Indie', 'Xbox', 'Singleplayer', 800, 15),
(3, 'Valorant', 'Valorant.jpg', 'Estrategia', 'PC', 'Multiplayer', 0, 500),
(4, 'Counter Strike', 'CSGO.jpg', 'Accion', 'PC', 'Multiplayer', 0, 500),
(5, 'GTA V', 'GTA.jpg', 'Mundo abierto', 'PlayStation', 'Multiplayer', 500, 10),
(6, 'Rust', 'Rust.jpg', 'Supervivencia', 'PC', 'Multijugador', 400, 30),
(7, 'Rainbow Six', 'R6.jpg', 'Estrategia', 'Xbox', 'Multijugador', 600, 10);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `juegos`
--
ALTER TABLE `juegos`
  ADD PRIMARY KEY (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
