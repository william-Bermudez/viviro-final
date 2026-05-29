-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         12.2.2-MariaDB - MariaDB Server
-- SO del servidor:              Win64
-- HeidiSQL Versión:             12.14.0.7165
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Volcando estructura de base de datos para viveroshalom
CREATE DATABASE IF NOT EXISTS `viveroshalom` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_uca1400_ai_ci */;
USE `viveroshalom`;

-- Volcando estructura para tabla viveroshalom.plantas
CREATE TABLE IF NOT EXISTS `plantas` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `NombrePlanta` varchar(100) NOT NULL,
  `Especie` varchar(100) DEFAULT NULL,
  `FechaRegistro` timestamp NULL DEFAULT current_timestamp(),
  `Activo` tinyint(1) DEFAULT 1,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UQ_Planta_Especie` (`NombrePlanta`,`Especie`)
) ENGINE=InnoDB AUTO_INCREMENT=45 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Volcando datos para la tabla viveroshalom.plantas: ~5 rows (aproximadamente)
INSERT INTO `plantas` (`Id`, `NombrePlanta`, `Especie`, `FechaRegistro`, `Activo`) VALUES
	(38, 'Tomate', 'cherri', '2026-05-18 22:00:03', 1),
	(41, 'Romero', 'Mexicano', '2026-05-18 22:22:41', 1),
	(42, 'Sandia', 'roma', '2026-05-18 22:23:33', 1),
	(43, 'Tomates', 'Roma', '2026-05-18 22:43:35', 1),
	(44, 'Tomates', 'cherri', '2026-05-19 00:19:25', 1);

-- Volcando estructura para tabla viveroshalom.tareas
CREATE TABLE IF NOT EXISTS `tareas` (
  `Id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID único de la tarea',
  `TipoAccion` varchar(50) NOT NULL COMMENT 'Tipo de acción: Riego, Abonar, Poda, Siembra, Trasplante, Fumigación',
  `Prioridad` varchar(20) NOT NULL COMMENT 'Prioridad: Alta, Media, Baja',
  `Ubicacion` varchar(100) NOT NULL COMMENT 'Ubicación de la planta en el vivero',
  `FechaInicio` date NOT NULL COMMENT 'Fecha de inicio de la tarea',
  `FechaFinalizacion` date NOT NULL COMMENT 'Fecha de finalización de la tarea',
  `Repeticion` varchar(50) NOT NULL COMMENT 'Frecuencia de repetición: No repetir, Cada día, Cada 8 días, Cada 15 días, Mensual',
  `HoraRecuerdo` time NOT NULL COMMENT 'Hora del recordatorio',
  `Descripcion` text DEFAULT NULL COMMENT 'Descripción adicional de la tarea',
  `Fotos` varchar(255) DEFAULT NULL COMMENT 'Ruta de las fotos (opcional)',
  `Completado` tinyint(1) DEFAULT 0 COMMENT 'Estado: TRUE=Completado, FALSE=Pendiente',
  `FechaCreacion` timestamp NULL DEFAULT current_timestamp() COMMENT 'Fecha de creación del registro',
  `PlantaUnica` varchar(200) DEFAULT NULL,
  `PlantaId` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `FK_Tareas_Plantas` (`PlantaId`),
  CONSTRAINT `FK_Tareas_Plantas` FOREIGN KEY (`PlantaId`) REFERENCES `plantas` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=40 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Volcando datos para la tabla viveroshalom.tareas: ~6 rows (aproximadamente)
INSERT INTO `tareas` (`Id`, `TipoAccion`, `Prioridad`, `Ubicacion`, `FechaInicio`, `FechaFinalizacion`, `Repeticion`, `HoraRecuerdo`, `Descripcion`, `Fotos`, `Completado`, `FechaCreacion`, `PlantaUnica`, `PlantaId`) VALUES
	(34, 'Poda', 'Alta', 'Mazeta 2', '2026-05-18', '2026-05-19', 'No repetir', '16:22:30', '', '', 0, '2026-05-18 22:22:41', NULL, 41),
	(35, 'Riego', 'Baja', 'Semillero 4', '2026-05-18', '2026-05-19', 'No repetir', '16:24:06', '', '', 1, '2026-05-18 22:23:33', NULL, 42),
	(36, 'Riego', 'Media', 'sss', '2026-05-18', '2026-05-19', 'No repetir', '16:43:19', '', '', 0, '2026-05-18 22:43:35', NULL, 43),
	(37, 'Riego', 'Media', 'Semillero 3', '2026-05-18', '2026-05-19', 'No repetir', '16:48:47', '', '', 0, '2026-05-18 22:49:08', NULL, 43),
	(38, 'Riego', 'Media', 'Semillero4', '2026-05-18', '2026-05-19', 'No repetir', '17:50:01', 'a', 'C:\\Users\\lenny\\Desktop\\Nueva carpeta\\images (1).jpg', 0, '2026-05-18 23:49:24', NULL, 43),
	(39, 'Siembra', 'Alta', 'Semillero 7', '2026-05-18', '2026-05-19', 'No repetir', '18:22:10', 'mucho cuido', 'C:\\Users\\lenny\\Desktop\\Nueva carpeta\\sddefault.jpg;C:\\Users\\lenny\\Desktop\\Nueva carpeta\\images (1).jpg', 0, '2026-05-19 00:21:22', NULL, 43);

-- Volcando estructura para tabla viveroshalom.usuarios
CREATE TABLE IF NOT EXISTS `usuarios` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Usuario` varchar(50) NOT NULL,
  `Contraseña` varchar(50) NOT NULL,
  `NombreCompleto` varchar(100) DEFAULT NULL,
  `Rol` varchar(20) DEFAULT 'Usuario',
  `FechaCreacion` timestamp NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Usuario` (`Usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Volcando datos para la tabla viveroshalom.usuarios: ~2 rows (aproximadamente)
INSERT INTO `usuarios` (`Id`, `Usuario`, `Contraseña`, `NombreCompleto`, `Rol`, `FechaCreacion`) VALUES
	(1, 'admin', '1234', 'Administrador', 'Admin', '2026-05-17 20:48:20'),
	(2, 'jardinero', '1234', 'Lenny', 'Usuario', '2026-05-18 20:48:20');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
