-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- ホスト: 127.0.0.1
-- 生成日時: 2024-12-18 06:41:46
-- サーバのバージョン： 10.4.32-MariaDB
-- PHP のバージョン: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- データベース: `tfukunag`
--

-- --------------------------------------------------------

--
-- テーブルの構造 `test_db`
--

CREATE TABLE `test_db` (
  `id` int(8) NOT NULL,
  `name` varchar(30) NOT NULL,
  `gender` varchar(30) NOT NULL,
  `point` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- テーブルのデータのダンプ `test_db`
--

INSERT INTO `test_db` (`id`, `name`, `gender`, `point`) VALUES
(1001, '秋山', '男', 80),
(1002, '久保田', '女', 100),
(1003, '佐々木', '女', 65),
(1004, '佐藤', '男', 75),
(1005, '鈴木', '女', 60),
(1006, '田中', '男', 90),
(1007, '土屋', '女', 55);

--
-- ダンプしたテーブルのインデックス
--

--
-- テーブルのインデックス `test_db`
--
ALTER TABLE `test_db`
  ADD PRIMARY KEY (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
