-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 25, 2018 at 06:19 AM
-- Server version: 5.7.14
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbclassscheds`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbclassscheds`
--

CREATE TABLE `tbclassscheds` (
  `ClassID` int(11) NOT NULL,
  `ClassCode` varchar(30) NOT NULL,
  `TimeIn` time NOT NULL,
  `TimeOut` time NOT NULL,
  `Cycle` varchar(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbclassscheds`
--

INSERT INTO `tbclassscheds` (`ClassID`, `ClassCode`, `TimeIn`, `TimeOut`, `Cycle`) VALUES
(1, 'CS323', '09:30:00', '11:30:00', 'M,W,F'),
(2, 'CS428', '07:30:00', '10:30:00', 'T,Th');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbclassscheds`
--
ALTER TABLE `tbclassscheds`
  ADD PRIMARY KEY (`ClassID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbclassscheds`
--
ALTER TABLE `tbclassscheds`
  MODIFY `ClassID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
