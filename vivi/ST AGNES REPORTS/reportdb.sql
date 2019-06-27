-- phpMyAdmin SQL Dump
-- version 2.11.0
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Oct 24, 2018 at 07:32 AM
-- Server version: 5.0.45
-- PHP Version: 5.2.4

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";

--
-- Database: `reportcards`
--
CREATE DATABASE `reportcards` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `reportcards`;

-- --------------------------------------------------------

--
-- Table structure for table `aleveltotalpoints`
--

CREATE TABLE `aleveltotalpoints` (
  `id` int(11) NOT NULL auto_increment,
  `name` varchar(200) NOT NULL,
  `class` varchar(200) NOT NULL,
  `term` varchar(200) NOT NULL,
  `year` varchar(200) NOT NULL,
  `subject` varchar(200) NOT NULL,
  `Class_Teacher` varchar(200) NOT NULL,
  `date` varchar(200) NOT NULL,
  `password` varchar(200) NOT NULL,
  `initial` varchar(200) NOT NULL,
  `P1MID` varchar(200) NOT NULL,
  `P1END` varchar(200) NOT NULL,
  `AVGP1` int(200) NOT NULL,
  `GRADEP1` varchar(200) NOT NULL,
  `AGGREGATEP1` varchar(200) NOT NULL,
  `P2MID` varchar(200) NOT NULL,
  `P2END` varchar(200) NOT NULL,
  `AVGP2` int(200) NOT NULL,
  `GRADEP2` varchar(200) NOT NULL,
  `AGGREGATEP2` varchar(200) NOT NULL,
  `P3MID` varchar(200) NOT NULL,
  `P3END` varchar(200) NOT NULL,
  `AVGP3` int(200) NOT NULL,
  `GRADEP3` varchar(200) NOT NULL,
  `AGGREGATEP3` varchar(200) NOT NULL,
  `SCORE` varchar(200) NOT NULL,
  `REMARK` varchar(200) NOT NULL,
  `POINTS` varchar(200) NOT NULL,
  `enrtyid` varchar(200) NOT NULL,
  `totalpoints` varchar(100) NOT NULL,
  `P4MID` varchar(100) NOT NULL,
  `P4END` varchar(100) NOT NULL,
  `AVGP4` int(100) NOT NULL,
  `GRADEP4` varchar(100) NOT NULL,
  `AGGREGATEP4` varchar(100) NOT NULL,
  `P1BOT` varchar(100) NOT NULL,
  `P2BOT` varchar(100) NOT NULL,
  `P3BOT` varchar(100) NOT NULL,
  `P4BOT` varchar(100) NOT NULL,
  `code` varchar(200) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Dumping data for table `aleveltotalpoints`
--


-- --------------------------------------------------------

--
-- Table structure for table `best8`
--

CREATE TABLE `best8` (
  `id` int(11) NOT NULL auto_increment,
  `DIVI` varchar(200) NOT NULL,
  `Name` varchar(200) NOT NULL,
  `Class` varchar(200) NOT NULL,
  `Term` varchar(200) NOT NULL,
  `Year` varchar(200) NOT NULL,
  `Best_Eight_AGGREGATES` varchar(200) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=51 ;

--
-- Dumping data for table `best8`
--

INSERT INTO `best8` (`id`, `DIVI`, `Name`, `Class`, `Term`, `Year`, `Best_Eight_AGGREGATES`) VALUES
(41, 'ONE', 'HUZAIRU ABUDULU', 'P.1', 'ONE', '2018', '4'),
(42, 'ONE', 'KADDU EZEKEL', 'P.1', 'ONE', '2018', '4'),
(43, 'ONE', 'KALYANGO PAUL', 'P.1', 'ONE', '2018', '7'),
(44, 'ONE', 'KIRUMIRA ISAAC', 'P.1', 'ONE', '2018', '4'),
(45, 'ONE', 'KISERA GODFREY', 'P.1', 'ONE', '2018', '8'),
(46, 'ONE', 'MUKIIBI ABEL', 'P.1', 'ONE', '2018', '4'),
(47, 'TWO', 'MUKISA PAUL', 'P.1', 'ONE', '2018', '20'),
(48, 'ONE', 'NAKAKWA JANE', 'P.1', 'ONE', '2018', '8'),
(49, 'ONE', 'NAKATO TEDDY', 'P.1', 'ONE', '2018', '4'),
(50, 'ONE', 'NALUWU MAGI', 'P.1', 'ONE', '2018', '4');

-- --------------------------------------------------------

--
-- Table structure for table `classes`
--

CREATE TABLE `classes` (
  `id` int(11) NOT NULL auto_increment,
  `class` varchar(500) NOT NULL,
  `term` varchar(11) NOT NULL,
  `year` varchar(11) NOT NULL,
  `Class_Teacher` varchar(500) NOT NULL,
  `class_total` int(11) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=13 ;

--
-- Dumping data for table `classes`
--

INSERT INTO `classes` (`id`, `class`, `term`, `year`, `Class_Teacher`, `class_total`) VALUES
(3, 'P.1', 'ONE', '2018', 'Kiwanuka Muzafalu', 128),
(4, 'P.2', 'ONE', '2018', 'Kyeyune Sadat', 97),
(5, 'P.3', 'ONE', '2018', 'Ssenoga Farouq', 48),
(6, 'P.4 ', 'ONE', '2018', 'Sanyu Lilian Nakintu', 52),
(7, 'P.5', 'ONE', '2018', 'Nanyonjo Aidah', 25),
(8, 'P.6', 'ONE', '2018', 'Nakato Resty', 25),
(9, 'BABY', 'ONE', '2018', 'AE', 50),
(10, 'TOP CLASS', 'ONE', '2018', 'BB', 30),
(11, 'MIDDLE CLASS', 'ONE', '2018', 'MD', 20),
(12, 'P.7', 'ONE', '2018', 'MX', 10);

-- --------------------------------------------------------

--
-- Table structure for table `comments`
--

CREATE TABLE `comments` (
  `name` varchar(300) NOT NULL,
  `id` int(11) NOT NULL,
  `warden_comments` varchar(300) NOT NULL,
  `class_teacher_comments` varchar(300) NOT NULL,
  `head_teacher_comments` varchar(300) NOT NULL,
  `Class` varchar(20) NOT NULL,
  `Term` varchar(20) NOT NULL,
  `year` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `comments`
--


-- --------------------------------------------------------

--
-- Table structure for table `dates`
--

CREATE TABLE `dates` (
  `id` int(11) NOT NULL auto_increment,
  `closingdate` varchar(200) NOT NULL,
  `returndate` varchar(200) NOT NULL,
  `year` varchar(200) NOT NULL,
  `term` varchar(200) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `dates`
--

INSERT INTO `dates` (`id`, `closingdate`, `returndate`, `year`, `term`) VALUES
(1, '27-Apr-2018', '27-May-2018', '2018', 'ONE');

-- --------------------------------------------------------

--
-- Table structure for table `grades`
--

CREATE TABLE `grades` (
  `id` int(11) NOT NULL auto_increment,
  `class` varchar(200) NOT NULL,
  `Class_Teacher` varchar(500) NOT NULL,
  `year` varchar(100) NOT NULL,
  `name` varchar(200) NOT NULL,
  `subject` varchar(200) NOT NULL,
  `term` varchar(100) NOT NULL,
  `date` varchar(200) NOT NULL,
  `initial` varchar(200) NOT NULL,
  `password` varchar(400) NOT NULL,
  `mid` int(11) NOT NULL,
  `end` int(11) NOT NULL,
  `average` int(11) NOT NULL,
  `grade` varchar(500) NOT NULL,
  `aggregate` int(11) NOT NULL,
  `remark` varchar(500) NOT NULL,
  `entryid` varchar(200) NOT NULL,
  `bot` varchar(100) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=253 ;

--
-- Dumping data for table `grades`
--

INSERT INTO `grades` (`id`, `class`, `Class_Teacher`, `year`, `name`, `subject`, `term`, `date`, `initial`, `password`, `mid`, `end`, `average`, `grade`, `aggregate`, `remark`, `entryid`, `bot`) VALUES
(127, 'S.1', 'Kiwanuka Muzafalu', '2018', 'ABDALLAH SAMIRU', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 88, 99, 82, 'D1', 1, 'Good Attemp', 'E252', '58'),
(128, 'S.1', 'Kiwanuka Muzafalu', '2018', 'ALADO BRENDA', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 88, 88, 87, 'D1', 1, 'Good Attemp', 'E252', '85'),
(129, 'S.1', 'Kiwanuka Muzafalu', '2018', 'ALERA RONALD', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 99, 88, 85, 'D1', 1, 'Good Attemp', 'E252', '69'),
(130, 'S.1', 'Kiwanuka Muzafalu', '2018', 'ALOLO ALIYAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(131, 'S.1', 'Kiwanuka Muzafalu', '2018', 'AMANYIRE FAHAD', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(132, 'S.1', 'Kiwanuka Muzafalu', '2018', 'ASIIMWE EDGAR', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(133, 'S.1', 'Kiwanuka Muzafalu', '2018', 'ATIENO DOREEN', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(134, 'S.1', 'Kiwanuka Muzafalu', '2018', 'ATUGONZA PATRICIA', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(135, 'S.1', 'Kiwanuka Muzafalu', '2018', 'AWOR RUTH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(136, 'S.1', 'Kiwanuka Muzafalu', '2018', 'BAGALANA SADAT', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(137, 'S.1', 'Kiwanuka Muzafalu', '2018', 'BATTE ASHIRAF', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(138, 'S.1', 'Kiwanuka Muzafalu', '2018', 'BUKENYA YUSUF', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(139, 'S.1', 'Kiwanuka Muzafalu', '2018', 'BUSINGYE ZAINAB', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(140, 'S.1', 'Kiwanuka Muzafalu', '2018', 'DUMBA ABDUL', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(141, 'S.1', 'Kiwanuka Muzafalu', '2018', 'FAHIK LUKUMAN KIBIRIGE', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(142, 'S.1', 'Kiwanuka Muzafalu', '2018', 'HUZAIFAH ABDUMALIK', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(143, 'S.1', 'Kiwanuka Muzafalu', '2018', 'KAGGWA LAWRENCE', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(144, 'S.1', 'Kiwanuka Muzafalu', '2018', 'KALITESI AIDAH ', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(145, 'S.1', 'Kiwanuka Muzafalu', '2018', 'KALULE DERRICK', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(146, 'S.1', 'Kiwanuka Muzafalu', '2018', 'KANOONYA JOSHUA', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(147, 'S.1', 'Kiwanuka Muzafalu', '2018', 'KASUJJA MUBARAK', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(148, 'S.1', 'Kiwanuka Muzafalu', '2018', 'KASULE HINAYYAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(149, 'S.1', 'Kiwanuka Muzafalu', '2018', 'KASULE SHAFIK', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(150, 'S.1', 'Kiwanuka Muzafalu', '2018', 'KASULE YUSUF ', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(151, 'S.1', 'Kiwanuka Muzafalu', '2018', 'KATENDE AKRAM', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(152, 'S.1', 'Kiwanuka Muzafalu', '2018', 'KATEREGGA EDGAR', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(153, 'S.1', 'Kiwanuka Muzafalu', '2018', 'KATUSABE RUTH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(154, 'S.1', 'Kiwanuka Muzafalu', '2018', 'KAWUMA RONALD', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(155, 'S.1', 'Kiwanuka Muzafalu', '2018', 'KAZIBA ABDU', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(156, 'S.1', 'Kiwanuka Muzafalu', '2018', 'KIBERU KEITH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(157, 'S.1', 'Kiwanuka Muzafalu', '2018', 'KIVUMBI BADRU', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(158, 'S.1', 'Kiwanuka Muzafalu', '2018', 'KIYEMBA SULAIMAN', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(159, 'S.1', 'Kiwanuka Muzafalu', '2018', 'KIZZA AUGUSTINE', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(160, 'S.1', 'Kiwanuka Muzafalu', '2018', 'KUGONZA TIMOTHY', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(161, 'S.1', 'Kiwanuka Muzafalu', '2018', 'LUBEGA HASSAN', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(162, 'S.1', 'Kiwanuka Muzafalu', '2018', 'LUBEGA MARVIN', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(163, 'S.1', 'Kiwanuka Muzafalu', '2018', 'LUBWAMA SULAIMAN', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(164, 'S.1', 'Kiwanuka Muzafalu', '2018', 'LUMALA SHARIF', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(165, 'S.1', 'Kiwanuka Muzafalu', '2018', 'LUNKUSE HALIMAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(166, 'S.1', 'Kiwanuka Muzafalu', '2018', 'LUTAYA FAHAD', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(167, 'S.1', 'Kiwanuka Muzafalu', '2018', 'MATOVU BASHIR', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(168, 'S.1', 'Kiwanuka Muzafalu', '2018', 'MAWANDA ALLAN', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(169, 'S.1', 'Kiwanuka Muzafalu', '2018', 'MUGULUMA ABDUL', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(170, 'S.1', 'Kiwanuka Muzafalu', '2018', 'MUJUZI MUZAMIRU ', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(171, 'S.1', 'Kiwanuka Muzafalu', '2018', 'MUNGURIEK DESIRE', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(172, 'S.1', 'Kiwanuka Muzafalu', '2018', 'MUSOKE ARAFAT', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(173, 'S.1', 'Kiwanuka Muzafalu', '2018', 'MUTEBI ALI', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(174, 'S.1', 'Kiwanuka Muzafalu', '2018', 'MUTESASIRA SHAMRAN', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(175, 'S.1', 'Kiwanuka Muzafalu', '2018', 'MUTYABA HUZAIFAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(176, 'S.1', 'Kiwanuka Muzafalu', '2018', 'MUTYABA RAMATHAN', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(177, 'S.1', 'Kiwanuka Muzafalu', '2018', 'MUWONGE MAHAD', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(178, 'S.1', 'Kiwanuka Muzafalu', '2018', 'MUWONGE MUBARAK', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(179, 'S.1', 'Kiwanuka Muzafalu', '2018', 'MUYOMBA MUHAMOOD', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(180, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NABUGOHE HALIMAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(181, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NAGAWA JOAN', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(182, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NAGAWA SAFINA', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(183, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NAGGAYI RAHMAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(184, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NAGGAYI SHARIFAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(185, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NAGGINDA SHAKIRAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(186, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NAJJUUKO SHALUWAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(187, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NAKABUYE RAHMAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(188, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NAKAFUUMA AISHA', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(189, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NAKALEMA HANIFAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(190, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NAKAMATTE RAHMAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(191, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NAKASAGGA SOFIA ', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(192, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NAKAYENGA ELIZABETH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(193, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NAKITTO BRENDA', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(194, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NAKYEJJWE JALIAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(195, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NALULE HAJARAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(196, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NALUWU FATHIRAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(197, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NALWADDA SHAMUSA', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(198, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NALWANGA HALIMAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(199, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NALWEYISO AMINA', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(200, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NALWEYISO SHATRAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(201, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NAMAGANDA HAMIDAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(202, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NAMAGANDA KHAFIAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(203, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NAMAGANDA LAILAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(204, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NAMAKULA BENITAH ', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(205, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NAMAWEJJE HAAWAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(206, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NAMAZZI RAHIMAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(207, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NAMBOGO MARIAM', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(208, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NAMUGANYI BRIDGET', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(209, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NAMUGERWA AIDAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(210, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NAMUGERWA SHAKIRA', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(211, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NAMUJJU NUSURAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(212, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NAMUKASA WALIA', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(213, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NAMULINDWA SHADIA', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(214, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NAMUYIGA FAUSTAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(215, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NAMUYOMBA NUBUAT', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(216, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NANDIBAWA WALUDAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(217, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NANFUKA GETRUDE ', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(218, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NANFUKA TRONELLA ', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(219, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NANKINGA SHAKIRAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(220, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NANKWANGA HAIRAT', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(221, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NANKYA SHALUWAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(222, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NANSAMBA LATIFAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(223, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NANSAMBA SHADIA ', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(224, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NANSIMBE  NABIRA', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(225, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NANTAMBI SHAKIRAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(226, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NANTONGO TRACY', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(227, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NANTUME AMINAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(228, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NANYANZI FARIDAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(229, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NANYONDO LETICIA', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(230, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NANYONGA WALUDAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(231, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NASAAZI GLORIA ', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(232, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NASSANGA SHALUWAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(233, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NASSONKO SUMAYYAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(234, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NASUUNA NAKIAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(235, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NATTABI HADIJAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(236, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NAYIGA LUKAYIYAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(237, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NDUGWA AKRAM', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(238, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NIYONSABA APOPHIA', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(239, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NSUBUGA DENIS ', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(240, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NSUBUGA MUHAMMAD', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(241, 'S.1', 'Kiwanuka Muzafalu', '2018', 'NYOMBI SHAFIC', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(242, 'S.1', 'Kiwanuka Muzafalu', '2018', 'SAHAYO ERINA', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(243, 'S.1', 'Kiwanuka Muzafalu', '2018', 'SEKANDI MUHAMMAD', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(244, 'S.1', 'Kiwanuka Muzafalu', '2018', 'SSEBULIME IBRAHIM', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(245, 'S.1', 'Kiwanuka Muzafalu', '2018', 'SSEMAKULA HABIIB', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(246, 'S.1', 'Kiwanuka Muzafalu', '2018', 'SSEMPIJJA PAUL', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(247, 'S.1', 'Kiwanuka Muzafalu', '2018', 'SSEMWOGERERE AKRAM', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(248, 'S.1', 'Kiwanuka Muzafalu', '2018', 'SSERUNJOGI IBRAHIM', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(249, 'S.1', 'Kiwanuka Muzafalu', '2018', 'SSERUNJOGI SUMAYAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(250, 'S.1', 'Kiwanuka Muzafalu', '2018', 'TUSABE MUHAMMAD ', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(251, 'S.1', 'Kiwanuka Muzafalu', '2018', 'WANJA LATIFAH', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-'),
(252, 'S.1', 'Kiwanuka Muzafalu', '2018', 'WASSWA UTHUMAN', 'ENGLISH', 'ONE', '14-Apr-2018', 'SL', '', 0, 0, 0, '-', 0, '-', 'E252', '-');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `id` int(11) NOT NULL auto_increment,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `usertype` varchar(20) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`id`, `username`, `password`, `usertype`) VALUES
(1, 'admin', 'admin', 'admin'),
(2, 'user', 'user', 'user');

-- --------------------------------------------------------

--
-- Table structure for table `marks`
--

CREATE TABLE `marks` (
  `id` int(11) NOT NULL auto_increment,
  `class` varchar(200) NOT NULL,
  `Class_Teacher` varchar(500) NOT NULL,
  `year` varchar(100) NOT NULL,
  `name` varchar(200) NOT NULL,
  `subject` varchar(200) NOT NULL,
  `term` varchar(100) NOT NULL,
  `date` varchar(200) NOT NULL,
  `initial` varchar(200) NOT NULL,
  `password` varchar(400) NOT NULL,
  `mid` int(11) NOT NULL,
  `end` int(11) NOT NULL,
  `average` int(11) NOT NULL,
  `grade` varchar(500) NOT NULL,
  `aggregate` varchar(11) NOT NULL,
  `remark` varchar(500) NOT NULL,
  `entryid` varchar(200) NOT NULL,
  `Best8` varchar(100) NOT NULL,
  `bot` varchar(100) NOT NULL,
  `code` varchar(200) NOT NULL,
  `DIVI` varchar(400) NOT NULL,
  `assessement` varchar(400) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=92 ;

--
-- Dumping data for table `marks`
--

INSERT INTO `marks` (`id`, `class`, `Class_Teacher`, `year`, `name`, `subject`, `term`, `date`, `initial`, `password`, `mid`, `end`, `average`, `grade`, `aggregate`, `remark`, `entryid`, `Best8`, `bot`, `code`, `DIVI`, `assessement`) VALUES
(12, 'P.1', 'Kiwanuka Muzafalu', '2018', 'HUZAIRU ABUDULU', 'MATHEMATICS', 'ONE', '08-May-2018', 'SH', '', 90, 98, 94, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(13, 'P.1', 'Kiwanuka Muzafalu', '2018', 'KADDU EZEKEL', 'MATHEMATICS', 'ONE', '08-May-2018', 'SH', '', 99, 89, 94, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(14, 'P.1', 'Kiwanuka Muzafalu', '2018', 'KALYANGO PAUL', 'MATHEMATICS', 'ONE', '08-May-2018', 'SH', '', 56, 90, 73, 'D2', '2', 'Very Good', 'E1', '7', '-', '', 'ONE', ''),
(15, 'P.1', 'Kiwanuka Muzafalu', '2018', 'KIRUMIRA ISAAC', 'MATHEMATICS', 'ONE', '08-May-2018', 'SH', '', 99, 67, 83, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(16, 'P.1', 'Kiwanuka Muzafalu', '2018', 'KISERA GODFREY', 'MATHEMATICS', 'ONE', '08-May-2018', 'SH', '', 90, 67, 79, 'D2', '2', 'Very Good', 'E1', '8', '-', '', 'ONE', ''),
(17, 'P.1', 'Kiwanuka Muzafalu', '2018', 'MUKIIBI ABEL', 'MATHEMATICS', 'ONE', '08-May-2018', 'SH', '', 90, 89, 90, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(18, 'P.1', 'Kiwanuka Muzafalu', '2018', 'MUKISA PAUL', 'MATHEMATICS', 'ONE', '08-May-2018', 'SH', '', 34, 78, 56, 'C5', '5', 'Aim higher', 'E1', '20', '-', '', 'TWO', ''),
(19, 'P.1', 'Kiwanuka Muzafalu', '2018', 'NAKAKWA JANE', 'MATHEMATICS', 'ONE', '08-May-2018', 'SH', '', 45, 89, 67, 'C3', '3', 'Aim higher', 'E1', '8', '-', '', 'ONE', ''),
(20, 'P.1', 'Kiwanuka Muzafalu', '2018', 'NAKATO TEDDY', 'MATHEMATICS', 'ONE', '08-May-2018', 'SH', '', 90, 78, 84, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(21, 'P.1', 'Kiwanuka Muzafalu', '2018', 'NALUWU MAGI', 'MATHEMATICS', 'ONE', '08-May-2018', 'SH', '', 78, 90, 84, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(22, 'P.1', 'Kiwanuka Muzafalu', '2018', 'HUZAIRU ABUDULU', 'SST', 'ONE', '08-May-2018', 'NF', '', 90, 98, 94, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(23, 'P.1', 'Kiwanuka Muzafalu', '2018', 'KADDU EZEKEL', 'SST', 'ONE', '08-May-2018', 'NF', '', 99, 89, 94, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(24, 'P.1', 'Kiwanuka Muzafalu', '2018', 'KALYANGO PAUL', 'SST', 'ONE', '08-May-2018', 'NF', '', 56, 90, 73, 'D2', '2', 'Very Good', 'E1', '7', '-', '', 'ONE', ''),
(25, 'P.1', 'Kiwanuka Muzafalu', '2018', 'KIRUMIRA ISAAC', 'SST', 'ONE', '08-May-2018', 'NF', '', 99, 67, 83, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(26, 'P.1', 'Kiwanuka Muzafalu', '2018', 'KISERA GODFREY', 'SST', 'ONE', '08-May-2018', 'NF', '', 90, 67, 79, 'D2', '2', 'Very Good', 'E1', '8', '-', '', 'ONE', ''),
(27, 'P.1', 'Kiwanuka Muzafalu', '2018', 'MUKIIBI ABEL', 'SST', 'ONE', '08-May-2018', 'NF', '', 90, 89, 90, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(28, 'P.1', 'Kiwanuka Muzafalu', '2018', 'MUKISA PAUL', 'SST', 'ONE', '08-May-2018', 'NF', '', 34, 78, 56, 'C5', '5', 'Aim higher', 'E1', '20', '-', '', 'TWO', ''),
(29, 'P.1', 'Kiwanuka Muzafalu', '2018', 'NAKAKWA JANE', 'SST', 'ONE', '08-May-2018', 'NF', '', 90, 50, 70, 'D2', '2', 'Very Good', 'E1', '8', '-', '', 'ONE', ''),
(30, 'P.1', 'Kiwanuka Muzafalu', '2018', 'NAKATO TEDDY', 'SST', 'ONE', '08-May-2018', 'NF', '', 90, 78, 84, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(31, 'P.1', 'Kiwanuka Muzafalu', '2018', 'NALUWU MAGI', 'SST', 'ONE', '08-May-2018', 'NF', '', 78, 90, 84, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(32, 'P.1', 'Kiwanuka Muzafalu', '2018', 'HUZAIRU ABUDULU', 'SCIENCE', 'ONE', '08-May-2018', 'BA', '', 90, 98, 94, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(33, 'P.1', 'Kiwanuka Muzafalu', '2018', 'KADDU EZEKEL', 'SCIENCE', 'ONE', '08-May-2018', 'BA', '', 99, 89, 94, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(34, 'P.1', 'Kiwanuka Muzafalu', '2018', 'KALYANGO PAUL', 'SCIENCE', 'ONE', '08-May-2018', 'BA', '', 56, 90, 73, 'D2', '2', 'Very Good', 'E1', '7', '-', '', 'ONE', ''),
(35, 'P.1', 'Kiwanuka Muzafalu', '2018', 'KIRUMIRA ISAAC', 'SCIENCE', 'ONE', '08-May-2018', 'BA', '', 99, 67, 83, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(36, 'P.1', 'Kiwanuka Muzafalu', '2018', 'KISERA GODFREY', 'SCIENCE', 'ONE', '08-May-2018', 'BA', '', 90, 67, 79, 'D2', '2', 'Very Good', 'E1', '8', '-', '', 'ONE', ''),
(37, 'P.1', 'Kiwanuka Muzafalu', '2018', 'MUKIIBI ABEL', 'SCIENCE', 'ONE', '08-May-2018', 'BA', '', 90, 89, 90, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(38, 'P.1', 'Kiwanuka Muzafalu', '2018', 'MUKISA PAUL', 'SCIENCE', 'ONE', '08-May-2018', 'BA', '', 60, 56, 58, 'C5', '5', 'Aim higher', 'E1', '20', '-', '', 'TWO', ''),
(39, 'P.1', 'Kiwanuka Muzafalu', '2018', 'NAKAKWA JANE', 'SCIENCE', 'ONE', '08-May-2018', 'BA', '', 90, 50, 70, 'D2', '2', 'Very Good', 'E1', '8', '-', '', 'ONE', ''),
(40, 'P.1', 'Kiwanuka Muzafalu', '2018', 'NAKATO TEDDY', 'SCIENCE', 'ONE', '08-May-2018', 'BA', '', 90, 78, 84, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(41, 'P.1', 'Kiwanuka Muzafalu', '2018', 'NALUWU MAGI', 'SCIENCE', 'ONE', '08-May-2018', 'BA', '', 78, 90, 84, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(42, 'P.1', 'Kiwanuka Muzafalu', '2018', 'HUZAIRU ABUDULU', 'LITRACY1', 'ONE', '08-May-2018', 'MY', '', 90, 98, 94, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(43, 'P.1', 'Kiwanuka Muzafalu', '2018', 'KADDU EZEKEL', 'LITRACY1', 'ONE', '08-May-2018', 'MY', '', 99, 89, 94, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(44, 'P.1', 'Kiwanuka Muzafalu', '2018', 'KALYANGO PAUL', 'LITRACY1', 'ONE', '08-May-2018', 'MY', '', 56, 90, 73, 'D2', '2', 'Very Good', 'E1', '7', '-', '', 'ONE', ''),
(45, 'P.1', 'Kiwanuka Muzafalu', '2018', 'KIRUMIRA ISAAC', 'LITRACY1', 'ONE', '08-May-2018', 'MY', '', 99, 67, 83, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(46, 'P.1', 'Kiwanuka Muzafalu', '2018', 'KISERA GODFREY', 'LITRACY1', 'ONE', '08-May-2018', 'MY', '', 90, 67, 79, 'D2', '2', 'Very Good', 'E1', '8', '-', '', 'ONE', ''),
(47, 'P.1', 'Kiwanuka Muzafalu', '2018', 'MUKIIBI ABEL', 'LITRACY1', 'ONE', '08-May-2018', 'MY', '', 90, 89, 90, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(48, 'P.1', 'Kiwanuka Muzafalu', '2018', 'MUKISA PAUL', 'LITRACY1', 'ONE', '08-May-2018', 'MY', '', 60, 56, 58, 'C5', '5', 'Aim higher', 'E1', '20', '-', '', 'TWO', ''),
(49, 'P.1', 'Kiwanuka Muzafalu', '2018', 'NAKAKWA JANE', 'LITRACY1', 'ONE', '08-May-2018', 'MY', '', 90, 50, 70, 'D2', '2', 'Very Good', 'E1', '8', '-', '', 'ONE', ''),
(50, 'P.1', 'Kiwanuka Muzafalu', '2018', 'NAKATO TEDDY', 'LITRACY1', 'ONE', '08-May-2018', 'MY', '', 90, 78, 84, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(51, 'P.1', 'Kiwanuka Muzafalu', '2018', 'NALUWU MAGI', 'LITRACY1', 'ONE', '08-May-2018', 'MY', '', 78, 90, 84, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(52, 'P.1', 'Kiwanuka Muzafalu', '2018', 'HUZAIRU ABUDULU', 'LITRACY2', 'ONE', '08-May-2018', 'NR', '', 90, 98, 94, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(53, 'P.1', 'Kiwanuka Muzafalu', '2018', 'KADDU EZEKEL', 'LITRACY2', 'ONE', '08-May-2018', 'NR', '', 99, 89, 94, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(54, 'P.1', 'Kiwanuka Muzafalu', '2018', 'KALYANGO PAUL', 'LITRACY2', 'ONE', '08-May-2018', 'NR', '', 56, 90, 73, 'D2', '2', 'Very Good', 'E1', '7', '-', '', 'ONE', ''),
(55, 'P.1', 'Kiwanuka Muzafalu', '2018', 'KIRUMIRA ISAAC', 'LITRACY2', 'ONE', '08-May-2018', 'NR', '', 99, 67, 83, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(56, 'P.1', 'Kiwanuka Muzafalu', '2018', 'KISERA GODFREY', 'LITRACY2', 'ONE', '08-May-2018', 'NR', '', 90, 67, 79, 'D2', '2', 'Very Good', 'E1', '8', '-', '', 'ONE', ''),
(57, 'P.1', 'Kiwanuka Muzafalu', '2018', 'MUKIIBI ABEL', 'LITRACY2', 'ONE', '08-May-2018', 'NR', '', 90, 89, 90, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(58, 'P.1', 'Kiwanuka Muzafalu', '2018', 'MUKISA PAUL', 'LITRACY2', 'ONE', '08-May-2018', 'NR', '', 60, 56, 58, 'C5', '5', 'Aim higher', 'E1', '20', '-', '', 'TWO', ''),
(59, 'P.1', 'Kiwanuka Muzafalu', '2018', 'NAKAKWA JANE', 'LITRACY2', 'ONE', '08-May-2018', 'NR', '', 90, 50, 70, 'D2', '2', 'Very Good', 'E1', '8', '-', '', 'ONE', ''),
(60, 'P.1', 'Kiwanuka Muzafalu', '2018', 'NAKATO TEDDY', 'LITRACY2', 'ONE', '08-May-2018', 'NR', '', 90, 78, 84, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(61, 'P.1', 'Kiwanuka Muzafalu', '2018', 'NALUWU MAGI', 'LITRACY2', 'ONE', '08-May-2018', 'NR', '', 78, 90, 84, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(62, 'P.1', 'Kiwanuka Muzafalu', '2018', 'HUZAIRU ABUDULU', 'COMPUTER', 'ONE', '08-May-2018', 'KU', '', 90, 98, 94, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(63, 'P.1', 'Kiwanuka Muzafalu', '2018', 'KADDU EZEKEL', 'COMPUTER', 'ONE', '08-May-2018', 'KU', '', 99, 89, 94, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(64, 'P.1', 'Kiwanuka Muzafalu', '2018', 'KALYANGO PAUL', 'COMPUTER', 'ONE', '08-May-2018', 'KU', '', 56, 90, 73, 'D2', '2', 'Very Good', 'E1', '7', '-', '', 'ONE', ''),
(65, 'P.1', 'Kiwanuka Muzafalu', '2018', 'KIRUMIRA ISAAC', 'COMPUTER', 'ONE', '08-May-2018', 'KU', '', 99, 67, 83, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(66, 'P.1', 'Kiwanuka Muzafalu', '2018', 'KISERA GODFREY', 'COMPUTER', 'ONE', '08-May-2018', 'KU', '', 90, 67, 79, 'D2', '2', 'Very Good', 'E1', '8', '-', '', 'ONE', ''),
(67, 'P.1', 'Kiwanuka Muzafalu', '2018', 'MUKIIBI ABEL', 'COMPUTER', 'ONE', '08-May-2018', 'KU', '', 90, 89, 90, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(68, 'P.1', 'Kiwanuka Muzafalu', '2018', 'MUKISA PAUL', 'COMPUTER', 'ONE', '08-May-2018', 'KU', '', 60, 56, 58, 'C5', '5', 'Aim higher', 'E1', '20', '-', '', 'TWO', ''),
(69, 'P.1', 'Kiwanuka Muzafalu', '2018', 'NAKAKWA JANE', 'COMPUTER', 'ONE', '08-May-2018', 'KU', '', 90, 50, 70, 'D2', '2', 'Very Good', 'E1', '8', '-', '', 'ONE', ''),
(70, 'P.1', 'Kiwanuka Muzafalu', '2018', 'NAKATO TEDDY', 'COMPUTER', 'ONE', '08-May-2018', 'KU', '', 90, 78, 84, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(71, 'P.1', 'Kiwanuka Muzafalu', '2018', 'NALUWU MAGI', 'COMPUTER', 'ONE', '08-May-2018', 'KU', '', 45, 90, 68, 'C3', '3', 'Aim higher', 'E1', '4', '-', '', 'ONE', ''),
(72, 'P.1', 'Kiwanuka Muzafalu', '2018', 'HUZAIRU ABUDULU', 'WRITTING', 'ONE', '08-May-2018', 'SA', '', 90, 98, 94, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(73, 'P.1', 'Kiwanuka Muzafalu', '2018', 'KADDU EZEKEL', 'WRITTING', 'ONE', '08-May-2018', 'SA', '', 99, 89, 94, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(74, 'P.1', 'Kiwanuka Muzafalu', '2018', 'KALYANGO PAUL', 'WRITTING', 'ONE', '08-May-2018', 'SA', '', 90, 90, 90, 'D1', '1', 'Good Attemp', 'E1', '7', '-', '', 'ONE', ''),
(75, 'P.1', 'Kiwanuka Muzafalu', '2018', 'KIRUMIRA ISAAC', 'WRITTING', 'ONE', '08-May-2018', 'SA', '', 99, 67, 83, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(76, 'P.1', 'Kiwanuka Muzafalu', '2018', 'KISERA GODFREY', 'WRITTING', 'ONE', '08-May-2018', 'SA', '', 90, 67, 79, 'D2', '2', 'Very Good', 'E1', '8', '-', '', 'ONE', ''),
(77, 'P.1', 'Kiwanuka Muzafalu', '2018', 'MUKIIBI ABEL', 'WRITTING', 'ONE', '08-May-2018', 'SA', '', 90, 89, 90, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(78, 'P.1', 'Kiwanuka Muzafalu', '2018', 'MUKISA PAUL', 'WRITTING', 'ONE', '08-May-2018', 'SA', '', 60, 56, 58, 'C5', '5', 'Aim higher', 'E1', '20', '-', '', 'TWO', ''),
(79, 'P.1', 'Kiwanuka Muzafalu', '2018', 'NAKAKWA JANE', 'WRITTING', 'ONE', '08-May-2018', 'SA', '', 90, 50, 70, 'D2', '2', 'Very Good', 'E1', '8', '-', '', 'ONE', ''),
(80, 'P.1', 'Kiwanuka Muzafalu', '2018', 'NAKATO TEDDY', 'WRITTING', 'ONE', '08-May-2018', 'SA', '', 90, 78, 84, 'D1', '1', 'Good Attemp', 'E1', '4', '-', '', 'ONE', ''),
(81, 'P.1', 'Kiwanuka Muzafalu', '2018', 'NALUWU MAGI', 'WRITTING', 'ONE', '08-May-2018', 'SA', '', 45, 90, 68, 'C3', '3', 'Aim higher', 'E1', '4', '-', '', 'ONE', ''),
(82, 'P.1', 'Kiwanuka Muzafalu', '2018', 'HUZAIRU ABUDULU', 'ENGLISH', 'TWO', '', 'SL', '', 0, 0, 0, '-', '0', '-', 'E81', '', '-', '001', '', 'MID AND END'),
(83, 'P.1', 'Kiwanuka Muzafalu', '2018', 'KADDU EZEKEL', 'ENGLISH', 'TWO', '', 'SL', '', 0, 0, 0, '-', '0', '-', 'E81', '', '-', '001', '', 'MID AND END'),
(84, 'P.1', 'Kiwanuka Muzafalu', '2018', 'KALYANGO PAUL', 'ENGLISH', 'TWO', '', 'SL', '', 0, 0, 0, '-', '0', '-', 'E81', '', '-', '001', '', 'MID AND END'),
(85, 'P.1', 'Kiwanuka Muzafalu', '2018', 'KIRUMIRA ISAAC', 'ENGLISH', 'TWO', '', 'SL', '', 0, 0, 0, '-', '0', '-', 'E81', '', '-', '001', '', 'MID AND END'),
(86, 'P.1', 'Kiwanuka Muzafalu', '2018', 'KISERA GODFREY', 'ENGLISH', 'TWO', '', 'SL', '', 0, 0, 0, '-', '0', '-', 'E81', '', '-', '001', '', 'MID AND END'),
(87, 'P.1', 'Kiwanuka Muzafalu', '2018', 'MUKIIBI ABEL', 'ENGLISH', 'TWO', '', 'SL', '', 0, 0, 0, '-', '0', '-', 'E81', '', '-', '001', '', 'MID AND END'),
(88, 'P.1', 'Kiwanuka Muzafalu', '2018', 'MUKISA PAUL', 'ENGLISH', 'TWO', '', 'SL', '', 0, 0, 0, '-', '0', '-', 'E81', '', '-', '001', '', 'MID AND END'),
(89, 'P.1', 'Kiwanuka Muzafalu', '2018', 'NAKAKWA JANE', 'ENGLISH', 'TWO', '', 'SL', '', 0, 0, 0, '-', '0', '-', 'E81', '', '-', '001', '', 'MID AND END'),
(90, 'P.1', 'Kiwanuka Muzafalu', '2018', 'NAKATO TEDDY', 'ENGLISH', 'TWO', '', 'SL', '', 0, 0, 0, '-', '0', '-', 'E81', '', '-', '001', '', 'MID AND END'),
(91, 'P.1', 'Kiwanuka Muzafalu', '2018', 'NALUWU MAGI', 'ENGLISH', 'TWO', '', 'SL', '', 0, 0, 0, '-', '0', '-', 'E81', '', '-', '001', '', 'MID AND END');

-- --------------------------------------------------------

--
-- Table structure for table `photo`
--

CREATE TABLE `photo` (
  `id` int(11) NOT NULL auto_increment,
  `name` varchar(300) NOT NULL,
  `image` blob NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Dumping data for table `photo`
--


-- --------------------------------------------------------

--
-- Table structure for table `positions`
--

CREATE TABLE `positions` (
  `id` int(11) NOT NULL auto_increment,
  `name` varchar(200) NOT NULL,
  `class` varchar(200) NOT NULL,
  `term` varchar(200) NOT NULL,
  `year` varchar(200) NOT NULL,
  `TotalMark` int(11) NOT NULL,
  `position` int(11) NOT NULL,
  `HEADTEACTHER` varchar(400) NOT NULL,
  `CLASSTEACTHER` varchar(400) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=41 ;

--
-- Dumping data for table `positions`
--

INSERT INTO `positions` (`id`, `name`, `class`, `term`, `year`, `TotalMark`, `position`, `HEADTEACTHER`, `CLASSTEACTHER`) VALUES
(31, 'KADDU EZEKEL', 'P.1', 'ONE', '2018', 752, 1, 'Promising results just put in more effort.', 'Good results but do not relax if you need better results.'),
(32, 'HUZAIRU ABUDULU', 'P.1', 'ONE', '2018', 735, 2, 'Promising results just put in more effort.', 'Good results but do not relax if you need better results.'),
(33, 'MUKIIBI ABEL', 'P.1', 'ONE', '2018', 720, 3, 'Promising results just put in more effort.', 'Good results but do not relax if you need better results.'),
(34, 'NAKATO TEDDY', 'P.1', 'ONE', '2018', 672, 4, 'Promising results just put in more effort.', 'Good results but do not relax if you need better results.'),
(35, 'NALUWU MAGI', 'P.1', 'ONE', '2018', 640, 5, 'Promising results just put in more effort.', 'Good results but do not relax if you need better results.'),
(36, 'KISERA GODFREY', 'P.1', 'ONE', '2018', 632, 6, 'Promising results just put in more effort.', 'Good results but do not relax if you need better results.'),
(37, 'KIRUMIRA ISAAC', 'P.1', 'ONE', '2018', 626, 7, 'Promising results just put in more effort.', 'Good results but do not relax if you need better results.'),
(38, 'KALYANGO PAUL', 'P.1', 'ONE', '2018', 601, 8, 'Promising results just put in more effort.', 'Good results but do not relax if you need better results.'),
(39, 'NAKAKWA JANE', 'P.1', 'ONE', '2018', 554, 9, 'Promising results just put in more effort.', 'Good results but do not relax if you need better results.'),
(40, 'MUKISA PAUL', 'P.1', 'ONE', '2018', 458, 10, 'Promising results just put in more effort.', 'Good results but do not relax if you need better results.');

-- --------------------------------------------------------

--
-- Table structure for table `signature`
--

CREATE TABLE `signature` (
  `id` int(11) NOT NULL auto_increment,
  `name` varchar(200) NOT NULL,
  `image` blob NOT NULL,
  `class` varchar(200) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Dumping data for table `signature`
--


-- --------------------------------------------------------

--
-- Table structure for table `students`
--

CREATE TABLE `students` (
  `id` int(11) NOT NULL auto_increment,
  `name` varchar(400) NOT NULL,
  `class` varchar(400) NOT NULL,
  `year` varchar(400) NOT NULL,
  `combination` varchar(400) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=11 ;

--
-- Dumping data for table `students`
--

INSERT INTO `students` (`id`, `name`, `class`, `year`, `combination`) VALUES
(1, 'KIRUMIRA ISAAC', 'P.1', '2018', ''),
(2, 'KADDU EZEKEL', 'P.1', '2018', ''),
(3, 'MUKISA PAUL', 'P.1', '2018', ''),
(4, 'MUKIIBI ABEL', 'P.1', '2018', ''),
(5, 'NAKATO TEDDY', 'P.1', '2018', ''),
(6, 'NALUWU MAGI', 'P.1', '2018', ''),
(7, 'KISERA GODFREY', 'P.1', '2018', ''),
(8, 'KALYANGO PAUL', 'P.1', '2018', ''),
(9, 'HUZAIRU ABUDULU', 'P.1', '2018', ''),
(10, 'NAKAKWA JANE', 'P.1', '2018', '');

-- --------------------------------------------------------

--
-- Table structure for table `subjects`
--

CREATE TABLE `subjects` (
  `id` int(11) NOT NULL auto_increment,
  `subject` varchar(500) NOT NULL,
  `code` varchar(200) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=11 ;

--
-- Dumping data for table `subjects`
--

INSERT INTO `subjects` (`id`, `subject`, `code`) VALUES
(1, 'ENGLISH', '001'),
(2, 'MATHEMATICS', '002'),
(5, 'SST', '003'),
(6, 'SCIENCE', '004'),
(7, 'LITRACY1', '005'),
(8, 'LITRACY2', '006'),
(9, 'COMPUTER', '007'),
(10, 'WRITTING', '008');

-- --------------------------------------------------------

--
-- Table structure for table `teachers`
--

CREATE TABLE `teachers` (
  `id` int(11) NOT NULL auto_increment,
  `name` varchar(500) NOT NULL,
  `initial` varchar(500) NOT NULL,
  `password` varchar(500) NOT NULL,
  `subject` varchar(500) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Dumping data for table `teachers`
--

INSERT INTO `teachers` (`id`, `name`, `initial`, `password`, `subject`) VALUES
(1, 'SANYU LILIAN', 'SL', 'SL', 'ENGLISH'),
(2, 'SSEBADDUKA HUZAIRU', 'SH', 'SH', 'MATHEMATICS'),
(3, 'NABUKENYA FARIDAH', 'NF', 'NF', 'SST'),
(4, 'BUSINGYE ABDULMAJID', 'BA', 'BA', 'SCIENCE'),
(5, 'MUKASA YASIN', 'MY', 'MY', 'LITRACY1'),
(6, 'NAKATO RESTY', 'NR', 'NR', 'LITRACY2'),
(7, 'KAKIKKA UMAR', 'KU', 'KU', 'COMPUTER'),
(8, 'SSEMBOGGA ASUMAN', 'SA', 'SA', 'WRITTING');

-- --------------------------------------------------------

--
-- Table structure for table `totals`
--

CREATE TABLE `totals` (
  `id` int(11) NOT NULL auto_increment,
  `name` varchar(200) NOT NULL,
  `class` varchar(200) NOT NULL,
  `term` varchar(200) NOT NULL,
  `year` varchar(200) NOT NULL,
  `TotalMark` int(11) NOT NULL,
  `HEADTEACTHER` varchar(400) NOT NULL,
  `CLASSTEACTHER` varchar(400) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=41 ;

--
-- Dumping data for table `totals`
--

INSERT INTO `totals` (`id`, `name`, `class`, `term`, `year`, `TotalMark`, `HEADTEACTHER`, `CLASSTEACTHER`) VALUES
(31, 'HUZAIRU ABUDULU', 'P.1', 'ONE', '2018', 735, 'none', 'none'),
(32, 'KADDU EZEKEL', 'P.1', 'ONE', '2018', 752, 'none', 'none'),
(33, 'KALYANGO PAUL', 'P.1', 'ONE', '2018', 601, 'none', 'none'),
(34, 'KIRUMIRA ISAAC', 'P.1', 'ONE', '2018', 626, 'none', 'none'),
(35, 'KISERA GODFREY', 'P.1', 'ONE', '2018', 632, 'none', 'none'),
(36, 'MUKIIBI ABEL', 'P.1', 'ONE', '2018', 720, 'none', 'none'),
(37, 'MUKISA PAUL', 'P.1', 'ONE', '2018', 458, 'none', 'none'),
(38, 'NAKAKWA JANE', 'P.1', 'ONE', '2018', 554, 'none', 'none'),
(39, 'NAKATO TEDDY', 'P.1', 'ONE', '2018', 672, 'none', 'none'),
(40, 'NALUWU MAGI', 'P.1', 'ONE', '2018', 640, 'none', 'none');
