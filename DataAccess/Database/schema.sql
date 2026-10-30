-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 30, 2026 at 01:20 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hajk`
--
DROP DATABASE IF EXISTS `hajk`;
CREATE DATABASE `hajk` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `hajk`;

-- --------------------------------------------------------

--
-- Table structure for table `account`
--

CREATE TABLE `account` (
  `account_id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password_hash` varchar(255) NOT NULL,
  `fullname` varchar(100) NOT NULL DEFAULT '',
  `role` enum('Admin','Staff') NOT NULL,
  `account_status` enum('Active','Inactive') NOT NULL DEFAULT 'Active',
  `created_at` datetime NOT NULL DEFAULT current_timestamp(),
  `updated_at` datetime NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `account`
--

INSERT INTO `account` (`account_id`, `username`, `password_hash`, `fullname`, `role`, `account_status`, `created_at`, `updated_at`) VALUES
(1, 'admin0001', 'yRFgi7hDoN0N1aMUGubsMgc+p7v7WEDQ/Zwjdx/fd4Y=', 'Administrator', 'Admin', 'Active', '2026-10-04 16:23:25', '2026-10-25 15:36:15'),
(2, 'staff0001', 'vnitWNhKnuJxGaA6g7l0/J3n+tVCqDDTagwmhNn8WFA=', 'staff0001', 'Staff', 'Active', '2026-10-04 16:52:02', '2026-10-30 15:08:56'),
(3, 'admin3104', 'urah44qwPYSJcfcWDAsNcDrxJ5ML73EvIXqYloNyiL4=', 'Hans Norman Olaes', 'Admin', 'Active', '2026-10-25 15:37:02', '2026-10-30 15:25:34'),
(4, 'staff1003', 'AR+jXrlTRfurSn3ryAuOuZPrl8x6iOhRXLEcfl593rY=', 'Jasper Dela Cruz', 'Staff', 'Active', '2026-10-25 15:37:52', '2026-10-30 15:07:02'),
(5, 'staff0839', '3dv5hrBIFCKp1c1s+vsfNEq5CEO3pca7N4S9FDdDH3A=', 'Kirk Patrick Cortal', 'Staff', 'Inactive', '2026-10-25 15:41:11', '2026-10-30 15:12:08'),
(6, 'admin1268', 'bAtGcUhNLhZLCA1lqtAo09EtU3TXSRbgnmgIt8oqVDI=', 'Abegail Ferolino', 'Admin', 'Inactive', '2026-10-30 15:09:42', '2026-10-30 15:12:20'),
(7, 'staff1332', 'VQT7EW/zjFyStYks34v9NkcWCiy6RvZWkjibdXYdcK0=', 'John Dave Galzote', 'Staff', 'Inactive', '2026-10-30 15:10:45', '2026-10-30 15:12:14');

-- --------------------------------------------------------

--
-- Table structure for table `discount`
--

CREATE TABLE `discount` (
  `discount_id` int(11) NOT NULL,
  `created_by` int(11) NOT NULL,
  `discount_name` varchar(100) NOT NULL,
  `discount_rate` decimal(5,2) NOT NULL DEFAULT 0.00,
  `discount_type` enum('None','Statutory','Lean Season','Peak Season') NOT NULL,
  `start_date` date DEFAULT NULL,
  `end_date` date DEFAULT NULL,
  `vat_exempt` tinyint(1) NOT NULL DEFAULT 0,
  `created_at` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `discount`
--

INSERT INTO `discount` (`discount_id`, `created_by`, `discount_name`, `discount_rate`, `discount_type`, `start_date`, `end_date`, `vat_exempt`, `created_at`) VALUES
(1, 1, 'None', 0.00, 'None', NULL, NULL, 0, '2026-10-25 07:22:28'),
(2, 1, 'Statutory', 20.00, 'Statutory', NULL, NULL, 1, '2026-10-25 07:22:28'),
(3, 1, 'Lean Season', 15.00, 'Lean Season', '2024-06-01', '2024-10-31', 0, '2026-10-25 07:22:28'),
(4, 1, 'Peak Season (Nov-Dec)', 10.00, 'Peak Season', '2024-11-01', '2024-12-31', 0, '2026-10-25 07:22:28'),
(5, 1, 'Peak Season (Jan)', 10.00, 'Peak Season', '2024-01-01', '2024-01-31', 0, '2026-10-25 07:22:28'),
(6, 1, 'Peak Season (April)', 10.00, 'Peak Season', '2024-04-01', '2024-04-30', 0, '2026-10-25 07:22:28');

-- --------------------------------------------------------

--
-- Table structure for table `guest`
--

CREATE TABLE `guest` (
  `guest_id` int(11) NOT NULL,
  `surname` varchar(50) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `middlename` varchar(50) DEFAULT NULL,
  `contact` varchar(30) NOT NULL,
  `email` varchar(100) DEFAULT NULL,
  `valid_id_type` varchar(50) DEFAULT NULL,
  `valid_id_number` varchar(100) DEFAULT NULL,
  `notes` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `guest`
--

INSERT INTO `guest` (`guest_id`,`surname`,`firstname`,`middlename`,`contact`,`email`,`valid_id_type`,`valid_id_number`,`notes`) VALUES
(1,'Olaes','Hans Norman','Tahad','09602896489','hansolaes1019@gmail.com','Student ID','306151019','VIP Guest'),
(2,'Galzote','Jd','Jalbuna','09673490318','jdgalzote24@gmail.com','National ID','2345678','VIP Guest'),
(3,'Dela Cruz','Jasper','Ergina','09982746352','jasperdelacruz30@gmail.com','PWD ID','425364543',NULL),
(4,'Cortal','Kirk Patrick','Sigara','09453629485','cortalpatrick783@gmail.com','Drivers License ID','4635423',NULL),
(5,'Ferolino','Abegail','Timogtimog','09382940577','AbeFerolino9910@gmail.com','Philippine Passport ID','78269867','VIP Guest'),
(6,'Santos','Maria Clara','Reyes','09171234567','mariaclara.santos@gmail.com','National ID','1234-5678-9012-3456',NULL),
(7,'Reyes','Juan Miguel','Dela Torre','09285550142','juanmiguel.reyes@yahoo.com','Driver''s License','N03-21-004512','VIP Guest'),
(8,'Garcia','Angelica','Mendoza','09054418820','angelica.garcia@gmail.com','Passport','P1234567A',NULL),
(9,'Bautista','Ricardo','Villanueva','09178899001',NULL,'Senior Citizen ID','SC-2019-004871','Prefers 4th floor'),
(10,'Lopez','Katrina','Domingo','09366012233','katrina.lopez@outlook.com','Student ID','2021-00457',NULL),
(11,'Mercado','Eduardo','Santiago','09219087765','eduardo.mercado@gmail.com','Voter''s ID','7421-0098-5532',NULL),
(12,'Aquino','Patricia','Navarro','09993345510','patricia.aquino@gmail.com','PWD ID','PWD-0412-77781','Wheelchair accessible room needed'),
(13,'Cruz','Marco','Padilla','09456671199','marco.cruz@gmail.com','Driver''s License','D01-18-776203',NULL),
(14,'Ramos','Lorna','Castillo','09128834402',NULL,'Senior Citizen ID','SC-2017-120934','VIP Guest'),
(15,'Torres','Christian','Bernardo','09271550936','christian.torres@yahoo.com','National ID','5567-1234-8890-1122',NULL),
(16,'Flores','Sofia','Alcantara','09187762251','sofia.flores@gmail.com','Passport','P7654321B','Allergic to feather pillows'),
(17,'Navarro','Benjamin','Soriano','09064400378','ben.navarro@gmail.com','Other','BRGY-CLR-2026-0192',NULL),
(18,'Gonzales','Jasmine','Pascual','09353321870','jasmine.gonzales@gmail.com','Student ID','2022-01983',NULL),
(19,'Villanueva','Rolando','Magsaysay','09172208843',NULL,'Voter''s ID','3310-4471-0825','Frequent guest'),
(20,'Castro','Elena','Fernandez','09228819075','elena.castro@outlook.com','Driver''s License','N05-19-330847',NULL),
(21,'Salazar','Dennis','Ocampo','09391457702','dennis.salazar@gmail.com','National ID','9087-5521-3340-7766',NULL),
(22,'Dizon','Mary Grace','Lim','09175503391','marygrace.dizon@gmail.com','Passport','P2468135C','VIP Guest'),
(23,'Pineda','Oscar','Tolentino','09086617250',NULL,'PWD ID','PWD-0788-12045',NULL),
(24,'Evangelista','Bianca','Roque','09260932814','bianca.evangelista@yahoo.com','Student ID','2020-03312',NULL),
(25,'Mangubat','Ferdinand','Abad','09197745526','ferdinand.mangubat@gmail.com','Driver''s License','N02-20-558193','Late check-in usually');

-- --------------------------------------------------------

--
-- Table structure for table `payment`
--

CREATE TABLE `payment` (
  `payment_id` int(11) NOT NULL,
  `res_id` int(11) NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  `payment_method` enum('Cash','GCash','Maya','PayPal','Card','Bank Transfer') NOT NULL,
  `reference_no` varchar(100) DEFAULT NULL,
  `payment_date` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `payment`
--

INSERT INTO `payment` (`payment_id`, `res_id`, `amount`, `payment_method`, `reference_no`, `payment_date`) VALUES
(1, 1, 4760.00, 'Cash', NULL, '2026-08-03 14:30:00'),
(2, 2, 10852.80, 'GCash', 'GC8841207733', '2026-08-14 14:30:00'),
(3, 3, 13200.00, 'Card', 'AUTH-558210', '2026-08-22 14:30:00'),
(4, 4, 7996.80, 'Bank Transfer', 'BT-20260905-114', '2026-09-03 14:30:00'),
(5, 4, 18659.20, 'Bank Transfer', 'BT-20260905-114', '2026-09-05 14:30:00'),
(6, 5, 10304.00, 'Maya', 'MY-77120934', '2026-09-18 14:30:00'),
(7, 6, 4760.00, 'Cash', NULL, '2026-10-02 14:30:00'),
(8, 7, 4712.40, 'PayPal', 'PP-9X2K41L', '2026-10-08 14:30:00'),
(9, 7, 10995.60, 'PayPal', 'PP-9X2K41L', '2026-10-10 14:30:00'),
(10, 8, 8512.00, 'GCash', 'GC9920114820', '2026-10-29 14:30:00'),
(11, 9, 10472.00, 'Cash', NULL, '2026-10-28 14:30:00'),
(12, 10, 12480.00, 'Card', 'AUTH-663901', '2026-10-30 14:30:00'),
(13, 11, 1000.00, 'GCash', 'GC1100552901', '2026-11-03 14:30:00'),
(14, 13, 2000.00, 'Bank Transfer', 'BT-20261120-221', '2026-11-18 14:30:00'),
(15, 14, 3000.00, 'Maya', 'MY-88201175', '2026-12-18 14:30:00'),
(16, 26, 5000.00, 'Card', 'AUTH-771245', '2026-12-31 14:30:00'),
(17, 28, 500.00, 'Cash', NULL, '2026-11-13 14:30:00');

-- --------------------------------------------------------

--
-- Table structure for table `reservation`
--

CREATE TABLE `reservation` (
  `res_id` int(11) NOT NULL,
  `guest_id` int(11) NOT NULL,
  `room_id` int(11) NOT NULL,
  `discount_id` int(11) DEFAULT NULL,
  `created_by` int(11) NOT NULL,
  `res_code` varchar(20) NOT NULL,
  `res_status` enum('Pending','Check-In','Check-Out','No-Show','Canceled') NOT NULL DEFAULT 'Pending',
  `check_in` date NOT NULL,
  `check_out` date NOT NULL,
  `num_nights` int(11) NOT NULL,
  `adults` int(11) NOT NULL,
  `children` int(11) NOT NULL DEFAULT 0,
  `base_rate` decimal(10,2) NOT NULL,
  `extra_adult_fee` decimal(10,2) NOT NULL DEFAULT 800.00,
  `extra_person` decimal(10,2) NOT NULL DEFAULT 0.00,
  `subtotal` decimal(10,2) NOT NULL DEFAULT 0.00,
  `discount_amount` decimal(10,2) NOT NULL DEFAULT 0.00,
  `net_amount` decimal(10,2) NOT NULL DEFAULT 0.00,
  `vat_amount` decimal(10,2) NOT NULL DEFAULT 0.00,
  `total_amount` decimal(10,2) NOT NULL DEFAULT 0.00,
  `created_at` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `reservation`
--

INSERT INTO `reservation` (`res_id`, `guest_id`, `room_id`, `discount_id`, `created_by`, `res_code`, `res_status`, `check_in`, `check_out`, `num_nights`, `adults`, `children`, `base_rate`, `extra_adult_fee`, `extra_person`, `subtotal`, `discount_amount`, `net_amount`, `vat_amount`, `total_amount`, `created_at`) VALUES
(1, 1, 1, 3, 2, '20260731-0001', 'Check-Out', '2026-08-03', '2026-08-05', 2, 2, 0, 2500.00, 800.00, 0.00, 5000.00, 750.00, 4250.00, 510.00, 4760.00, '2026-07-31 10:00:00'),
(2, 2, 5, 3, 2, '20260811-0001', 'Check-Out', '2026-08-14', '2026-08-17', 3, 2, 1, 3800.00, 800.00, 0.00, 11400.00, 1710.00, 9690.00, 1162.80, 10852.80, '2026-08-11 10:00:00'),
(3, 3, 9, 2, 1, '20260819-0001', 'Check-Out', '2026-08-22', '2026-08-25', 3, 2, 0, 5500.00, 800.00, 0.00, 16500.00, 3300.00, 13200.00, 0.00, 13200.00, '2026-08-19 10:00:00'),
(4, 4, 11, 3, 2, '20260902-0001', 'Check-Out', '2026-09-05', '2026-09-09', 4, 4, 2, 7000.00, 800.00, 0.00, 28000.00, 4200.00, 23800.00, 2856.00, 26656.00, '2026-09-02 10:00:00'),
(5, 5, 6, NULL, 2, '20260915-0001', 'Check-Out', '2026-09-18', '2026-09-20', 2, 3, 0, 3800.00, 800.00, 1600.00, 9200.00, 0.00, 9200.00, 1104.00, 10304.00, '2026-09-15 10:00:00'),
(6, 1, 3, 3, 1, '20260929-0001', 'Check-Out', '2026-10-02', '2026-10-04', 2, 2, 0, 2500.00, 800.00, 0.00, 5000.00, 750.00, 4250.00, 510.00, 4760.00, '2026-09-29 10:00:00'),
(7, 2, 10, 3, 2, '20261007-0001', 'Check-Out', '2026-10-10', '2026-10-13', 3, 2, 2, 5500.00, 800.00, 0.00, 16500.00, 2475.00, 14025.00, 1683.00, 15708.00, '2026-10-07 10:00:00'),
(8, 4, 7, NULL, 2, '20261026-0001', 'Check-In', '2026-10-29', '2026-11-02', 4, 2, 0, 3800.00, 800.00, 0.00, 15200.00, 0.00, 15200.00, 1824.00, 17024.00, '2026-10-26 10:00:00'),
(9, 5, 9, 3, 2, '20261025-0001', 'Check-In', '2026-10-28', '2026-11-01', 4, 2, 1, 5500.00, 800.00, 0.00, 22000.00, 3300.00, 18700.00, 2244.00, 20944.00, '2026-10-25 10:00:00'),
(10, 3, 12, 2, 1, '20261027-0001', 'Check-In', '2026-10-30', '2026-11-03', 4, 5, 1, 7000.00, 800.00, 3200.00, 31200.00, 6240.00, 24960.00, 0.00, 24960.00, '2026-10-27 10:00:00'),
(11, 2, 2, 4, 2, '20261102-0001', 'Pending', '2026-11-05', '2026-11-08', 3, 2, 0, 2500.00, 800.00, 0.00, 7500.00, 750.00, 6750.00, 810.00, 7560.00, '2026-11-02 10:00:00'),
(12, 1, 4, 4, 1, '20261109-0001', 'Pending', '2026-11-12', '2026-11-14', 2, 3, 0, 2500.00, 800.00, 1600.00, 6600.00, 660.00, 5940.00, 712.80, 6652.80, '2026-11-09 10:00:00'),
(13, 4, 8, 4, 2, '20261117-0001', 'Pending', '2026-11-20', '2026-11-24', 4, 2, 2, 3800.00, 800.00, 0.00, 15200.00, 1520.00, 13680.00, 1641.60, 15321.60, '2026-11-17 10:00:00'),
(14, 5, 10, 4, 1, '20261217-0001', 'Pending', '2026-12-20', '2026-12-27', 7, 2, 0, 5500.00, 800.00, 0.00, 38500.00, 3850.00, 34650.00, 4158.00, 38808.00, '2026-12-17 10:00:00'),
(15, 3, 1, 2, 2, '20261221-0001', 'Pending', '2026-12-24', '2026-12-26', 2, 1, 0, 2500.00, 800.00, 0.00, 5000.00, 1000.00, 4000.00, 0.00, 4000.00, '2026-12-21 10:00:00'),
(26, 2, 11, 5, 1, '20261230-0001', 'Pending', '2027-01-02', '2027-01-05', 3, 6, 0, 7000.00, 800.00, 4800.00, 25800.00, 2580.00, 23220.00, 2786.40, 26006.40, '2026-12-30 10:00:00'),
(27, 1, 5, NULL, 2, '20261029-0001', 'Canceled', '2026-11-01', '2026-11-03', 2, 2, 0, 3800.00, 800.00, 0.00, 7600.00, 0.00, 7600.00, 912.00, 8512.00, '2026-10-29 10:00:00'),
(28, 4, 3, 4, 1, '20261112-0001', 'Canceled', '2026-11-15', '2026-11-17', 2, 2, 1, 2500.00, 800.00, 0.00, 5000.00, 500.00, 4500.00, 540.00, 5040.00, '2026-11-12 10:00:00'),
(29, 5, 6, NULL, 2, '20261024-0001', 'No-Show', '2026-10-27', '2026-10-29', 2, 2, 0, 3800.00, 800.00, 0.00, 7600.00, 0.00, 7600.00, 912.00, 8512.00, '2026-10-24 10:00:00'),
(30, 3, 2, 3, 1, '20261017-0001', 'No-Show', '2026-10-20', '2026-10-22', 2, 2, 0, 2500.00, 800.00, 0.00, 5000.00, 750.00, 4250.00, 510.00, 4760.00, '2026-10-17 10:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `room`
--

CREATE TABLE `room` (
  `room_id` int(11) NOT NULL,
  `room_type_id` int(11) NOT NULL,
  `room_number` varchar(20) NOT NULL,
  `floor` int(11) NOT NULL,
  `room_status` enum('Available','Occupied','Out of Order','Under Maintenance') NOT NULL DEFAULT 'Available',
  `created_at` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `room`
--

INSERT INTO `room` (`room_id`, `room_type_id`, `room_number`, `floor`, `room_status`, `created_at`) VALUES
(1, 1, '101', 1, 'Available', '2026-10-04 16:25:53'),
(2, 1, '102', 1, 'Available', '2026-10-04 16:25:53'),
(3, 1, '103', 1, 'Available', '2026-10-04 16:25:53'),
(4, 1, '104', 1, 'Available', '2026-10-04 16:25:53'),
(5, 2, '201', 2, 'Under Maintenance', '2026-10-04 16:25:53'),
(6, 2, '202', 2, 'Available', '2026-10-04 16:25:53'),
(7, 2, '203', 2, 'Occupied', '2026-10-04 16:25:53'),
(8, 2, '204', 2, 'Available', '2026-10-04 16:25:53'),
(9, 3, '301', 3, 'Occupied', '2026-10-04 16:25:53'),
(10, 3, '302', 3, 'Available', '2026-10-04 16:25:53'),
(11, 4, '401', 4, 'Available', '2026-10-04 16:25:53'),
(12, 4, '402', 4, 'Occupied', '2026-10-04 16:25:53'),
(13, 4, '403', 4, 'Out of Order', '2026-10-30 15:18:59'),
(14, 4, '404', 4, 'Out of Order', '2026-10-30 15:19:40'),
(15, 3, '303', 3, 'Under Maintenance', '2026-10-30 15:20:06'),
(16, 3, '304', 3, 'Under Maintenance', '2026-10-30 15:20:37'),
(17, 1, '105', 1, 'Available', '2026-10-30 19:47:19'),
(18, 1, '106', 1, 'Available', '2026-10-30 19:47:31'),
(19, 1, '107', 1, 'Under Maintenance', '2026-10-30 19:47:56'),
(20, 1, '108', 1, 'Available', '2026-10-30 19:48:08'),
(21, 1, '109', 1, 'Available', '2026-10-30 19:48:18'),
(22, 1, '110', 1, 'Available', '2026-10-30 19:48:33'),
(23, 2, '205', 2, 'Under Maintenance', '2026-10-30 19:49:25'),
(24, 2, '206', 2, 'Available', '2026-10-30 19:49:45'),
(25, 2, '207', 2, 'Available', '2026-10-30 19:50:23'),
(26, 2, '208', 2, 'Available', '2026-10-30 19:50:48'),
(27, 2, '209', 2, 'Available', '2026-10-30 19:51:10'),
(28, 2, '210', 2, 'Available', '2026-10-30 19:51:24'),
(29, 3, '305', 3, 'Available', '2026-10-30 19:52:01'),
(30, 3, '306', 3, 'Available', '2026-10-30 19:52:15'),
(31, 3, '307', 3, 'Available', '2026-10-30 19:52:37'),
(32, 3, '308', 3, 'Available', '2026-10-30 19:53:00'),
(33, 3, '309', 3, 'Available', '2026-10-30 19:53:35'),
(34, 3, '310', 3, 'Available', '2026-10-30 19:53:47'),
(35, 4, '405', 4, 'Available', '2026-10-30 19:54:11'),
(36, 4, '406', 4, 'Available', '2026-10-30 19:54:35'),
(37, 4, '407', 4, 'Available', '2026-10-30 19:54:52'),
(38, 4, '408', 4, 'Available', '2026-10-30 19:55:14'),
(39, 4, '409', 4, 'Available', '2026-10-30 19:55:28'),
(40, 4, '410', 4, 'Available', '2026-10-30 19:55:40');

-- --------------------------------------------------------

--
-- Table structure for table `room_type`
--

CREATE TABLE `room_type` (
  `room_type_id` int(11) NOT NULL,
  `type_name` varchar(100) NOT NULL,
  `room_size` decimal(6,2) NOT NULL,
  `standard_capacity` int(11) NOT NULL,
  `max_capacity` int(11) NOT NULL,
  `base_rate` decimal(10,2) NOT NULL,
  `extra_adult_fee` decimal(10,2) NOT NULL DEFAULT 800.00,
  `amenities` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `room_type`
--

INSERT INTO `room_type` (`room_type_id`, `type_name`, `room_size`, `standard_capacity`, `max_capacity`, `base_rate`, `extra_adult_fee`, `amenities`) VALUES
(1, 'Standard Room', 22.00, 2, 3, 2500.00, 800.00, 'Wi-Fi, TV, Air Conditioning'),
(2, 'Deluxe Room', 32.00, 2, 4, 3800.00, 800.00, 'Wi-Fi, TV, Air Conditioning, Mini Refrigerator'),
(3, 'Executive Suite', 48.00, 2, 4, 5500.00, 800.00, 'Wi-Fi, TV, Air Conditioning, Living Area, Mini Refrigerator'),
(4, 'Family Suite', 55.00, 4, 6, 7000.00, 800.00, 'Wi-Fi, TV, Air Conditioning, Living Area, Dining Area, Kitchenette');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`account_id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indexes for table `discount`
--
ALTER TABLE `discount`
  ADD PRIMARY KEY (`discount_id`),
  ADD UNIQUE KEY `discount_name` (`discount_name`),
  ADD KEY `fk_discount_account` (`created_by`);

--
-- Indexes for table `guest`
--
ALTER TABLE `guest`
  ADD PRIMARY KEY (`guest_id`);

--
-- Indexes for table `payment`
--
ALTER TABLE `payment`
  ADD PRIMARY KEY (`payment_id`),
  ADD KEY `fk_payment_reservation` (`res_id`);

--
-- Indexes for table `reservation`
--
ALTER TABLE `reservation`
  ADD PRIMARY KEY (`res_id`),
  ADD UNIQUE KEY `res_code` (`res_code`),
  ADD KEY `fk_reservation_guest` (`guest_id`),
  ADD KEY `fk_reservation_room` (`room_id`),
  ADD KEY `fk_reservation_discount` (`discount_id`),
  ADD KEY `fk_reservation_account` (`created_by`),
  ADD KEY `idx_reservation_room_dates` (`room_id`,`res_status`,`check_in`,`check_out`);

--
-- Indexes for table `room`
--
ALTER TABLE `room`
  ADD PRIMARY KEY (`room_id`),
  ADD UNIQUE KEY `room_number` (`room_number`),
  ADD KEY `fk_room_type` (`room_type_id`);

--
-- Indexes for table `room_type`
--
ALTER TABLE `room_type`
  ADD PRIMARY KEY (`room_type_id`),
  ADD UNIQUE KEY `type_name` (`type_name`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `account`
--
ALTER TABLE `account`
  MODIFY `account_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `discount`
--
ALTER TABLE `discount`
  MODIFY `discount_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `guest`
--
ALTER TABLE `guest`
  MODIFY `guest_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT for table `payment`
--
ALTER TABLE `payment`
  MODIFY `payment_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `reservation`
--
ALTER TABLE `reservation`
  MODIFY `res_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT for table `room`
--
ALTER TABLE `room`
  MODIFY `room_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;

--
-- AUTO_INCREMENT for table `room_type`
--
ALTER TABLE `room_type`
  MODIFY `room_type_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `discount`
--
ALTER TABLE `discount`
  ADD CONSTRAINT `fk_discount_account` FOREIGN KEY (`created_by`) REFERENCES `account` (`account_id`) ON UPDATE CASCADE;

--
-- Constraints for table `payment`
--
ALTER TABLE `payment`
  ADD CONSTRAINT `fk_payment_reservation` FOREIGN KEY (`res_id`) REFERENCES `reservation` (`res_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `chk_payment_amount` CHECK (`amount` > 0);

--
-- Constraints for table `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `fk_reservation_account` FOREIGN KEY (`created_by`) REFERENCES `account` (`account_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_reservation_discount` FOREIGN KEY (`discount_id`) REFERENCES `discount` (`discount_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_reservation_guest` FOREIGN KEY (`guest_id`) REFERENCES `guest` (`guest_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_reservation_room` FOREIGN KEY (`room_id`) REFERENCES `room` (`room_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `chk_reservation_dates` CHECK (`check_out` > `check_in`),
  ADD CONSTRAINT `chk_reservation_adults` CHECK (`adults` >= 1);

--
-- Constraints for table `room`
--
ALTER TABLE `room`
  ADD CONSTRAINT `fk_room_type` FOREIGN KEY (`room_type_id`) REFERENCES `room_type` (`room_type_id`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
