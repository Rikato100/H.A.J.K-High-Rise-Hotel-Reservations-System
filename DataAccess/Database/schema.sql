SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";

CREATE DATABASE IF NOT EXISTS `hajk`;
USE `hajk`;

-- --------------------------------------------------------

--
-- Table structure for table `account`
--

CREATE TABLE `account` (
  `account_id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password_hash` varchar(255) NOT NULL,
  `fullname` varchar(100) NOT NULL DEFAULT '',
  `role` enum('Admin','Staff') NOT NULL,
  `account_status` enum('Active','Inactive') NOT NULL DEFAULT 'Active',
  `created_at` datetime NOT NULL DEFAULT current_timestamp(),
  `updated_at` datetime NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`account_id`),
  UNIQUE KEY `username` (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `account` (`account_id`, `username`, `password_hash`, `fullname`, `role`, `account_status`, `created_at`, `updated_at`) VALUES
(1, 'admin', 'yRFgi7hDoN0N1aMUGubsMgc+p7v7WEDQ/Zwjdx/fd4Y=', 'Administrator', 'Admin', 'Active', '2026-10-04 16:23:25', '2026-10-04 16:23:25'),
(2, 'staff', 'vnitWNhKnuJxGaA6g7l0/J3n+tVCqDDTagwmhNn8WFA=', 'Staff Member', 'Staff', 'Active', '2026-10-04 16:52:02', '2026-10-04 16:52:02');

-- --------------------------------------------------------

--
-- Table structure for table `discount`
--

CREATE TABLE `discount` (
  `discount_id` int(11) NOT NULL AUTO_INCREMENT,
  `created_by` int(11) NOT NULL,
  `discount_name` varchar(100) NOT NULL,
  `discount_rate` decimal(5,2) NOT NULL DEFAULT 0.00,
  `discount_type` enum('None','Statutory','Lean Season','Peak Season') NOT NULL,
  `start_date` date DEFAULT NULL,
  `end_date` date DEFAULT NULL,
  `vat_exempt` tinyint(1) NOT NULL DEFAULT 0,
  `created_at` datetime NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`discount_id`),
  UNIQUE KEY `discount_name` (`discount_name`),
  KEY `fk_discount_account` (`created_by`),
  CONSTRAINT `fk_discount_account` FOREIGN KEY (`created_by`) REFERENCES `account` (`account_id`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `discount` (`discount_id`, `created_by`, `discount_name`, `discount_rate`, `discount_type`, `start_date`, `end_date`, `vat_exempt`, `created_at`) VALUES
(1, 1, 'None', 0.00, 'None', NULL, NULL, 0, '2026-10-04 16:26:45'),
(2, 1, 'Statutory', 20.00, 'Statutory', NULL, NULL, 1, '2026-10-04 16:26:45'),
(3, 1, 'Lean Season', 15.00, 'Lean Season', '2024-06-01', '2024-10-31', 0, '2026-10-04 16:26:45'),
(4, 1, 'Peak Season', 10.00, 'Peak Season', '2024-11-01', '2025-01-31', 0, '2026-10-04 16:26:45'),
(5, 1, 'Peak Season (April)', 10.00, 'Peak Season', '2024-04-01', '2024-04-30', 0, '2026-10-04 16:26:45');

-- --------------------------------------------------------

--
-- Table structure for table `guest`
--

CREATE TABLE `guest` (
  `guest_id` int(11) NOT NULL AUTO_INCREMENT,
  `surname` varchar(50) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `middlename` varchar(50) DEFAULT NULL,
  `contact` varchar(30) NOT NULL,
  `email` varchar(100) DEFAULT NULL,
  `valid_id_type` varchar(50) DEFAULT NULL,
  `valid_id_number` varchar(100) DEFAULT NULL,
  `notes` text DEFAULT NULL,
  PRIMARY KEY (`guest_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `guest` (`guest_id`, `surname`, `firstname`, `middlename`, `contact`, `email`, `valid_id_type`, `valid_id_number`, `notes`) VALUES
(1, 'Galzote', 'Jd', 'Jalbuna', '09673490318', 'jdgalzote24@gmail.com', 'National ID', '2345678', 'VIP Guest'),
(2, 'Blabla', 'BleBle', 'BliBli', '124567987234', 'BloBlo@gmail.com', 'Senior Citizen ID', '123426787', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `room_type`
--

CREATE TABLE `room_type` (
  `room_type_id` int(11) NOT NULL AUTO_INCREMENT,
  `type_name` varchar(100) NOT NULL,
  `room_size` decimal(6,2) NOT NULL,
  `standard_capacity` int(11) NOT NULL,
  `max_capacity` int(11) NOT NULL,
  `base_rate` decimal(10,2) NOT NULL,
  `extra_adult_fee` decimal(10,2) NOT NULL DEFAULT 800.00,
  `amenities` text DEFAULT NULL,
  PRIMARY KEY (`room_type_id`),
  UNIQUE KEY `type_name` (`type_name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `room_type` (`room_type_id`, `type_name`, `room_size`, `standard_capacity`, `max_capacity`, `base_rate`, `extra_adult_fee`, `amenities`) VALUES
(1, 'Standard Room', 22.00, 2, 3, 2500.00, 800.00, 'Wi-Fi, TV, Air Conditioning'),
(2, 'Deluxe Room', 32.00, 2, 4, 3800.00, 800.00, 'Wi-Fi, TV, Air Conditioning, Mini Refrigerator'),
(3, 'Executive Suite', 48.00, 2, 4, 5500.00, 800.00, 'Wi-Fi, TV, Air Conditioning, Living Area, Mini Refrigerator'),
(4, 'Family Suite', 55.00, 4, 6, 7000.00, 800.00, 'Wi-Fi, TV, Air Conditioning, Living Area, Dining Area, Kitchenette');

-- --------------------------------------------------------

--
-- Table structure for table `room`
--

CREATE TABLE `room` (
  `room_id` int(11) NOT NULL AUTO_INCREMENT,
  `room_type_id` int(11) NOT NULL,
  `room_number` varchar(20) NOT NULL,
  `floor` int(11) NOT NULL,
  `room_status` enum('Available','Occupied','Out of Order','Under Maintenance') NOT NULL DEFAULT 'Available',
  `created_at` datetime NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`room_id`),
  UNIQUE KEY `room_number` (`room_number`),
  KEY `fk_room_type` (`room_type_id`),
  CONSTRAINT `fk_room_type` FOREIGN KEY (`room_type_id`) REFERENCES `room_type` (`room_type_id`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `room` (`room_id`, `room_type_id`, `room_number`, `floor`, `room_status`, `created_at`) VALUES
(1, 1, '101', 1, 'Available', '2026-10-04 16:25:53'),
(2, 1, '102', 1, 'Available', '2026-10-04 16:25:53'),
(3, 1, '103', 1, 'Available', '2026-10-04 16:25:53'),
(4, 1, '104', 1, 'Available', '2026-10-04 16:25:53'),
(5, 2, '201', 2, 'Available', '2026-10-04 16:25:53'),
(6, 2, '202', 2, 'Available', '2026-10-04 16:25:53'),
(7, 2, '203', 2, 'Available', '2026-10-04 16:25:53'),
(8, 2, '204', 2, 'Available', '2026-10-04 16:25:53'),
(9, 3, '301', 3, 'Available', '2026-10-04 16:25:53'),
(10, 3, '302', 3, 'Available', '2026-10-04 16:25:53'),
(11, 4, '401', 4, 'Available', '2026-10-04 16:25:53'),
(12, 4, '402', 4, 'Available', '2026-10-04 16:25:53');

-- --------------------------------------------------------

--
-- Table structure for table `reservation`
--

CREATE TABLE `reservation` (
  `res_id` int(11) NOT NULL AUTO_INCREMENT,
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
  `created_at` datetime NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`res_id`),
  UNIQUE KEY `res_code` (`res_code`),
  KEY `fk_reservation_guest` (`guest_id`),
  KEY `fk_reservation_room` (`room_id`),
  KEY `fk_reservation_discount` (`discount_id`),
  KEY `fk_reservation_account` (`created_by`),
  CONSTRAINT `fk_reservation_account` FOREIGN KEY (`created_by`) REFERENCES `account` (`account_id`) ON UPDATE CASCADE,
  CONSTRAINT `fk_reservation_discount` FOREIGN KEY (`discount_id`) REFERENCES `discount` (`discount_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  CONSTRAINT `fk_reservation_guest` FOREIGN KEY (`guest_id`) REFERENCES `guest` (`guest_id`) ON UPDATE CASCADE,
  CONSTRAINT `fk_reservation_room` FOREIGN KEY (`room_id`) REFERENCES `room` (`room_id`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `payment`
--

CREATE TABLE `payment` (
  `payment_id` int(11) NOT NULL AUTO_INCREMENT,
  `res_id` int(11) NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  `payment_method` enum('Cash','GCash','Maya','PayPal','Card','Bank Transfer') NOT NULL,
  `reference_no` varchar(100) DEFAULT NULL,
  `payment_date` datetime NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`payment_id`),
  KEY `fk_payment_reservation` (`res_id`),
  CONSTRAINT `fk_payment_reservation` FOREIGN KEY (`res_id`) REFERENCES `reservation` (`res_id`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

COMMIT;
