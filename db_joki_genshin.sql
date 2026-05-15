CREATE DATABASE IF NOT EXISTS db_joki_genshin;
USE db_joki_genshin;

CREATE TABLE tb_layanan (
    id_layanan VARCHAR(5) NOT NULL,
    nama_layanan VARCHAR(50) NOT NULL,
    harga_dasar INT NOT NULL,
    PRIMARY KEY (id_layanan)
);

CREATE TABLE tb_joki (
    uid VARCHAR(15) NOT NULL,
    username VARCHAR(50) NOT NULL,
    password VARCHAR(50) NOT NULL,
    id_layanan VARCHAR(5) NOT NULL,
    kesulitan INT NOT NULL,
    total_harga INT NOT NULL,
    PRIMARY KEY (uid),
    FOREIGN KEY (id_layanan) REFERENCES tb_layanan(id_layanan) 
    ON UPDATE CASCADE ON DELETE RESTRICT
);

INSERT INTO tb_layanan (id_layanan, nama_layanan, harga_dasar) VALUES 
('L01', 'Build Character', 40000),
('L02', 'Eksplor Map', 30000),
('L03', 'Joki Event', 25000);

select * from tb_joki;
select * from tb_layanan;

ALTER TABLE tb_joki ADD COLUMN detail VARCHAR(100) AFTER password;

desc tb_layanan;