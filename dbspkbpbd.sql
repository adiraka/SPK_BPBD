-- phpMyAdmin SQL Dump
-- version 4.5.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Sep 26, 2016 at 06:41 PM
-- Server version: 5.7.11
-- PHP Version: 5.6.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbspkbpbd`
--

-- --------------------------------------------------------

--
-- Table structure for table `analisa`
--

CREATE TABLE `analisa` (
  `id` int(11) NOT NULL,
  `nik` varchar(16) NOT NULL,
  `nip` varchar(15) NOT NULL,
  `kj` double NOT NULL,
  `kr` double NOT NULL,
  `ss` double NOT NULL,
  `tb` double NOT NULL,
  `ha` varchar(5) NOT NULL,
  `stat` enum('DITOLAK','DIPERTIMBANGKAN','DITERIMA') NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `analisa`
--

INSERT INTO `analisa` (`id`, `nik`, `nip`, `kj`, `kr`, `ss`, `tb`, `ha`, `stat`) VALUES
(6, '123456', '12345', 70, 67, 76, 87, '72,55', 'DITERIMA'),
(7, '54321', '12345', 57, 77, 65, 45, '62,4', 'DIPERTIMBANGKAN'),
(8, '1345', '22', 100, 70, 65, 56, '79,15', 'DITERIMA'),
(10, '111', '12345', 56, 45, 77, 87, '60,5', 'DIPERTIMBANGKAN'),
(11, '1213', '1122', 10, 30, 20, 30, '20,5', 'DITOLAK');

-- --------------------------------------------------------

--
-- Table structure for table `pemohon`
--

CREATE TABLE `pemohon` (
  `nik` varchar(16) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `tempat_lahir` varchar(30) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `jekel` enum('LAKI-LAKI','PEREMPUAN') NOT NULL,
  `alamat` text NOT NULL,
  `rt` varchar(3) NOT NULL,
  `rw` varchar(3) NOT NULL,
  `kel` varchar(30) NOT NULL,
  `kec` varchar(30) NOT NULL,
  `agama` enum('ISLAM','KATOLIK','PROTESTAN','HINDU','BUDDHA','KONGHUCU') NOT NULL,
  `goldar` enum('A','B','AB','O') NOT NULL,
  `status` enum('KAWIN','BELUM KAWIN') NOT NULL,
  `pekerjaan` enum('PELAJAR','SWASTA','PNS','PENSIUNAN') NOT NULL,
  `kewarganegaraan` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `pemohon`
--

INSERT INTO `pemohon` (`nik`, `nama`, `tempat_lahir`, `tgl_lahir`, `jekel`, `alamat`, `rt`, `rw`, `kel`, `kec`, `agama`, `goldar`, `status`, `pekerjaan`, `kewarganegaraan`) VALUES
('111', 'asdasdasd', 'asdasd', '2016-09-22', 'LAKI-LAKI', 'asdasd', '12', '12', 'adsd', 'asd', 'PROTESTAN', 'B', 'BELUM KAWIN', 'SWASTA', 'WNI'),
('1213', 'Adi Firmansyah', 'padang', '1990-01-01', 'LAKI-LAKI', 'jln sukarno hatta no 138', '001', '002', 'seberang padang', 'padang selatan', 'ISLAM', 'AB', 'BELUM KAWIN', 'SWASTA', 'WNI'),
('123456', 'Saipul', 'Padang', '1994-04-29', 'LAKI-LAKI', 'Tabing', '01', '18', 'Parupuk Tabing', 'Koto Tangah', 'ISLAM', 'B', 'BELUM KAWIN', 'PELAJAR', 'WNI'),
('1345', 'Jhon', 'asdasd', '2016-09-22', 'LAKI-LAKI', 'asdasd', '12', '12', 'asdsa', 'asdasd', 'HINDU', 'B', 'BELUM KAWIN', 'PELAJAR', 'WNI'),
('54321', 'Jhon Cena', 'Padang', '2016-09-22', 'LAKI-LAKI', 'Padang', '21', '15', 'Antahah', 'Dimase', 'PROTESTAN', 'B', 'BELUM KAWIN', 'SWASTA', 'WNI');

-- --------------------------------------------------------

--
-- Table structure for table `surveyor`
--

CREATE TABLE `surveyor` (
  `nip` varchar(15) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `tempat_lahir` varchar(50) NOT NULL,
  `tanggal_lahir` date NOT NULL,
  `jekel` enum('PRIA','WANITA') NOT NULL,
  `alamat` text NOT NULL,
  `telepon` varchar(12) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `surveyor`
--

INSERT INTO `surveyor` (`nip`, `nama`, `tempat_lahir`, `tanggal_lahir`, `jekel`, `alamat`, `telepon`) VALUES
('12345', 'Susi', 'Padang', '2016-09-22', 'WANITA', 'Padang', '081232132345'),
('22', 'asdasd', 'asdasd', '2016-09-22', 'PRIA', 'asdasd', 'asdasd'),
('1122', 'Andi', 'padang', '1990-01-25', 'PRIA', 'parak gadang permai no 19B', '085263157651');

-- --------------------------------------------------------

--
-- Table structure for table `user_akun`
--

CREATE TABLE `user_akun` (
  `nip` varchar(20) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(50) NOT NULL,
  `role` varchar(10) NOT NULL,
  `status` tinyint(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `user_akun`
--

INSERT INTO `user_akun` (`nip`, `username`, `password`, `role`, `status`) VALUES
('198503302003121002', 'admin', 'admin', 'admin', 1),
('111', 'avira', 'avira', 'admin', 1);

-- --------------------------------------------------------

--
-- Table structure for table `user_info`
--

CREATE TABLE `user_info` (
  `nip` varchar(20) NOT NULL,
  `nama` varchar(30) NOT NULL,
  `tmp_lhr` varchar(30) DEFAULT NULL,
  `tgl_lhr` date DEFAULT NULL,
  `jekel` enum('pria','wanita') DEFAULT NULL,
  `alamat` text,
  `agama` enum('islam','katolik','protestan','hindu','buddha') DEFAULT NULL,
  `telepon` varchar(13) DEFAULT NULL,
  `jabatan` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `user_info`
--

INSERT INTO `user_info` (`nip`, `nama`, `tmp_lhr`, `tgl_lhr`, `jekel`, `alamat`, `agama`, `telepon`, `jabatan`) VALUES
('111', 'Avira', 'padang', '1990-09-25', 'wanita', 'taruko indah no 11', 'islam', '085263145678', 'Admin'),
('198503302003121002', 'Adi Raka Siwi', 'Padang', '1994-04-29', 'pria', 'Komplek Filano Mandiri Tabing', 'islam', '081268280648', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `analisa`
--
ALTER TABLE `analisa`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nik` (`nik`);

--
-- Indexes for table `pemohon`
--
ALTER TABLE `pemohon`
  ADD PRIMARY KEY (`nik`);

--
-- Indexes for table `surveyor`
--
ALTER TABLE `surveyor`
  ADD PRIMARY KEY (`nip`);

--
-- Indexes for table `user_akun`
--
ALTER TABLE `user_akun`
  ADD PRIMARY KEY (`nip`);

--
-- Indexes for table `user_info`
--
ALTER TABLE `user_info`
  ADD PRIMARY KEY (`nip`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `analisa`
--
ALTER TABLE `analisa`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
