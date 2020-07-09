-- phpMyAdmin SQL Dump
-- version 4.6.6deb5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Jul 09, 2020 at 09:13 AM
-- Server version: 5.7.30-0ubuntu0.18.04.1
-- PHP Version: 7.2.24-0ubuntu0.18.04.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `gamedb`
--

-- --------------------------------------------------------

--
-- Table structure for table `accounts`
--

CREATE TABLE `accounts` (
  `id` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `coins` int(100) NOT NULL DEFAULT '0',
  `currentskin` int(11) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `accounts`
--

INSERT INTO `accounts` (`id`, `username`, `password`, `coins`, `currentskin`) VALUES
(1, 'sagi', 'b35eba64c759b98148bb4510c0794583', 600, 2),
(2, 'bens', 'b35eba64c759b98148bb4510c0794583', 55, 2),
(3, 'test', '25d55ad283aa400af464c76d713c07ad', 0, 0),
(4, 'test2', '25d55ad283aa400af464c76d713c07ad', 0, 0),
(5, 'test3', '25d55ad283aa400af464c76d713c07ad', 0, 0),
(6, 'test5', '25d55ad283aa400af464c76d713c07ad', 0, 0),
(7, 'test6', '25d55ad283aa400af464c76d713c07ad', 0, 0),
(8, 'test8', '25d55ad283aa400af464c76d713c07ad', 0, 0),
(9, 'test10', '25d55ad283aa400af464c76d713c07ad', 0, 0),
(10, 'test100', '25f9e794323b453885f5181f1b624d0b', 0, 0),
(11, 'test102', '25d55ad283aa400af464c76d713c07ad', 0, 0),
(181, 'bensop', '25d55ad283aa400af464c76d713c07ad', 31, 0),
(182, 'sopher', '25d55ad283aa400af464c76d713c07ad', 52, 0),
(183, 'must$', 'b35eba64c759b98148bb4510c0794583', 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `items`
--

CREATE TABLE `items` (
  `ID` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `description` text NOT NULL,
  `price` int(100) NOT NULL,
  `image` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `items`
--

INSERT INTO `items` (`ID`, `name`, `description`, `price`, `image`) VALUES
(1, 'Pirate Skin', 'A Pirate skin for your car', 100, ''),
(2, 'Batman Skin', 'A Batman skin for your car', 200, '');

-- --------------------------------------------------------

--
-- Table structure for table `usersitems`
--

CREATE TABLE `usersitems` (
  `ID` int(11) NOT NULL,
  `userID` int(11) NOT NULL,
  `itemID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `usersitems`
--

INSERT INTO `usersitems` (`ID`, `userID`, `itemID`) VALUES
(3, 2, 1),
(4, 2, 2),
(5, 0, 1),
(25, 1, 7),
(26, 1, 6),
(27, 1, 8),
(28, 1, 5),
(29, 1, 4),
(30, 1, 2),
(31, 1, 3),
(32, 1, 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accounts`
--
ALTER TABLE `accounts`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `items`
--
ALTER TABLE `items`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `usersitems`
--
ALTER TABLE `usersitems`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `accounts`
--
ALTER TABLE `accounts`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=184;
--
-- AUTO_INCREMENT for table `items`
--
ALTER TABLE `items`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `usersitems`
--
ALTER TABLE `usersitems`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
