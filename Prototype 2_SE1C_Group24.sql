-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- 主機： 127.0.0.1
-- 產生時間： 2022 年 06 月 27 日 08:19
-- 伺服器版本： 10.4.22-MariaDB
-- PHP 版本： 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- 資料庫: `itp4915m_sales_system`
--
DROP DATABASE IF EXISTS `itp4915m_sales_system`;
CREATE DATABASE IF NOT EXISTS `itp4915m_sales_system` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `itp4915m_sales_system`;

-- --------------------------------------------------------

--
-- 資料表結構 `account`
--

CREATE TABLE `account` (
  `AcoountID` char(10) NOT NULL COMMENT 'YYYYMMDD00 (年+月+日+隨機數字)',
  `Username` varchar(10) NOT NULL,
  `Password` char(161) NOT NULL COMMENT 'Account password (SHA256)',
  `Enable` tinyint(1) NOT NULL DEFAULT 0 COMMENT 'Whether the account is allowed to log in\r\n0=can''t\r\n1=can'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `account`
--

INSERT INTO `account` (`AcoountID`, `Username`, `Password`, `Enable`) VALUES
('0001010101', 'root', 'abc.8565a1e13bf3e88a82b0c9880de2ddd75dcc95e06f9b888e06048a7099508fc1425672d97d8e29b787eabd8da2f359f03b23ec6e5ac1e5c2a9da1d9d797374c2', 1),
('2022062400', 'KIMBERLY', '01c5aeb2da1a079ff7c451460442eee5.b6242840c2528d5ee9387282506f08a375c4b6292c9c431de764770ea377f477a3ee7697773b0ca326b3992514d4c1425b998793d3fce6ab60013ddc46a22a78', 0),
('2022062401', 'GENEVIEVE', '97cb26fb5e220e2d43f21e55decea543.5d718188af675a7f06dfb19e0372ce6537ce4b93a097246b49c312f383f4d473ac0ef7f56099b67f6e4c9ce16aa8cb58c15778b50cfee202ea3bf23d180460da', 0),
('2022062404', 'MARTIN', '8dfb431d8cb4bb5d167082b26505dfcf.89ec039e651e533d4be38bcef911df03aac1cbcb03c34861bfd3cd2e88c877876130bf2d559deeb82f7e16ae08b8ef4e1f489516d5953dfd9ecfb95b357083ed', 0),
('2022062406', 'sales', 'abc.8565a1e13bf3e88a82b0c9880de2ddd75dcc95e06f9b888e06048a7099508fc1425672d97d8e29b787eabd8da2f359f03b23ec6e5ac1e5c2a9da1d9d797374c2', 1),
('2022062408', 'inventory', 'abc.8565a1e13bf3e88a82b0c9880de2ddd75dcc95e06f9b888e06048a7099508fc1425672d97d8e29b787eabd8da2f359f03b23ec6e5ac1e5c2a9da1d9d797374c2', 1),
('2022062410', 'SAVANNAH', 'ebf2292569ac4951841546bbb8072daa.f070d0980a21ffff5debdddd6b10a431cc6caf2c297cc5e92900058fc5f586756ac2718a36e30e203fac700aa6886adf67d15f4a5433549fdfb793f1b07d88b3', 0),
('2022062412', 'ELSIE', 'a9e156b86ba5a2698c8b4e1fce231ac2.c5b3b3b360b6c7195faeef8cbb7f7fd88bcbf1f1e9738d73ee6dbd2ceaa6e695530b0f452a212a26f0f4be97ff8fc47a3f919239d21a211c551d743a26407f18', 0),
('2022062415', 'HELEN', '323fbdaa2864a365f072d08a4e3a08e5.41b4a45944715505ec6999daa098ff46da8483136dabfad90ed8d9b91742fe6f70ae554ae0fc0a51b8f8007c9d30bf1d3c6c70bd88674089fa79041627b947e8', 0),
('2022062417', 'KYLER', '4a873579e30854f72fddd52a1bab8812.21f133989a686da1f9300d9edda9e834bf335a1789cd87c56865690bb584561d7e7c2d5209daee52e78550704cb58f70e7646220dfabc1b2e3b4aaa82af7ea95', 0),
('2022062419', 'JENSEN', '68ce087240ab426bf1990a6eb848e4d5.9c38c7f27687b86e957bc725bef9f8077a4144899a3baa140e88c09606e6c2da5fc1ed65c160a9867147d3c5a909b5854f68ceda3d6ec92fda967fa35fbb3f86', 0),
('2022062420', 'technical', 'abc.8565a1e13bf3e88a82b0c9880de2ddd75dcc95e06f9b888e06048a7099508fc1425672d97d8e29b787eabd8da2f359f03b23ec6e5ac1e5c2a9da1d9d797374c2', 1),
('2022062424', 'JESSIE', 'd6cbefe86a197d445fb223cb237ae787.792c03c870e5bb04fa3e87fc1c399767c4a1aa09bad0e2a0d284145dc0a070914aa92071985cd193d2e222765b1055db38e206a8d54e3ca8d0328cc3aaeb9b78', 0),
('2022062427', 'accounting', 'abc.8565a1e13bf3e88a82b0c9880de2ddd75dcc95e06f9b888e06048a7099508fc1425672d97d8e29b787eabd8da2f359f03b23ec6e5ac1e5c2a9da1d9d797374c2', 1),
('2022062430', 'delivery', 'abc.8565a1e13bf3e88a82b0c9880de2ddd75dcc95e06f9b888e06048a7099508fc1425672d97d8e29b787eabd8da2f359f03b23ec6e5ac1e5c2a9da1d9d797374c2', 1),
('2022062432', 'KYRIE', 'a84253bcbea5535654313ae29ad9d66c.f7f8df4e0fcc67fd7df6f9c15569882d8f1e86ca682e3bf4b278772f1b6ba7be1e5cf9bdefa927cd61b53e5726cdb46668922417371d244b7ff4d9c0cf9abe6c', 0),
('2022062433', 'WAYLON', '58028f88f3f5ec3afa74e1af964542f9.daa1ceb22ff36c04c16aa792dc77b1273b2d7e17d927698d88161a8059aafa9668119955eef854f7024ea1c8bbc3cc00ca5c8461865f6c56b34fc460c2fccc15', 0),
('2022062438', 'ALANA', 'b4eaf35a967670c773f7c01402487044.10c3ebd453f2a2d3169ca35502e51145ee54f061358d15556e633a67ef90b99cde28dd7f5cf4dbba7e2ad3d90c0aec02861196bc2f831ca36326a52cd98191cf', 0),
('2022062439', 'install', 'abc.8565a1e13bf3e88a82b0c9880de2ddd75dcc95e06f9b888e06048a7099508fc1425672d97d8e29b787eabd8da2f359f03b23ec6e5ac1e5c2a9da1d9d797374c2', 1),
('2022062440', 'MITCHELL2', '9184c085f7dd5ed63865c68dbb0ef758.b3dcf2f8221a98699a7d5f3e1dd4fad98361b408e50e978b5843afe3747fa6cceca2568ec1c9e4e76c652d6d9a46c0718d964f1a9bc816af0ddd40f17f859df1', 0),
('2022062441', 'AILEEN', 'b483c96d4ba5f7c532c147a7dda1724e.eefa0f002ffdb0085f5abc3990d9db162d3b000974170e3fc6b357a82edfedfa8ceec31240b40a89f38e237c38275aa714be80fd1385dd4eb7817393da0ef5af', 0),
('2022062450', 'BRIELLA', '3332e5f94c15a099b23f8c5f94b8d4b2.558ac5dc0a9c94c00e2c51a58531cd0fb3ed864a3068bf060bad81b142dcbdfbbf01315726437bdd80f5d2746af1ecfde4c786863a2dac14b06ff48ec60d4e24', 0),
('2022062452', 'SCARLETT', '13466bf1aae338bb6bc5d2e6c48ac75b.cb0ac6b613b6abcc31a72d398a58dc886c48822ed855a84a35c9aa325c179de341e42397d7efd2f618a1d72f0911d3e600ddf6d587d670682987a03a4621fb1c', 0),
('2022062453', 'HOLDEN', '6e83194569da392e943247a5c3382422.04c7397025591169657f13bc83f68773b1daeed4e066e13b29cd86533d90af6f8063881523c35b9a22e8440c387c9e80ca889771090f97e889b294bd35d8715d', 0),
('2022062454', 'ELAINA', 'dd68b669e10515d1d56d0fa0c13d8e39.e527cc7dd883d2c49fe2ebf814ef56283209255084aa54b8bab4a401eff65f395ca160cd9a0774ce356390fcd8c790fe3ed5f7e9c7d88ae198d5682bdf2ef3e0', 0),
('2022062455', 'BETHANY', 'e5085580ca7d2011fc4cf9fe1e88ec5e.4397313f4e29fa58ca31b67afd2527a2537256448f11a528be235ae27b68a8b1dbed6d0b139f6a66a79a5031d3fecab873823790c2160122d4e4d110e7f0e6ef', 0);

-- --------------------------------------------------------

--
-- 資料表結構 `combo`
--

CREATE TABLE `combo` (
  `ComboID` int(10) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Price` decimal(10,2) NOT NULL DEFAULT 0.00,
  `Description` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `combo`
--

INSERT INTO `combo` (`ComboID`, `Name`, `Price`, `Description`) VALUES
(1, 'CRISTAL Combo', '10000.00', 'CRISTAL electrical appliances Combo');

-- --------------------------------------------------------

--
-- 資料表結構 `combo_item`
--

CREATE TABLE `combo_item` (
  `ItemID` char(36) NOT NULL,
  `ComboID` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `combo_item`
--

INSERT INTO `combo_item` (`ItemID`, `ComboID`) VALUES
('7ad871e3-f3d7-11ec-8376-2cf05d0481f9', 1),
('e242e861-f3d7-11ec-8376-2cf05d0481f9', 1);

-- --------------------------------------------------------

--
-- 資料表結構 `customer`
--

CREATE TABLE `customer` (
  `CustomerID` char(36) NOT NULL COMMENT 'Use (UUID) function ',
  `Phone` char(9) NOT NULL,
  `Customer_name` varchar(20) NOT NULL,
  `Address` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `customer`
--

INSERT INTO `customer` (`CustomerID`, `Phone`, `Customer_name`, `Address`) VALUES
('6faa0adf-34b5-46f5-b0f3-07bf5fa3d4ce', '1111-1111', 'abc', 'abc'),
('709706cc-44b1-4cfe-9f0d-2ea2ddf546c3', '1111-1111', 'abc', 'abc'),
('791864f3-5655-4024-acc3-bafb1bdbea4e', '5555-5555', 'CAIDEN DEAN', '1 Chagrin River Road, Gates Mills,oh, 44040  United States'),
('a61c203d-0934-4336-badd-b474c2718385', '1111-1111', 'ARIANA MENDOZA', '16 Walnut Grove Road, Rochester,nh, 3868  United States'),
('f978fe82-691a-4715-b25c-c7f091c22a93', '1111-1111', 'test', 'test');

-- --------------------------------------------------------

--
-- 資料表結構 `delivery`
--

CREATE TABLE `delivery` (
  `OrderID` int(11) NOT NULL,
  `Delivery_TeamID` int(11) DEFAULT NULL,
  `CustomerID` char(36) NOT NULL,
  `Session` int(1) NOT NULL DEFAULT 0 COMMENT 'Delivery time\r\n0=9:00-12:00\r\n1=13:00-17:00\r\n2=18:00-22:00',
  `Status` int(11) NOT NULL DEFAULT 0 COMMENT '送貨狀態 0=等候送貨, 1=運送中, 2=已完成',
  `Delivery_date` date NOT NULL DEFAULT current_timestamp()
) ;

--
-- 傾印資料表的資料 `delivery`
--

INSERT INTO `delivery` (`OrderID`, `Delivery_TeamID`, `CustomerID`, `Session`, `Status`, `Delivery_date`) VALUES
(2, NULL, 'a61c203d-0934-4336-badd-b474c2718385', 0, 2, '2022-06-28'),
(4, 1, 'f978fe82-691a-4715-b25c-c7f091c22a93', 1, 2, '2022-06-29'),
(6, NULL, '709706cc-44b1-4cfe-9f0d-2ea2ddf546c3', 1, 0, '2022-06-29'),
(7, NULL, '709706cc-44b1-4cfe-9f0d-2ea2ddf546c3', 1, 0, '2022-06-30');

-- --------------------------------------------------------

--
-- 資料表結構 `delivery_team`
--

CREATE TABLE `delivery_team` (
  `TeamID` int(11) NOT NULL,
  `Status` int(1) NOT NULL DEFAULT 0 COMMENT 'Delivery team status\r\n0=Stand by\r\n1=Unable\r\n2=In delivery'
) ;

--
-- 傾印資料表的資料 `delivery_team`
--

INSERT INTO `delivery_team` (`TeamID`, `Status`) VALUES
(1, 0),
(4, 0),
(8, 0);

-- --------------------------------------------------------

--
-- 資料表結構 `delivery_team_staff`
--

CREATE TABLE `delivery_team_staff` (
  `Delivery_TeamID` int(11) NOT NULL,
  `StaffAccountID` char(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `delivery_team_staff`
--

INSERT INTO `delivery_team_staff` (`Delivery_TeamID`, `StaffAccountID`) VALUES
(1, '2022062401'),
(1, '2022062430'),
(4, '2022062440'),
(4, '2022062441');

-- --------------------------------------------------------

--
-- 資料表結構 `installation`
--

CREATE TABLE `installation` (
  `OrderID` int(11) NOT NULL,
  `CustomerID` char(36) NOT NULL,
  `Status` tinyint(4) NOT NULL COMMENT 'Installation status\r\n0=waiting to install\r\n1=It has been installed',
  `install_date` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `installation`
--

INSERT INTO `installation` (`OrderID`, `CustomerID`, `Status`, `install_date`) VALUES
(3, '791864f3-5655-4024-acc3-bafb1bdbea4e', 0, '2022-06-28 00:22:53'),
(6, '709706cc-44b1-4cfe-9f0d-2ea2ddf546c3', 0, '2022-06-30 04:21:01');

-- --------------------------------------------------------

--
-- 資料表結構 `install_staff`
--

CREATE TABLE `install_staff` (
  `OrderID` int(11) NOT NULL,
  `StaffAccountID` char(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `install_staff`
--

INSERT INTO `install_staff` (`OrderID`, `StaffAccountID`) VALUES
(3, '2022062439');

-- --------------------------------------------------------

--
-- 資料表結構 `inventory`
--

CREATE TABLE `inventory` (
  `ItemID` char(36) NOT NULL,
  `StoreWarehouseID` int(11) NOT NULL,
  `Qty` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `inventory`
--

INSERT INTO `inventory` (`ItemID`, `StoreWarehouseID`, `Qty`) VALUES
('22343e55-f3d8-11ec-8376-2cf05d0481f9', 1, 0),
('22343e55-f3d8-11ec-8376-2cf05d0481f9', 3, 10),
('7ad871e3-f3d7-11ec-8376-2cf05d0481f9', 1, 7),
('7ad871e3-f3d7-11ec-8376-2cf05d0481f9', 4, 10),
('7ad87b93-f3d7-11ec-8376-2cf05d0481f9', 1, 0),
('7ad87b93-f3d7-11ec-8376-2cf05d0481f9', 4, 10),
('e242e861-f3d7-11ec-8376-2cf05d0481f9', 1, 9),
('e242e861-f3d7-11ec-8376-2cf05d0481f9', 3, 10);

-- --------------------------------------------------------

--
-- 資料表結構 `item`
--

CREATE TABLE `item` (
  `ItemID` char(36) NOT NULL COMMENT 'use UUID function ',
  `SupplierID` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Price` decimal(10,2) NOT NULL DEFAULT 0.00,
  `Type` int(1) NOT NULL DEFAULT 0 COMMENT '0=common item\r\n1=large item\r\n2=need install item\r\n3=large item+need install item',
  `Description` varchar(1000) DEFAULT NULL
) ;

--
-- 傾印資料表的資料 `item`
--

INSERT INTO `item` (`ItemID`, `SupplierID`, `Name`, `Price`, `Type`, `Description`) VALUES
('22343e55-f3d8-11ec-8376-2cf05d0481f9', 1, 'SIEMENS SR93EX20MG dishwasher', '21800.00', 3, 'varioSpeed Plus: reduces wash times by up to 66%. Effectively remove 99.999% bacteria and germs.'),
('7ad871e3-f3d7-11ec-8376-2cf05d0481f9', 2, 'CRISTAL BS240MW 192L Refrigerator', '8800.00', 1, 'For hard floors, powerful and non-fading suction for up to 60 minutes, with 1 main suction head, 4 accessories.'),
('7ad87b93-f3d7-11ec-8376-2cf05d0481f9', 2, 'DYSON V10™ Fluffy Extra Vacuum cleaner', '3780.00', 0, 'Left/right doors are more optional. Automatic defrosting system. Adjustable freezing temperature system'),
('e242e861-f3d7-11ec-8376-2cf05d0481f9', 1, 'CRISTAL PE2926ID-2 2800W induction cooker', '4380.00', 2, 'Porcelain glass, time switch, 9-stage fire control, light touch control, child safety lock, suitable for embedded or tabletop installation');

-- --------------------------------------------------------

--
-- 資料表結構 `order`
--

CREATE TABLE `order` (
  `OrderID` int(11) NOT NULL,
  `Payment_Method` int(1) NOT NULL DEFAULT 0 COMMENT '0=cash\r\n1=e-payment\r\n2=not pay',
  `Charge` decimal(10,2) NOT NULL COMMENT 'Applicable to cash payment only',
  `finalTotal` decimal(10,2) DEFAULT NULL,
  `Status` int(1) NOT NULL COMMENT '0=Processing\r\n1=on hold\r\n2=completed\r\n3=pending delivery (保留)\r\n4=pending install (保留)\r\n5=cancel order\r\n6=cancel & refund order\r\n7=款項尚未完整交付',
  `DateTime` datetime NOT NULL
) ;

--
-- 傾印資料表的資料 `order`
--

INSERT INTO `order` (`OrderID`, `Payment_Method`, `Charge`, `finalTotal`, `Status`, `DateTime`) VALUES
(1, 2, '0.00', NULL, 1, '2022-06-25 00:19:58'),
(2, 0, '9000.00', '8800.00', 2, '2022-06-25 00:21:56'),
(3, 1, '4380.00', '4380.00', 6, '2022-06-25 00:22:59'),
(4, 1, '8800.00', '8800.00', 6, '2022-06-26 21:26:59'),
(6, 0, '13800.00', '21800.00', 7, '2022-06-27 04:22:13'),
(7, 0, '8800.00', '8800.00', 2, '2022-06-27 04:23:32'),
(8, 2, '0.00', NULL, 1, '2022-06-27 04:32:33');

-- --------------------------------------------------------

--
-- 資料表結構 `order_combo`
--

CREATE TABLE `order_combo` (
  `OrderID` int(11) NOT NULL,
  `ComboID` int(10) NOT NULL,
  `Purchase_price` decimal(10,2) NOT NULL COMMENT '儲存單件套裝價格'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- 資料表結構 `order_item`
--

CREATE TABLE `order_item` (
  `OrderID` int(11) NOT NULL,
  `ItemID` char(36) NOT NULL,
  `Qty` int(11) NOT NULL,
  `Purchase_price` decimal(10,2) NOT NULL COMMENT '儲存單件貨品價格'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `order_item`
--

INSERT INTO `order_item` (`OrderID`, `ItemID`, `Qty`, `Purchase_price`) VALUES
(1, '7ad871e3-f3d7-11ec-8376-2cf05d0481f9', 1, '8800.00'),
(2, '7ad871e3-f3d7-11ec-8376-2cf05d0481f9', 1, '8800.00'),
(3, 'e242e861-f3d7-11ec-8376-2cf05d0481f9', 1, '4380.00'),
(4, '7ad871e3-f3d7-11ec-8376-2cf05d0481f9', 1, '8800.00'),
(6, '22343e55-f3d8-11ec-8376-2cf05d0481f9', 1, '21800.00'),
(7, '7ad871e3-f3d7-11ec-8376-2cf05d0481f9', 1, '8800.00'),
(8, '7ad871e3-f3d7-11ec-8376-2cf05d0481f9', 1, '8800.00');

-- --------------------------------------------------------

--
-- 資料表結構 `purchase_order`
--

CREATE TABLE `purchase_order` (
  `PurchaseID` int(11) NOT NULL,
  `DateTime` datetime NOT NULL,
  `ItemID` char(36) NOT NULL,
  `Qty` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `purchase_order`
--

INSERT INTO `purchase_order` (`PurchaseID`, `DateTime`, `ItemID`, `Qty`) VALUES
(1, '2022-06-26 18:44:25', '7ad87b93-f3d7-11ec-8376-2cf05d0481f9', 10);

-- --------------------------------------------------------

--
-- 資料表結構 `request`
--

CREATE TABLE `request` (
  `RequestID` int(11) NOT NULL,
  `toStoreID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `request`
--

INSERT INTO `request` (`RequestID`, `toStoreID`) VALUES
(1, 1),
(2, 1),
(3, 1);

-- --------------------------------------------------------

--
-- 資料表結構 `request_item`
--

CREATE TABLE `request_item` (
  `RequestID` int(11) NOT NULL,
  `ItemID` char(36) NOT NULL,
  `fromWarehouseID` int(11) DEFAULT NULL,
  `Qty` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `request_item`
--

INSERT INTO `request_item` (`RequestID`, `ItemID`, `fromWarehouseID`, `Qty`) VALUES
(1, '22343e55-f3d8-11ec-8376-2cf05d0481f9', NULL, 10),
(1, '7ad87b93-f3d7-11ec-8376-2cf05d0481f9', NULL, 10),
(2, 'e242e861-f3d7-11ec-8376-2cf05d0481f9', NULL, 4),
(3, 'e242e861-f3d7-11ec-8376-2cf05d0481f9', NULL, 4);

-- --------------------------------------------------------

--
-- 資料表結構 `sales_staff_store`
--

CREATE TABLE `sales_staff_store` (
  `StaffAccountID` char(36) NOT NULL,
  `StoreID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `sales_staff_store`
--

INSERT INTO `sales_staff_store` (`StaffAccountID`, `StoreID`) VALUES
('2022062406', 1),
('2022062412', 1),
('2022062424', 1),
('2022062404', 2),
('2022062415', 2);

-- --------------------------------------------------------

--
-- 資料表結構 `staff`
--

CREATE TABLE `staff` (
  `AccountID` char(10) NOT NULL,
  `DepartmentID` int(10) NOT NULL,
  `FullRealName` varchar(20) NOT NULL,
  `isManager` tinyint(1) NOT NULL DEFAULT 0 COMMENT 'Whether the staff is the head of the department'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `staff`
--

INSERT INTO `staff` (`AccountID`, `DepartmentID`, `FullRealName`, `isManager`) VALUES
('0001010101', 5, 'Admin', 1),
('2022062400', 3, 'KIMBERLY LUCAS', 1),
('2022062401', 7, 'GENEVIEVE HARVEY', 0),
('2022062404', 1, 'MARTIN NORRIS', 0),
('2022062406', 1, 'Sales test', 1),
('2022062408', 2, 'Inventory test', 1),
('2022062410', 2, 'SAVANNAH KELLER', 1),
('2022062412', 1, 'ELSIE RYAN', 0),
('2022062415', 1, 'HELEN QUINN', 1),
('2022062417', 7, 'KYLER VAZQUEZ', 1),
('2022062419', 4, 'JENSEN JACOBS', 0),
('2022062420', 4, 'Technical test', 1),
('2022062424', 1, 'JESSIE BARKER', 1),
('2022062427', 3, 'Accounting test', 1),
('2022062430', 7, 'Delivery test', 1),
('2022062432', 4, 'KYRIE DECKER', 1),
('2022062433', 3, 'WAYLON TANNER', 0),
('2022062438', 8, 'ALANA NORMAN', 0),
('2022062439', 8, 'Install test', 1),
('2022062440', 7, 'MITCHELL MCCLURE', 0),
('2022062441', 7, 'AILEEN RUSSELL', 0),
('2022062450', 1, 'BRIELLA WILKINSON', 0),
('2022062452', 8, 'SCARLETT PITTS', 1),
('2022062453', 2, 'HOLDEN ANDREWS', 0),
('2022062454', 8, 'ELAINA ABBOTT', 0),
('2022062455', 8, 'BETHANY GREENE', 0);

-- --------------------------------------------------------

--
-- 資料表結構 `storewarehouse`
--

CREATE TABLE `storewarehouse` (
  `ID` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `isStore` tinyint(4) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `storewarehouse`
--

INSERT INTO `storewarehouse` (`ID`, `Name`, `isStore`) VALUES
(1, 'Aliquam metus Store', 1),
(2, 'Curabitur dictum Store', 1),
(3, 'Suspendisse non Warehouse ', 0),
(4, 'Curabitur lacinia Warehouse ', 0);

-- --------------------------------------------------------

--
-- 資料表結構 `supplier`
--

CREATE TABLE `supplier` (
  `SupplierID` int(11) NOT NULL,
  `Name` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `supplier`
--

INSERT INTO `supplier` (`SupplierID`, `Name`) VALUES
(1, 'Pellentesque aliquet'),
(2, 'Pellentesque nunc');

--
-- 已傾印資料表的索引
--

--
-- 資料表索引 `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`AcoountID`),
  ADD UNIQUE KEY `Username` (`Username`);

--
-- 資料表索引 `combo`
--
ALTER TABLE `combo`
  ADD PRIMARY KEY (`ComboID`);

--
-- 資料表索引 `combo_item`
--
ALTER TABLE `combo_item`
  ADD PRIMARY KEY (`ItemID`,`ComboID`),
  ADD KEY `have 3` (`ComboID`);

--
-- 資料表索引 `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`CustomerID`);

--
-- 資料表索引 `delivery`
--
ALTER TABLE `delivery`
  ADD PRIMARY KEY (`OrderID`),
  ADD KEY `Be responsible for 2` (`Delivery_TeamID`),
  ADD KEY `belong 4` (`CustomerID`);

--
-- 資料表索引 `delivery_team`
--
ALTER TABLE `delivery_team`
  ADD PRIMARY KEY (`TeamID`);

--
-- 資料表索引 `delivery_team_staff`
--
ALTER TABLE `delivery_team_staff`
  ADD PRIMARY KEY (`Delivery_TeamID`,`StaffAccountID`),
  ADD KEY `delivery_team_staff_ibfk_1` (`StaffAccountID`);

--
-- 資料表索引 `installation`
--
ALTER TABLE `installation`
  ADD PRIMARY KEY (`OrderID`),
  ADD KEY `belong 3` (`CustomerID`);

--
-- 資料表索引 `install_staff`
--
ALTER TABLE `install_staff`
  ADD PRIMARY KEY (`OrderID`,`StaffAccountID`),
  ADD KEY `install_staff_ibfk_1` (`StaffAccountID`);

--
-- 資料表索引 `inventory`
--
ALTER TABLE `inventory`
  ADD PRIMARY KEY (`ItemID`,`StoreWarehouseID`) USING BTREE,
  ADD KEY `FKInventory754992` (`StoreWarehouseID`);

--
-- 資料表索引 `item`
--
ALTER TABLE `item`
  ADD PRIMARY KEY (`ItemID`),
  ADD KEY `Be responsible for 5` (`SupplierID`);

--
-- 資料表索引 `order`
--
ALTER TABLE `order`
  ADD PRIMARY KEY (`OrderID`);

--
-- 資料表索引 `order_combo`
--
ALTER TABLE `order_combo`
  ADD PRIMARY KEY (`OrderID`,`ComboID`),
  ADD KEY `Buy 1` (`ComboID`);

--
-- 資料表索引 `order_item`
--
ALTER TABLE `order_item`
  ADD PRIMARY KEY (`OrderID`,`ItemID`),
  ADD KEY `Buy 2` (`ItemID`);

--
-- 資料表索引 `purchase_order`
--
ALTER TABLE `purchase_order`
  ADD PRIMARY KEY (`PurchaseID`),
  ADD KEY `ItemID` (`ItemID`);

--
-- 資料表索引 `request`
--
ALTER TABLE `request`
  ADD PRIMARY KEY (`RequestID`),
  ADD KEY `FKRequest799858` (`toStoreID`);

--
-- 資料表索引 `request_item`
--
ALTER TABLE `request_item`
  ADD PRIMARY KEY (`RequestID`,`ItemID`),
  ADD KEY `from` (`fromWarehouseID`),
  ADD KEY `Include 3` (`ItemID`);

--
-- 資料表索引 `sales_staff_store`
--
ALTER TABLE `sales_staff_store`
  ADD PRIMARY KEY (`StaffAccountID`),
  ADD KEY `FKSales_Staf892528` (`StoreID`);

--
-- 資料表索引 `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`AccountID`),
  ADD KEY `where` (`DepartmentID`);

--
-- 資料表索引 `storewarehouse`
--
ALTER TABLE `storewarehouse`
  ADD PRIMARY KEY (`ID`);

--
-- 資料表索引 `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`SupplierID`);

--
-- 在傾印的資料表使用自動遞增(AUTO_INCREMENT)
--

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `combo`
--
ALTER TABLE `combo`
  MODIFY `ComboID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `delivery_team`
--
ALTER TABLE `delivery_team`
  MODIFY `TeamID` int(11) NOT NULL AUTO_INCREMENT;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `order`
--
ALTER TABLE `order`
  MODIFY `OrderID` int(11) NOT NULL AUTO_INCREMENT;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `purchase_order`
--
ALTER TABLE `purchase_order`
  MODIFY `PurchaseID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `request`
--
ALTER TABLE `request`
  MODIFY `RequestID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `storewarehouse`
--
ALTER TABLE `storewarehouse`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `supplier`
--
ALTER TABLE `supplier`
  MODIFY `SupplierID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- 已傾印資料表的限制式
--

--
-- 資料表的限制式 `combo_item`
--
ALTER TABLE `combo_item`
  ADD CONSTRAINT `Include 1` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ItemID`) ON UPDATE CASCADE,
  ADD CONSTRAINT `have 3` FOREIGN KEY (`ComboID`) REFERENCES `combo` (`ComboID`);

--
-- 資料表的限制式 `delivery`
--
ALTER TABLE `delivery`
  ADD CONSTRAINT `Be responsible for 2` FOREIGN KEY (`Delivery_TeamID`) REFERENCES `delivery_team` (`TeamID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `belong 4` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`),
  ADD CONSTRAINT `transport` FOREIGN KEY (`OrderID`) REFERENCES `order` (`OrderID`);

--
-- 資料表的限制式 `delivery_team_staff`
--
ALTER TABLE `delivery_team_staff`
  ADD CONSTRAINT `belong` FOREIGN KEY (`Delivery_TeamID`) REFERENCES `delivery_team` (`TeamID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `delivery_team_staff_ibfk_1` FOREIGN KEY (`StaffAccountID`) REFERENCES `staff` (`AccountID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- 資料表的限制式 `installation`
--
ALTER TABLE `installation`
  ADD CONSTRAINT `Install` FOREIGN KEY (`OrderID`) REFERENCES `order` (`OrderID`),
  ADD CONSTRAINT `belong 3` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`);

--
-- 資料表的限制式 `install_staff`
--
ALTER TABLE `install_staff`
  ADD CONSTRAINT `Be responsible for 4` FOREIGN KEY (`OrderID`) REFERENCES `installation` (`OrderID`),
  ADD CONSTRAINT `install_staff_ibfk_1` FOREIGN KEY (`StaffAccountID`) REFERENCES `staff` (`AccountID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- 資料表的限制式 `inventory`
--
ALTER TABLE `inventory`
  ADD CONSTRAINT `have 6` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ItemID`) ON UPDATE CASCADE,
  ADD CONSTRAINT `store` FOREIGN KEY (`StoreWarehouseID`) REFERENCES `storewarehouse` (`ID`) ON UPDATE CASCADE;

--
-- 資料表的限制式 `item`
--
ALTER TABLE `item`
  ADD CONSTRAINT `Be responsible for 5` FOREIGN KEY (`SupplierID`) REFERENCES `supplier` (`SupplierID`);

--
-- 資料表的限制式 `order_combo`
--
ALTER TABLE `order_combo`
  ADD CONSTRAINT `Buy 1` FOREIGN KEY (`ComboID`) REFERENCES `combo` (`ComboID`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `have 1` FOREIGN KEY (`OrderID`) REFERENCES `order` (`OrderID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- 資料表的限制式 `order_item`
--
ALTER TABLE `order_item`
  ADD CONSTRAINT `Buy 2` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ItemID`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `have 2` FOREIGN KEY (`OrderID`) REFERENCES `order` (`OrderID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- 資料表的限制式 `purchase_order`
--
ALTER TABLE `purchase_order`
  ADD CONSTRAINT `purchase_order_ibfk_1` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ItemID`) ON DELETE NO ACTION;

--
-- 資料表的限制式 `request`
--
ALTER TABLE `request`
  ADD CONSTRAINT `FKRequest799858` FOREIGN KEY (`toStoreID`) REFERENCES `storewarehouse` (`ID`);

--
-- 資料表的限制式 `request_item`
--
ALTER TABLE `request_item`
  ADD CONSTRAINT `Include 3` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ItemID`),
  ADD CONSTRAINT `from` FOREIGN KEY (`fromWarehouseID`) REFERENCES `storewarehouse` (`ID`),
  ADD CONSTRAINT `hava 7` FOREIGN KEY (`RequestID`) REFERENCES `request` (`RequestID`);

--
-- 資料表的限制式 `sales_staff_store`
--
ALTER TABLE `sales_staff_store`
  ADD CONSTRAINT `FKSales_Staf884715` FOREIGN KEY (`StaffAccountID`) REFERENCES `staff` (`AccountID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FKSales_Staf892528` FOREIGN KEY (`StoreID`) REFERENCES `storewarehouse` (`ID`);

--
-- 資料表的限制式 `staff`
--
ALTER TABLE `staff`
  ADD CONSTRAINT `staff_ibfk_1` FOREIGN KEY (`AccountID`) REFERENCES `account` (`AcoountID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
