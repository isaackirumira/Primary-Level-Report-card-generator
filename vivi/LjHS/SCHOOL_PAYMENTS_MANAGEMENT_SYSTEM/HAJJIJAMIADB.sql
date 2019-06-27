-- phpMyAdmin SQL Dump
-- version 3.3.9
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Aug 19, 2015 at 11:02 AM
-- Server version: 5.5.8
-- PHP Version: 5.3.5

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `school_payments`
--
CREATE DATABASE `school_payments` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `school_payments`;

-- --------------------------------------------------------

--
-- Table structure for table `amounts`
--

CREATE TABLE IF NOT EXISTS `amounts` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `class` varchar(100) NOT NULL,
  `amount` varchar(10) NOT NULL,
  `cond` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `amounts`
--

INSERT INTO `amounts` (`id`, `class`, `amount`, `cond`) VALUES
(1, 'S1 A', '500000', 'USE'),
(2, 'S1 B', '600000', 'USE');

-- --------------------------------------------------------

--
-- Table structure for table `asset_expenditure`
--

CREATE TABLE IF NOT EXISTS `asset_expenditure` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `vote` varchar(100) NOT NULL,
  `subvote` varchar(100) NOT NULL,
  `expence` varchar(100) NOT NULL,
  `voucherno` varchar(100) NOT NULL,
  `estimated` int(100) NOT NULL,
  `actual` int(11) NOT NULL,
  `cummulative` int(11) NOT NULL,
  `balance` int(11) NOT NULL,
  `date` varchar(100) NOT NULL,
  `term` varchar(100) NOT NULL,
  `year` int(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=24 ;

--
-- Dumping data for table `asset_expenditure`
--

INSERT INTO `asset_expenditure` (`id`, `vote`, `subvote`, `expence`, `voucherno`, `estimated`, `actual`, `cummulative`, `balance`, `date`, `term`, `year`) VALUES
(16, 'DESK', '5', '2015-01-29', 'ONE', 2015, 0, 0, 0, '', '', 0),
(17, 'DESK', '7', '2015-01-29', 'ONE', 2015, 0, 0, 0, '', '', 0),
(18, 'DESK', '2', '2015-01-29', 'ONE', 2015, 0, 0, 0, '', '', 0),
(19, 'DESK', '6', '2015-01-29', 'ONE', 2015, 0, 0, 0, '', '', 0),
(21, '', '', '', '', 0, 50000, 0, 0, '', '', 0),
(22, '', '', '', '', 0, 70000, 0, 0, '', '', 0),
(23, 'ADMINISTRATION', 'RENT', 'MUKASA', '099K', 1000000, 80000, 120000, 880000, 'Wednesday, May 13, 2015', 'ONE', 2014);

-- --------------------------------------------------------

--
-- Table structure for table `boarding_amounts`
--

CREATE TABLE IF NOT EXISTS `boarding_amounts` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `class` varchar(100) NOT NULL,
  `amount` varchar(100) NOT NULL,
  `cond` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `boarding_amounts`
--

INSERT INTO `boarding_amounts` (`id`, `class`, `amount`, `cond`) VALUES
(1, 'S1 A', '700000', 'USE');

-- --------------------------------------------------------

--
-- Table structure for table `expences`
--

CREATE TABLE IF NOT EXISTS `expences` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `expence_type` varchar(500) NOT NULL,
  `expence` varchar(500) NOT NULL,
  `expenceon` varchar(100) NOT NULL,
  `amount` int(20) NOT NULL,
  `date` varchar(30) NOT NULL,
  `term` varchar(30) NOT NULL,
  `year` int(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Dumping data for table `expences`
--

INSERT INTO `expences` (`id`, `expence_type`, `expence`, `expenceon`, `amount`, `date`, `term`, `year`) VALUES
(2, 'WELFARE', 'SEMINAR', '', 300000, '2015-12-19', 'ONE', 2015),
(3, 'ADMINISTRATIVE', 'RENT', '', 1000000, '2015-12-19', 'ONE', 2015),
(4, 'ADMINISTRATIVE', 'XXX', '', 1000000, '2015-12-19', 'ONE', 2015),
(5, 'ADMINISTRATIVE', 'YYYY', '', 60000, '2015-12-19', 'ONE', 2015),
(6, 'ADMINISTRATIVE', 'MMM', '', 60000, '2015-12-04', 'TWO', 2014),
(7, 'aaaaa', 'aaaa', 'aaaa', 222, '2222', '1', 2333);

-- --------------------------------------------------------

--
-- Table structure for table `fees_payments`
--

CREATE TABLE IF NOT EXISTS `fees_payments` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `date` varchar(100) NOT NULL,
  `name` varchar(100) NOT NULL,
  `class` varchar(100) NOT NULL,
  `total_amount` int(10) NOT NULL,
  `paid` int(10) NOT NULL,
  `bankslipno` varchar(200) NOT NULL,
  `balance` int(100) NOT NULL,
  `year` varchar(100) NOT NULL,
  `term` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=21 ;

--
-- Dumping data for table `fees_payments`
--

INSERT INTO `fees_payments` (`id`, `date`, `name`, `class`, `total_amount`, `paid`, `bankslipno`, `balance`, `year`, `term`) VALUES
(1, '2015-12-04', 'KIRUMIRA ISAAC', 'S 1', 500000, 50000, '', 390000, '2014', 'TERM1'),
(7, '2015-12-04', 'DAN', 'S 1', 500000, 80000, '', 420000, '2015', 'TERM1'),
(8, '2015-12-04', 'KIRUMIRA ISAAC', 'S 1', 600000, 400000, '', 200000, '2014', 'TERM1'),
(9, '2015-12-04', 'KIRUMIRA ISAAC', 'S 1', 500000, 50000, '', 450000, '2014', 'TERM2'),
(10, '2004-09-06', 'XX', 'S1 A', 500000, 100000, '', 400000, '2015', 'TERM1'),
(11, '2004-09-04', 'KAMUKAMA', 'S 1', 600000, 50000, '1234', 450000, '2014', 'TERM1'),
(12, '2004-09-04', 'KABUYE', 'S 1', 500000, 50000, '3455', 0, '2015', 'TERM1'),
(13, '2004-09-04', 'YY', 'S 1', 500000, 50000, '3455', 0, '2015', 'TERM1'),
(14, '2004-09-04', 'DDDDD', 'S1 A', 500000, 100000, '123456', 400000, '2015', 'TERM1'),
(15, '2004-09-04', 'NNNN', 'S1 A', 600000, 100000, '344444', 500000, '2015', 'TERM1'),
(16, '2004-09-04', 'LLLLLLLLLLLLLLL', 'S1 A', 700000, 200000, '23455', 300000, '2015', 'TERM1'),
(17, '2004-09-04', 'EEEEE', 'S1 A', 500000, 20000, '33333', 480000, '2015', 'TERM1'),
(18, '2004-09-04', 'RRRR', 'S1 A', 700000, 20000, '444444', 680000, '2015', 'TERM1'),
(19, '2004-09-04', 'ZZZZZ', 'S1 A', 600000, 30000, '21234', 570000, '2015', 'TERM1'),
(20, '2004-09-04', 'CCCCC', 'S1 A', 600000, 90000, '12333', 510000, '2015', 'TERM1');

-- --------------------------------------------------------

--
-- Table structure for table `installments`
--

CREATE TABLE IF NOT EXISTS `installments` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `date` varchar(100) NOT NULL,
  `name` varchar(100) NOT NULL,
  `paid` int(100) NOT NULL,
  `bankslipno` varchar(200) NOT NULL,
  `class` varchar(100) NOT NULL,
  `term` varchar(100) NOT NULL,
  `year` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=27 ;

--
-- Dumping data for table `installments`
--

INSERT INTO `installments` (`id`, `date`, `name`, `paid`, `bankslipno`, `class`, `term`, `year`) VALUES
(1, '2015-12-04', 'KIRUMIRA ISAAC', 50000, '', 'S1 A', 'TERM1', '2014'),
(2, '2015-12-04', 'KIRUMIRA ISAAC', 30000, '', 'S1 A', 'TERM1', '2014'),
(3, '2015-12-04', 'KIRUMIRA ISAAC', 30000, '', 'S1 A', 'TERM1', '2014'),
(13, '2015-12-04', 'DAN', 80000, '', 'S1 A', 'TERM1', '2015'),
(14, '2015-12-04', 'KIRUMIRA ISAAC', 400000, '', 'S1 B', 'TERM1', '2014'),
(15, '2015-12-04', 'KIRUMIRA ISAAC', 50000, '', 'S1 A', 'TERM2', '2014'),
(16, '2004-09-06', 'XX', 100000, '', 'S1 A', 'TERM1', '2015'),
(17, '2004-09-04', 'KAMUKAMA', 50000, '1234', 'S1 A', 'TERM1', '2014'),
(18, '2004-09-04', 'KABUYE', 50000, '3455', 'S1 A', 'TERM1', '2015'),
(19, '2004-09-04', 'YY', 50000, '3455', 'S1 A', 'TERM1', '2015'),
(20, '2004-09-04', 'DDDDD', 100000, '123456', 'S1 A', 'TERM1', '2015'),
(21, '2004-09-04', 'NNNN', 100000, '344444', 'S1 A', 'TERM1', '2015'),
(22, '2004-09-04', 'LLLLLLLLLLLLLLL', 200000, '23455', 'S1 A', 'TERM1', '2015'),
(23, '2004-09-04', 'EEEEE', 20000, '33333', 'S1 A', 'TERM1', '2015'),
(24, '2004-09-04', 'RRRR', 20000, '444444', 'S1 A', 'TERM1', '2015'),
(25, '2004-09-04', 'ZZZZZ', 30000, '21234', 'S1 A', 'TERM1', '2015'),
(26, '2004-09-04', 'CCCCC', 90000, '12333', 'S1 A', 'TERM1', '2015');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE IF NOT EXISTS `login` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `usertype` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`id`, `username`, `password`, `usertype`) VALUES
(1, 'admin', 'admin', 'admin'),
(2, 'user', 'user', 'user');

-- --------------------------------------------------------

--
-- Table structure for table `meal_ream`
--

CREATE TABLE IF NOT EXISTS `meal_ream` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `class` varchar(100) NOT NULL,
  `term` varchar(100) NOT NULL,
  `year` varchar(100) NOT NULL,
  `payment` varchar(100) NOT NULL,
  `amount` int(100) NOT NULL,
  `balance` int(11) NOT NULL,
  `other` varchar(100) NOT NULL,
  `date` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=14 ;

--
-- Dumping data for table `meal_ream`
--

INSERT INTO `meal_ream` (`id`, `name`, `class`, `term`, `year`, `payment`, `amount`, `balance`, `other`, `date`) VALUES
(7, 'MUKIBII', 'S 1', 'ONE', '2015', 'UACE EXAMS', 120000, 160000, '', '2015-06-19'),
(8, 'MUKIBII', 'S 1', 'ONE', '2015', 'REAM', 12000, 3000, '', '2015-06-19'),
(9, 'MUKIBII', 'S 1', 'ONE', '2015', 'UNIFORM', 0, 35000, 'PAID', '2015-06-19'),
(10, 'JUMA', 'S 1', 'ONE', '2015', 'UACE EXAMS', 50000, 0, '', '2015-06-19'),
(11, 'KABALI', 'S 1', 'ONE', '2015', 'UACE EXAMS', 50000, 200000, '', '2015-06-19'),
(12, 'KABALI', 'S 1', 'ONE', '2015', 'UNIFORM', 0, 0, 'PAID', '2015-06-19'),
(13, 'KABALI', 'S 1', 'ONE', '2015', 'UACE EXAMS', 30000, 200000, '', '2015-06-19');

-- --------------------------------------------------------

--
-- Table structure for table `netassets`
--

CREATE TABLE IF NOT EXISTS `netassets` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `asset` varchar(200) NOT NULL,
  `quantity` int(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=11 ;

--
-- Dumping data for table `netassets`
--

INSERT INTO `netassets` (`id`, `asset`, `quantity`) VALUES
(7, 'DESK', 53),
(8, 'ADMINISTRATION', 0),
(9, 'REAMS', 20),
(10, 'FIRE WOOD', 0);

-- --------------------------------------------------------

--
-- Table structure for table `pay`
--

CREATE TABLE IF NOT EXISTS `pay` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `term` varchar(100) NOT NULL,
  `class` varchar(100) NOT NULL,
  `year` int(100) NOT NULL,
  `payment` varchar(100) NOT NULL,
  `amount` int(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=12 ;

--
-- Dumping data for table `pay`
--

INSERT INTO `pay` (`id`, `name`, `term`, `class`, `year`, `payment`, `amount`) VALUES
(1, 'HAJJI', 'ONE', 'S 1', 2015, 'UACE EXAMS', 80000),
(2, 'RASHID', 'ONE', 'S 1', 2015, 'UACE EXAMS', 60000),
(3, 'RASHID', 'ONE', 'S 1', 2015, 'UACE EXAMS', 30000),
(4, 'RASHID', 'ONE', 'S 1', 2015, 'REAM', 60000),
(5, 'MUKIBII', 'ONE', 'S 1', 2015, 'UACE EXAMS', 120000),
(6, 'MUKIBII', 'ONE', 'S 1', 2015, 'REAM', 12000),
(7, 'MUKIBII', 'ONE', 'S 1', 2015, 'UNIFORM', 0),
(8, 'JUMA', 'ONE', 'S 1', 2015, 'UACE EXAMS', 50000),
(9, 'KABALI', 'ONE', 'S 1', 2015, 'UACE EXAMS', 50000),
(10, 'KABALI', 'ONE', 'S 1', 2015, 'UNIFORM', 0),
(11, 'KABALI', 'ONE', 'S 1', 2015, 'UACE EXAMS', 30000);

-- --------------------------------------------------------

--
-- Table structure for table `payments`
--

CREATE TABLE IF NOT EXISTS `payments` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `payment` varchar(100) NOT NULL,
  `amount` int(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `payments`
--

INSERT INTO `payments` (`id`, `payment`, `amount`) VALUES
(1, 'UACE EXAMS', 280000),
(3, 'UNIFORM', 35000),
(4, 'REAM', 15000),
(5, 'UCE', 160000);

-- --------------------------------------------------------

--
-- Table structure for table `regassets`
--

CREATE TABLE IF NOT EXISTS `regassets` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `amount` int(20) NOT NULL,
  `asset` varchar(100) NOT NULL,
  `quantity` int(100) NOT NULL,
  `date` varchar(100) NOT NULL,
  `TERM` varchar(100) NOT NULL,
  `year` int(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=14 ;

--
-- Dumping data for table `regassets`
--

INSERT INTO `regassets` (`id`, `amount`, `asset`, `quantity`, `date`, `TERM`, `year`) VALUES
(11, 1000000, 'ADMINISTRATION', 0, '2015-08-18', 'ONE', 2014);

-- --------------------------------------------------------

--
-- Table structure for table `registration`
--

CREATE TABLE IF NOT EXISTS `registration` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `fname` varchar(100) NOT NULL,
  `sname` varchar(100) NOT NULL,
  `oname` varchar(100) NOT NULL,
  `date` varchar(100) NOT NULL,
  `parent` varchar(100) NOT NULL,
  `telephone` varchar(100) NOT NULL,
  `sex` varchar(100) NOT NULL,
  `address` varchar(100) NOT NULL,
  `class` varchar(100) NOT NULL,
  `year` varchar(100) NOT NULL,
  `term` varchar(100) NOT NULL,
  `cond` varchar(100) DEFAULT NULL,
  `image` blob NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `registration`
--

INSERT INTO `registration` (`id`, `fname`, `sname`, `oname`, `date`, `parent`, `telephone`, `sex`, `address`, `class`, `year`, `term`, `cond`, `image`) VALUES
(1, 'KIRUMIRA', 'ISAAC', 'DRAKE', '2015-12-04', 'KISENYI', '0752969650', 'MALE', 'MENGO', 'S1 A', '2015', 'ONE', 'USE', '');

-- --------------------------------------------------------

--
-- Table structure for table `sponsers`
--

CREATE TABLE IF NOT EXISTS `sponsers` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(200) NOT NULL,
  `class` varchar(100) NOT NULL,
  `amount` int(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `sponsers`
--

INSERT INTO `sponsers` (`id`, `name`, `class`, `amount`) VALUES
(1, 'JB', 'S1 A', 600000);
