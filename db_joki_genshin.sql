-- ============================================================
--  DATABASE: db_joki_genshin
-- ============================================================
drop database if exists db_joki_genshin;
CREATE DATABASE IF NOT EXISTS db_joki_genshin;
USE db_joki_genshin;
-- ------------------------------------------------------------
-- 1. TABEL STATUS ORDER
-- ------------------------------------------------------------
CREATE TABLE IF NOT EXISTS tb_status (
    id_status INT NOT NULL,
    nama_status VARCHAR(30) NOT NULL,
    PRIMARY KEY (id_status)
);
INSERT IGNORE INTO tb_status (id_status, nama_status) VALUES
(1, 'Pending'),
(2, 'Diproses'),
(3, 'Selesai');
-- ------------------------------------------------------------
-- 2. TABEL LAYANAN (MASTER)
-- ------------------------------------------------------------
CREATE TABLE IF NOT EXISTS tb_layanan (
    id_layanan   VARCHAR(5)  NOT NULL,
    nama_layanan VARCHAR(50) NOT NULL,
    harga_dasar  INT         NOT NULL,
    kesulitan1   VARCHAR(50) NOT NULL DEFAULT '',
    kesulitan2   VARCHAR(50) NOT NULL DEFAULT '',
    kesulitan3   VARCHAR(50) NOT NULL DEFAULT '',
    PRIMARY KEY (id_layanan)
);
INSERT IGNORE INTO tb_layanan (id_layanan, nama_layanan, harga_dasar, kesulitan1, kesulitan2, kesulitan3) VALUES
('L01', 'Build Character', 40000, 'Levelling',       'Build Artefak',  'Full Build'),
('L02', 'Eksplor Map',     30000, '<20%',             '20-60%',         '60-100%'),
('L03', 'Joki Event',      25000, 'Short Event (10d)','Patch Event (30d)','Permanent Event');
-- ------------------------------------------------------------
-- 3. TABEL JOKI (TRANSAKSI)
-- ------------------------------------------------------------
CREATE TABLE IF NOT EXISTS tb_joki (
    uid          VARCHAR(15)  NOT NULL,
    username     VARCHAR(50)  NOT NULL,
    password     VARCHAR(50)  NOT NULL,
    detail       VARCHAR(100),
    id_layanan   VARCHAR(5)   NOT NULL,
    kesulitan    INT          NOT NULL,
    total_harga  INT          NOT NULL,
    id_status    INT          NOT NULL DEFAULT 1,
    PRIMARY KEY (uid),
    FOREIGN KEY (id_layanan) REFERENCES tb_layanan(id_layanan)
        ON UPDATE CASCADE ON DELETE RESTRICT,
    FOREIGN KEY (id_status)  REFERENCES tb_status(id_status)
        ON UPDATE CASCADE
);
-- ------------------------------------------------------------
-- 4. TABEL USER (LOGIN & REGISTER)
-- ------------------------------------------------------------
CREATE TABLE IF NOT EXISTS tb_user (
    id_user  INT          AUTO_INCREMENT NOT NULL,
    username VARCHAR(50)  NOT NULL UNIQUE,
    password VARCHAR(100) NOT NULL,
    role     ENUM('admin','user') NOT NULL DEFAULT 'user',
    PRIMARY KEY (id_user)
);
INSERT IGNORE INTO tb_user (username, password, role) VALUES
('admin',  'admin123', 'admin'),
('user1',  'user123',  'user');

ALTER TABLE tb_joki ADD COLUMN username_pemesan VARCHAR(50) NOT NULL;
ALTER TABLE tb_joki ADD COLUMN tgl_order TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP;
