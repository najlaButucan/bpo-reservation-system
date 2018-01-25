-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 25, 2018 at 06:16 AM
-- Server version: 5.7.14
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbbporeservationsystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbbuilding`
--

CREATE TABLE `tbbuilding` (
  `BuildingID` int(11) NOT NULL,
  `BuildingCode` varchar(10) NOT NULL,
  `Description` varchar(100) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbbuilding`
--

INSERT INTO `tbbuilding` (`BuildingID`, `BuildingCode`, `Description`) VALUES
(1, 'MO', ''),
(2, 'LS', '');

-- --------------------------------------------------------

--
-- Table structure for table `tbequipments`
--

CREATE TABLE `tbequipments` (
  `EquipmentID` int(11) NOT NULL,
  `EquipmentCode` varchar(50) NOT NULL,
  `Stock` int(11) NOT NULL,
  `Description` varchar(200) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbequipments`
--

INSERT INTO `tbequipments` (`EquipmentID`, `EquipmentCode`, `Stock`, `Description`) VALUES
(1, 'CH-LS416', 50, 'Chairs'),
(2, 'PROJ-ACER001', 5, 'Projectors');

-- --------------------------------------------------------

--
-- Table structure for table `tbequipres`
--

CREATE TABLE `tbequipres` (
  `ERID` int(11) NOT NULL,
  `ReservationID` int(11) NOT NULL,
  `EquipmentID` int(11) NOT NULL,
  `Quantity` int(11) NOT NULL DEFAULT '1',
  `Status` varchar(10) NOT NULL,
  `DateBorrowed` datetime NOT NULL DEFAULT '2000-01-01 00:00:00',
  `DateReturned` datetime NOT NULL DEFAULT '2000-01-01 00:00:00'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbequipres`
--

INSERT INTO `tbequipres` (`ERID`, `ReservationID`, `EquipmentID`, `Quantity`, `Status`, `DateBorrowed`, `DateReturned`) VALUES
(1, 1, 1, 50, 'BORROWED', '2018-01-30 16:30:00', '2018-01-30 17:30:00'),
(2, 1, 2, 1, 'BORROWED', '2018-01-30 16:30:00', '2018-01-30 17:30:00');

-- --------------------------------------------------------

--
-- Table structure for table `tbreservation`
--

CREATE TABLE `tbreservation` (
  `ReservationID` int(11) NOT NULL,
  `DateOfReservation` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `BuildingID` int(11) NOT NULL,
  `RoomID` int(11) NOT NULL,
  `StudentID` varchar(10) NOT NULL,
  `ReservationDate` date NOT NULL,
  `ETimeIN` time NOT NULL,
  `ETimeOUT` time NOT NULL,
  `Comments` varchar(500) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbreservation`
--

INSERT INTO `tbreservation` (`ReservationID`, `DateOfReservation`, `BuildingID`, `RoomID`, `StudentID`, `ReservationDate`, `ETimeIN`, `ETimeOUT`, `Comments`) VALUES
(1, '2018-01-25 06:11:08', 1, 1, '11510025', '2018-01-30', '16:30:00', '17:30:00', '');

-- --------------------------------------------------------

--
-- Table structure for table `tbrooms`
--

CREATE TABLE `tbrooms` (
  `RoomID` int(11) NOT NULL,
  `BuildingID` int(11) NOT NULL,
  `RoomCode` varchar(10) NOT NULL,
  `Description` varchar(100) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbrooms`
--

INSERT INTO `tbrooms` (`RoomID`, `BuildingID`, `RoomCode`, `Description`) VALUES
(1, 1, '216', 'MO 112'),
(2, 2, '416', 'LS 416');

-- --------------------------------------------------------

--
-- Table structure for table `tbstudent`
--

CREATE TABLE `tbstudent` (
  `StudentID` varchar(20) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `FirstName` varchar(50) NOT NULL,
  `ContactNumber` varchar(15) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbstudent`
--

INSERT INTO `tbstudent` (`StudentID`, `LastName`, `FirstName`, `ContactNumber`) VALUES
('11510025', 'Bolaon', 'Juniper', '09123456789'),
('11510266', 'Grajido', 'Minette Colleen', '09987654321');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbbuilding`
--
ALTER TABLE `tbbuilding`
  ADD PRIMARY KEY (`BuildingID`);

--
-- Indexes for table `tbequipments`
--
ALTER TABLE `tbequipments`
  ADD PRIMARY KEY (`EquipmentID`);

--
-- Indexes for table `tbequipres`
--
ALTER TABLE `tbequipres`
  ADD PRIMARY KEY (`ERID`);

--
-- Indexes for table `tbreservation`
--
ALTER TABLE `tbreservation`
  ADD PRIMARY KEY (`ReservationID`);

--
-- Indexes for table `tbrooms`
--
ALTER TABLE `tbrooms`
  ADD PRIMARY KEY (`RoomID`);

--
-- Indexes for table `tbstudent`
--
ALTER TABLE `tbstudent`
  ADD PRIMARY KEY (`StudentID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbbuilding`
--
ALTER TABLE `tbbuilding`
  MODIFY `BuildingID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `tbequipments`
--
ALTER TABLE `tbequipments`
  MODIFY `EquipmentID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `tbequipres`
--
ALTER TABLE `tbequipres`
  MODIFY `ERID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `tbreservation`
--
ALTER TABLE `tbreservation`
  MODIFY `ReservationID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `tbrooms`
--
ALTER TABLE `tbrooms`
  MODIFY `RoomID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
