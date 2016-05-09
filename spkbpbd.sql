/*
SQLyog Ultimate v12.09 (64 bit)
MySQL - 5.6.26 : Database - dbspkbpbd
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`dbspkbpbd` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `dbspkbpbd`;

/*Table structure for table `user_akun` */

DROP TABLE IF EXISTS `user_akun`;

CREATE TABLE `user_akun` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(20) NOT NULL,
  `password` varchar(50) NOT NULL,
  `role` enum('admin','user') NOT NULL,
  `status` tinyint(1) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

/*Data for the table `user_akun` */

insert  into `user_akun`(`id`,`username`,`password`,`role`,`status`) values (1,'admin','admin','admin',1);

/*Table structure for table `user_info` */

DROP TABLE IF EXISTS `user_info`;

CREATE TABLE `user_info` (
  `id` int(11) NOT NULL,
  `nip` varchar(20) NOT NULL,
  `nama` varchar(30) NOT NULL,
  `tmp_lhr` varchar(30) DEFAULT NULL,
  `tgl_lhr` date DEFAULT NULL,
  `jekel` enum('pria','wanita') DEFAULT NULL,
  `alamat` text,
  `agama` enum('islam','katolik','protestan','hindu','buddha') DEFAULT NULL,
  `telepon` varchar(13) DEFAULT NULL,
  `jabatan` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `user_info` */

insert  into `user_info`(`id`,`nip`,`nama`,`tmp_lhr`,`tgl_lhr`,`jekel`,`alamat`,`agama`,`telepon`,`jabatan`) values (1,'198503302003121002','Adi Raka Siwi','Padang','1994-04-29','pria','Komplek Filano Mandiri Tabing','islam','081268280648','staff');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
