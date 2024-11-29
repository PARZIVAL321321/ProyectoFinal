-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 29-11-2024 a las 06:39:57
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `estim`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `juegos`
--

CREATE TABLE `juegos` (
  `ID` int(11) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Sinopsis` text NOT NULL,
  `Genero` varchar(50) NOT NULL,
  `Plataforma` varchar(50) NOT NULL,
  `Modalidad` varchar(50) NOT NULL,
  `Precio` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `juegos`
--

INSERT INTO `juegos` (`ID`, `Nombre`, `Sinopsis`, `Genero`, `Plataforma`, `Modalidad`, `Precio`) VALUES
(1, 'Dead Space', 'El clásico de terror de ciencia ficción, regresa con una nueva versión totalmente renovada para ofrecer una experiencia aún más inmersiva, con mejoras visuales, de sonido y de jugabilidad, además de mantenerse fiel a la emocionante visión del juego original.', 'Horror -  Ciencia Ficción - Disparos en tercera pe', 'PC', 'Individual', 1399),
(2, 'Counter-Strike 2', 'El clásico juego de disparos táctico regresa con gráficos actualizados y nuevas mecánicas de juego para una experiencia competitiva mejorada.', 'Acción - Disparos en primera persona', 'PC', 'Multijugador', 0),
(3, 'Dota 2', 'Un épico juego de estrategia y acción donde equipos luchan en intensas batallas en línea.', 'Estrategia - MOBA', 'PC', 'Multijugador', 0),
(4, 'PUBG: Battlegrounds', 'Una experiencia Battle Royale con intensos enfrentamientos hasta ser el último en pie.', 'Acción - Supervivencia', 'PC', 'Multijugador', 300),
(5, 'Rust', 'Sobrevive en un mundo hostil recolectando recursos, construyendo refugios y enfrentándote a otros jugadores.', 'Supervivencia - Acción', 'PC', 'Multijugador', 599),
(6, 'Microsoft Flight Simulator 2024', 'Experimenta el simulador de aviación más realista con paisajes impresionantes y controles detallados.', 'Simulación', 'PC', 'Individual/Multijugador', 1299),
(7, 'STALKER 2: Heart of Chornobyl', 'Explora una zona contaminada y llena de peligros en este juego de supervivencia con una historia cautivadora.', 'Acción - Supervivencia', 'PC', 'Individual', 1599),
(8, 'Stray', 'Una aventura en la que juegas como un gato que recorre un mundo lleno de misterios.', 'Aventura', 'PC', 'Individual', 749),
(9, 'Apex Legends', 'Un Battle Royale con héroes únicos y habilidades especiales que combaten en equipos por la victoria.', 'Acción - Battle Royale', 'PC', 'Multijugador', 0),
(10, 'Grand Theft Auto V', 'Una aventura de mundo abierto donde puedes vivir una historia épica o explorar libremente Los Santos.', 'Acción - Mundo Abierto', 'PC', 'Individual/Multijugador', 1499),
(11, 'The Witcher 3: Wild Hunt', 'Acompaña a Geralt de Rivia en una épica aventura de mundo abierto llena de peligros y misterio.', 'RPG - Mundo Abierto', 'PC', 'Individual', 499),
(12, 'Cyberpunk 2077', 'Explora un mundo futurista en Night City mientras completas misiones y moldeas tu historia.', 'Acción - RPG', 'PC', 'Individual', 799),
(13, 'Baldurs Gate III', 'Vive una aventura RPG basada en Dungeons & Dragons en un mundo de fantasía épico.', 'RPG - Aventura', 'PC', 'Individual/Multijugador', 1199),
(14, 'Elden Ring', 'Una experiencia de fantasía oscura con combates desafiantes y un mundo vasto por descubrir.', 'Acción - RPG', 'PC', 'Individual', 999),
(15, 'Terraria', 'Explora, construye y lucha en un mundo 2D lleno de posibilidades infinitas.', 'Aventura - Sandbox', 'PC', 'Individual/Multijugador', 199),
(16, 'Hades', 'Explora el inframundo en este aclamado juego roguelike lleno de acción y narrativa.', 'Roguelike - Acción', 'PC', 'Individual', 299),
(17, 'Celeste', 'Supera desafíos de plataformas mientras sigues la emotiva historia de una joven escaladora.', 'Aventura - Plataformas', 'PC', 'Individual', 149),
(18, 'Dead by Daylight', 'Sobrevive a un asesino en este juego de terror asimétrico en línea.', 'Terror - Supervivencia', 'PC', 'Multijugador', 399),
(19, 'Phasmophobia', 'Investiga actividades paranormales con amigos en este juego de terror cooperativo.', 'Terror - Investigación', 'PC', 'Multijugador', 299),
(20, 'Among Us', 'Trabaja en equipo para mantener la nave en marcha, pero cuidado con los impostores.', 'Fiesta - Estrategia', 'PC', 'Multijugador', 79),
(21, 'Farming Simulator 25', 'Trabaja en la granja de tus sueños cultivando, criando animales y gestionando recursos.', 'Simulación', 'PC', 'Individual', 599),
(22, 'Lego Horizon Adventures', 'Un juego de mundo abierto en colaboración con Horizon y Lego.', 'Aventura - Mundo Abierto', 'PC', 'Individual/Multijugador', 899),
(23, 'Slay the Spire', 'Un juego de construcción de mazos y estrategia donde desafías una torre de enemigos.', 'Estrategia - Cartas', 'PC', 'Individual', 249),
(24, 'Hollow Knight', 'Explora un mundo subterráneo lleno de desafíos y secretos en este juego metroidvania.', 'Aventura - Metroidvania', 'PC', 'Individual', 199),
(25, 'The Rise of the Golden Idol', 'Un juego de investigación detectivesca donde el crimen, el pecado y la muerte tienen una nueva cara, con un estilo visual único.', 'Aventura - Investigación', 'PC', 'Individual', 499),
(26, 'Tetris Forever', 'Una inmersión en la historia de Tetris combinando colecciones de grandes títulos con trabajo documental sobre el legado de este clásico.', 'Puzles - Retro', 'PC', 'Individual', 299),
(27, 'Dragon Quest III: HD-2D Remake', 'Una remasterización en 2D HD de uno de los títulos más importantes del JRPG, con nuevos gráficos y animaciones.', 'RPG', 'PC', 'Individual', 799),
(28, 'Lumo Island', 'Construye tu propia granja y explora una isla llena de recursos, donde podrás jugar solo o en modo cooperativo.', 'Simulación - Mundo Abierto', 'PC', 'Multijugador', 199),
(29, 'Microsoft Flight Simulator 2024', 'Simulador de aviación con gráficos detallados y posibilidad de explorar el mundo real o realizar misiones específicas.', 'Simulación', 'PC', 'Individual', 1299),
(30, 'S.T.A.L.K.E.R. 2: Heart of Chernobyl', 'Secuela del exitoso juego de supervivencia ambientado en la zona de Chernobyl, con nuevos gráficos y un mundo más grande para explorar.', 'Acción - Supervivencia', 'PC', 'Individual', 1599),
(31, 'Nine Sols', 'Explora un mundo lleno de mitología y desafíos en este RPG de acción y combate de estilo tradicional.', 'RPG - Acción', 'PC', 'Individual', 599),
(32, 'Toads of the Bayou', 'Un juego de estrategia por turnos con mecánicas roguelike, que incluye la construcción de mazos y exploración de un mundo único.', 'Estrategia - Roguelike', 'PC', 'Individual', 399),
(33, 'Touhou Spell Carnival', 'Un Bullet hell donde se combinan elementos de rol y estrategia, en un mundo lleno de fantasía y enemigos coloridos.', 'Acción - Bullet Hell', 'PC', 'Multijugador', 599),
(34, 'Towers of Aghasba', 'Un juego de exploración y combate en un mundo abierto con un enfoque en la fabricación de objetos y defensa de torres.', 'Aventura - Sandbox', 'PC', 'Multijugador', 499),
(35, 'Farming Simulator 22', 'Crea tu propio imperio agrícola cultivando, criando animales y gestionando tus finanzas en un mundo virtual.', 'Simulación', 'PC', 'Individual/Multijugador', 799),
(36, 'The Dark Pictures Anthology: Switchback VR', 'Una experiencia de horror en realidad virtual, donde exploras un mundo lleno de monstruos y eventos espeluznantes.', 'Terror - VR', 'PC', 'Individual', 999),
(37, 'Dead Island 2', 'Secuela del exitoso juego de acción y supervivencia donde te enfrentas a hordas de zombis en una ciudad devastada.', 'Acción - Supervivencia', 'PC', 'Multijugador', 899),
(38, 'Hunt: Showdown', 'Un juego de caza de monstruos en el que debes buscar y eliminar criaturas sobrenaturales mientras compites contra otros cazadores.', 'Acción - Supervivencia', 'PC', 'Multijugador', 399),
(39, 'The Crew Motorfest', 'Un juego de carreras en mundo abierto que te permite explorar una ciudad mientras compites en diferentes eventos.', 'Carreras - Mundo Abierto', 'PC', 'Multijugador', 899),
(40, 'A Plague Tale: Requiem', 'Secuela de A Plague Tale, donde exploras un mundo medieval en guerra lleno de enfermedades y criaturas peligrosas.', 'Aventura - Sigilo', 'PC', 'Individual', 1299),
(41, 'Alan Wake II', 'La secuela de este juego de acción y horror psicológico, donde la narrativa y el combate se combinan de manera intrigante.', 'Acción - Terror', 'PC', 'Individual', 1199),
(42, 'Lords of the Fallen', 'Un RPG de acción oscuro donde debes enfrentarte a una serie de peligrosos enemigos en un mundo sombrío y fantástico.', 'RPG - Acción', 'PC', 'Individual', 1299),
(43, 'Starfield', 'Un juego de rol y exploración espacial que ofrece una vasta galaxia para explorar y una narrativa envolvente.', 'RPG - Ciencia Ficción', 'PC', 'Individual', 2499),
(44, 'Mortal Kombat 1', 'El icónico juego de lucha regresa con nuevos personajes y movimientos especiales, además de una historia épica y brutal.', 'Lucha', 'PC', 'Multijugador', 799),
(45, 'Armored Core VI: Fires of Rubicon', 'Controla un mecha en intensas batallas mientras exploras un mundo devastado por la guerra.', 'Acción - Mechas', 'PC', 'Individual', 1499),
(46, 'CyberConnect2s JoJos Bizarre Adventure: All-Star B', 'Un juego de lucha basado en el popular manga JoJos Bizarre Adventure, con personajes y peleas únicas.', 'Lucha - Manga', 'PC', 'Multijugador', 599),
(47, 'Resident Evil 4 Remake', 'La remasterización del clásico survival horror donde deberás sobrevivir a hordas de zombis y monstruos mientras rescatas a la hija del presidente.', 'Terror - Acción', 'PC', 'Individual', 1299),
(48, 'Star Wars Jedi: Survivor', 'Un RPG de acción ambientado en el universo de Star Wars, donde eres un Jedi que lucha por la supervivencia en tiempos oscuros.', 'Acción - Aventura', 'PC', 'Individual', 999),
(49, 'Bioshock Infinite', 'Explora una ciudad flotante llena de misterios y combates en este juego de disparos y aventura con una historia fascinante.', 'Acción - Aventura', 'PC', 'Individual', 799),
(50, 'No Mans Sky', 'Un juego de exploración espacial donde puedes explorar infinitos planetas, recolectar recursos y construir bases.', 'Aventura - Ciencia Ficción', 'PC', 'Multijugador', 799);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `juegos`
--
ALTER TABLE `juegos`
  ADD PRIMARY KEY (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
