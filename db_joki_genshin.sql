-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 21 Bulan Mei 2026 pada 18.49
-- Versi server: 10.4.32-MariaDB
-- Versi PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_joki_genshin`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_joki`
--

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
  `id_metode` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tb_joki`
--

INSERT INTO `tb_joki` (`uid`, `username`, `password`, `detail`, `id_layanan`, `kesulitan`, `total_harga`, `id_status`, `username_pemesan`, `tgl_order`, `id_transaksi`, `id_metode`) VALUES
('23131', '21313', '213', '231', 'L02', 1, 30000, 3, 'user1', '2026-05-21 14:11:33', 'TRX-20260521-001', 'M01');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_layanan`
--

CREATE TABLE `tb_layanan` (
  `id_layanan` varchar(5) NOT NULL,
  `nama_layanan` varchar(50) NOT NULL,
  `harga_dasar` int(11) NOT NULL,
  `kesulitan1` varchar(50) NOT NULL DEFAULT '',
  `kesulitan2` varchar(50) NOT NULL DEFAULT '',
  `kesulitan3` varchar(50) NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tb_layanan`
--

INSERT INTO `tb_layanan` (`id_layanan`, `nama_layanan`, `harga_dasar`, `kesulitan1`, `kesulitan2`, `kesulitan3`) VALUES
('L01', 'Build Character', 40000, 'Levelling', 'Build Artefak', 'Full Build'),
('L02', 'Eksplor Map', 30000, '<20%', '20-60%', '60-100%'),
('L03', 'Joki Event', 25000, 'Short Event (10d)', 'Patch Event (30d)', 'Permanent Event');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_metode`
--

CREATE TABLE `tb_metode` (
  `id_metode` varchar(5) NOT NULL,
  `nama_metode` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tb_metode`
--

INSERT INTO `tb_metode` (`id_metode`, `nama_metode`) VALUES
('M01', 'Transfer VA'),
('M02', 'QRIS / ShopeePay'),
('M03', 'E-Wallet (Dana/OVO/GoPay)');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_status`
--

CREATE TABLE `tb_status` (
  `id_status` int(11) NOT NULL,
  `nama_status` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tb_status`
--

INSERT INTO `tb_status` (`id_status`, `nama_status`) VALUES
(1, 'Pending'),
(2, 'Diproses'),
(3, 'Selesai');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_user`
--

CREATE TABLE `tb_user` (
  `id_user` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(100) NOT NULL,
  `role` enum('admin','user') NOT NULL DEFAULT 'user'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tb_user`
--

INSERT INTO `tb_user` (`id_user`, `username`, `password`, `role`) VALUES
(1, 'admin', 'admin123', 'admin'),
(2, 'user1', 'user123', 'user');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tb_joki`
--
ALTER TABLE `tb_joki`
  ADD PRIMARY KEY (`uid`),
  ADD KEY `id_layanan` (`id_layanan`),
  ADD KEY `id_status` (`id_status`),
  ADD KEY `fk_metode_joki` (`id_metode`);

--
-- Indeks untuk tabel `tb_layanan`
--
ALTER TABLE `tb_layanan`
  ADD PRIMARY KEY (`id_layanan`);

--
-- Indeks untuk tabel `tb_metode`
--
ALTER TABLE `tb_metode`
  ADD PRIMARY KEY (`id_metode`);

--
-- Indeks untuk tabel `tb_status`
--
ALTER TABLE `tb_status`
  ADD PRIMARY KEY (`id_status`);

--
-- Indeks untuk tabel `tb_user`
--
ALTER TABLE `tb_user`
  ADD PRIMARY KEY (`id_user`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `tb_user`
--
ALTER TABLE `tb_user`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `tb_joki`
--
ALTER TABLE `tb_joki`
  ADD CONSTRAINT `fk_metode_joki` FOREIGN KEY (`id_metode`) REFERENCES `tb_metode` (`id_metode`) ON UPDATE CASCADE,
  ADD CONSTRAINT `tb_joki_ibfk_1` FOREIGN KEY (`id_layanan`) REFERENCES `tb_layanan` (`id_layanan`) ON UPDATE CASCADE,
  ADD CONSTRAINT `tb_joki_ibfk_2` FOREIGN KEY (`id_status`) REFERENCES `tb_status` (`id_status`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
