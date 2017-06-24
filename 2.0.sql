-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 25-06-2017 a las 01:14:12
-- Versión del servidor: 10.1.19-MariaDB
-- Versión de PHP: 5.6.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `analisis2`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categoriaacabado`
--

CREATE TABLE `categoriaacabado` (
  `IDAcabado` int(11) NOT NULL,
  `Precio` int(11) NOT NULL,
  `Descripcion` varchar(100) COLLATE utf8_spanish2_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `categoriaacabado`
--

INSERT INTO `categoriaacabado` (`IDAcabado`, `Precio`, `Descripcion`) VALUES
(1, 550, 'standard'),
(2, 700, 'plus');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `datoscliente`
--

CREATE TABLE `datoscliente` (
  `IDC` int(11) NOT NULL,
  `Nombre` varchar(25) NOT NULL,
  `Apell1` varchar(25) NOT NULL,
  `Apell2` varchar(25) NOT NULL,
  `correo` varchar(65) NOT NULL,
  `telefono` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `datoscotizador`
--

CREATE TABLE `datoscotizador` (
  `IDD` int(11) NOT NULL,
  `CantidadDeCuartos` int(11) NOT NULL,
  `CantidadDeBaños` int(11) NOT NULL,
  `acabado` int(1) NOT NULL,
  `plantas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proyectos`
--

CREATE TABLE `proyectos` (
  `IDP` int(11) NOT NULL,
  `EncargadoDeProyecto` int(11) NOT NULL,
  `archivo_Documentos` varchar(15) DEFAULT NULL,
  `archivo_Planos` varchar(15) DEFAULT NULL,
  `Cotizacion` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `roll`
--

CREATE TABLE `roll` (
  `IDR` int(11) NOT NULL,
  `descripcion` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trabajadores`
--

CREATE TABLE `trabajadores` (
  `IDT` int(11) NOT NULL,
  `cedula` int(11) NOT NULL,
  `Nombre` varchar(25) NOT NULL,
  `Apell1` varchar(25) NOT NULL,
  `Apell2` varchar(25) NOT NULL,
  `Roll` int(11) NOT NULL,
  `telefono` int(11) NOT NULL,
  `correo` varchar(65) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trabajadoreslogeo`
--

CREATE TABLE `trabajadoreslogeo` (
  `IDTL` int(11) NOT NULL,
  `Contraseña` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `categoriaacabado`
--
ALTER TABLE `categoriaacabado`
  ADD PRIMARY KEY (`IDAcabado`);

--
-- Indices de la tabla `datoscliente`
--
ALTER TABLE `datoscliente`
  ADD PRIMARY KEY (`IDC`),
  ADD KEY `ix_tmp_autoinc` (`IDC`);

--
-- Indices de la tabla `datoscotizador`
--
ALTER TABLE `datoscotizador`
  ADD PRIMARY KEY (`IDD`),
  ADD KEY `ix_tmp_autoinc` (`IDD`);

--
-- Indices de la tabla `proyectos`
--
ALTER TABLE `proyectos`
  ADD PRIMARY KEY (`IDP`),
  ADD KEY `ix_tmp_autoinc` (`IDP`),
  ADD KEY `FK_Encargado` (`EncargadoDeProyecto`);

--
-- Indices de la tabla `roll`
--
ALTER TABLE `roll`
  ADD PRIMARY KEY (`IDR`),
  ADD KEY `ix_tmp_autoinc` (`IDR`);

--
-- Indices de la tabla `trabajadores`
--
ALTER TABLE `trabajadores`
  ADD PRIMARY KEY (`IDT`),
  ADD KEY `ix_tmp_autoinc` (`IDT`),
  ADD KEY `FK_Roll` (`Roll`);

--
-- Indices de la tabla `trabajadoreslogeo`
--
ALTER TABLE `trabajadoreslogeo`
  ADD PRIMARY KEY (`IDTL`),
  ADD KEY `ix_tmp_autoinc` (`IDTL`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `datoscliente`
--
ALTER TABLE `datoscliente`
  MODIFY `IDC` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `datoscotizador`
--
ALTER TABLE `datoscotizador`
  MODIFY `IDD` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `proyectos`
--
ALTER TABLE `proyectos`
  MODIFY `IDP` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `roll`
--
ALTER TABLE `roll`
  MODIFY `IDR` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `trabajadores`
--
ALTER TABLE `trabajadores`
  MODIFY `IDT` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `trabajadoreslogeo`
--
ALTER TABLE `trabajadoreslogeo`
  MODIFY `IDTL` int(11) NOT NULL AUTO_INCREMENT;
--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `proyectos`
--
ALTER TABLE `proyectos`
  ADD CONSTRAINT `FK_Encargado` FOREIGN KEY (`EncargadoDeProyecto`) REFERENCES `trabajadores` (`IDT`);

--
-- Filtros para la tabla `trabajadores`
--
ALTER TABLE `trabajadores`
  ADD CONSTRAINT `FK_Roll` FOREIGN KEY (`Roll`) REFERENCES `roll` (`IDR`);

--
-- Filtros para la tabla `trabajadoreslogeo`
--
ALTER TABLE `trabajadoreslogeo`
  ADD CONSTRAINT `FK_IDTL1` FOREIGN KEY (`IDTL`) REFERENCES `trabajadores` (`IDT`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
