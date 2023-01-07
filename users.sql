-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Jan 07, 2023 at 06:45 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 7.4.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `netflixClone`
--

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `firstName` varchar(25) NOT NULL,
  `lastName` varchar(25) NOT NULL,
  `userName` varchar(50) NOT NULL,
  `email` varchar(100) NOT NULL,
  `password` varchar(255) NOT NULL,
  `signUpDate` datetime NOT NULL DEFAULT current_timestamp(),
  `isSubscribed` tinyint(4) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `firstName`, `lastName`, `userName`, `email`, `password`, `signUpDate`, `isSubscribed`) VALUES
(1, 'Juma', 'Juma', 'juma', 'farukunte23@gmail.com', '318b309cad0c17f4d5034afa51a7b7813fd1aabfa66e3f41c2877347e69220bddb9346ac2cd93a0102972004dd4b06f20c26e7c1233cc4dd50f6da4673bbf822', '2022-12-05 22:43:42', 0),
(2, 'Paschal', 'Maximillian', 'FaruKunte', 'juma@gmail.com', '5d2d56df431ab94b2183c6cc18cdf16e60ac09974985d7887ce64ce3eb3c7e1dea7469f7e6081d35e5fd65674e3250142bbe92f79bee33f6f70a83efdbd6d755', '2022-12-06 10:17:16', 0),
(3, 'Mule', 'Leo', 'Muleo', 'muleo@gmail.com', '3ac2b2850027f3ff15ddc93f688aa54161dbc161fb94556070432868c1ac83bf34f6e33d4ea58f51f1238b4897c5f357f9aecca0fe784524eba16cbdd315905d', '2022-12-08 04:18:32', 0),
(4, 'Jumbala', 'Jeje', 'Jeje', 'jeje@gmail.com', '3dcb14ea82a3137a5047230adab8d335649896851fee8f9e384998c3c4162c6fb7f78dc1786ce6737fcc3b97d3c9fcc50dba16e6ace8627cd2726ced91879346', '2023-01-05 10:32:56', 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
