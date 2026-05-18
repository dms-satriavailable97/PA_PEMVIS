CREATE DATABASE `db_joki_genshin`;
USE `db_joki_genshin`;

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";

CREATE TABLE `tb_status` (
  `id_status` int(11) NOT NULL,
  `nama_status` varchar(30) NOT NULL,
  PRIMARY KEY (`id_status`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `tb_status` (`id_status`, `nama_status`) VALUES
(1, 'Pending'),
(2, 'Diproses'),
(3, 'Selesai');

CREATE TABLE `tb_layanan` (
  `id_layanan` varchar(5) NOT NULL,
  `nama_layanan` varchar(50) NOT NULL,
  `harga_dasar` int(11) NOT NULL,
  `kesulitan1` varchar(50) NOT NULL DEFAULT '',
  `kesulitan2` varchar(50) NOT NULL DEFAULT '',
  `kesulitan3` varchar(50) NOT NULL DEFAULT '',
  PRIMARY KEY (`id_layanan`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `tb_layanan` (`id_layanan`, `nama_layanan`, `harga_dasar`, `kesulitan1`, `kesulitan2`, `kesulitan3`) VALUES
('L01', 'Build Character', 40000, 'Levelling', 'Build Artefak', 'Full Build'),
('L02', 'Eksplor Map', 30000, '<20%', '20-60%', '60-100%'),
('L03', 'Joki Event', 25000, 'Short Event (10d)', 'Patch Event (30d)', 'Permanent Event');

CREATE TABLE `tb_metode` (
  `id_metode` varchar(5) NOT NULL,
  `nama_metode` varchar(50) NOT NULL,
  PRIMARY KEY (`id_metode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `tb_metode` (`id_metode`, `nama_metode`) VALUES
('M01', 'Transfer Bank '),
('M02', 'QRIS / ShopeePay'),
('M03', 'E-Wallet (Dana/OVO/GoPay)'),
('M04', 'Cash / Tunai');

CREATE TABLE `tb_user` (
  `id_user` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password` varchar(100) NOT NULL,
  `role` enum('admin','user') NOT NULL DEFAULT 'user',
  PRIMARY KEY (`id_user`),
  UNIQUE KEY `username` (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `tb_user` (`id_user`, `username`, `password`, `role`) VALUES
(1, 'admin', 'admin123', 'admin'),
(2, 'user1', 'user123', 'user');

CREATE TABLE `tb_joki` (
  `uid` varchar(15) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `detail` varchar(100) DEFAULT NULL,
  `id_layanan` varchar(5) NOT NULL,
  `kesulitan` int(11) NOT NULL,
  `total_harga` int(11) NOT NULL,
  `id_status` int(11) NOT NULL DEFAULT 1,
  `username_pemesan` varchar(50) NOT NULL,
  `tgl_order` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `id_transaksi` varchar(20) NOT NULL,
  `id_metode` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`uid`),
  KEY `id_layanan` (`id_layanan`),
  KEY `id_status` (`id_status`),
  KEY `fk_metode_joki` (`id_metode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;


ALTER TABLE `tb_joki`
  ADD CONSTRAINT `fk_metode_joki` FOREIGN KEY (`id_metode`) REFERENCES `tb_metode` (`id_metode`) ON UPDATE CASCADE,
  ADD CONSTRAINT `tb_joki_ibfk_1` FOREIGN KEY (`id_layanan`) REFERENCES `tb_layanan` (`id_layanan`) ON UPDATE CASCADE ON DELETE RESTRICT,
  ADD CONSTRAINT `tb_joki_ibfk_2` FOREIGN KEY (`id_status`) REFERENCES `tb_status` (`id_status`) ON UPDATE CASCADE;

COMMIT;