SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";

CREATE DATABASE IF NOT EXISTS hajk_hotel_db;
USE hajk_hotel_db;


-- Table structure for table `account`
CREATE TABLE `account` (
  `account_id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password_hash` varchar(255) NOT NULL,
  `fullname` varchar(100) NOT NULL,
  `role` enum('Admin','Staff') NOT NULL,
  `account_status` enum('Active','Inactive') NOT NULL DEFAULT 'Active',
  `created_at` datetime NOT NULL DEFAULT current_timestamp(),
  `updated_at` datetime NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;


-- Sample data for the `account` table, including hashed passwords for security.
INSERT INTO `account` (`account_id`, `username`, `password_hash`, `fullname`, `role`, `account_status`, `created_at`, `updated_at`) VALUES
(1, 'Admin3104', 'admin123', 'Hans Norman Olaes', 'Admin', 'Active', '2026-10-04 16:23:25', '2026-10-04 16:23:25'),
(2, 'S0223', 'staff123', 'Jasper Dela Cruz', 'Staff', 'Active', '2026-10-04 16:52:02', '2026-10-04 16:52:02');


-- --------------------------------------------------------


-- Table structure for table `discount`
CREATE TABLE `discount` (
  `discount_id` int(11) NOT NULL,
  `created_by` int(11) NOT NULL,
  `discount_name` varchar(100) NOT NULL,
  `discount_rate` decimal(5,2) NOT NULL DEFAULT 0.00,
  `discount_type` enum('None','Statutory','Lean Season','Peak Season') NOT NULL,
  `start_date` varchar(5) DEFAULT NULL,
  `end_date` varchar(5) DEFAULT NULL,
  `vat_exempt` tinyint(1) NOT NULL DEFAULT 0,
  `created_at` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `discount` (`discount_id`, `created_by`, `discount_name`, `discount_rate`, `discount_type`, `start_date`, `end_date`, `vat_exempt`, `created_at`) VALUES
(1, 1, 'None', 0.00, 'None', NULL, NULL, 0, '2026-10-04 16:26:45'),
(2, 1, 'Statutory', 20.00, 'Statutory', NULL, NULL, 1, '2026-10-04 16:26:45'),
(3, 1, 'Lean Season', 15.00, 'Lean Season', '06-01', '10-31', 0, '2026-10-04 16:26:45'),
(4, 1, 'Peak Season', 10.00, 'Peak Season', '11-01', '01-31', 0, '2026-10-04 16:26:45');

-- --------------------------------------------------------


-- Table structure for table `guest`
CREATE TABLE `guest` (
  `guest_id` int(11) NOT NULL,
  `surname` varchar(50) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `middlename` varchar(50) DEFAULT NULL,
  `contact` varchar(30) NOT NULL,
  `email` varchar(100) DEFAULT NULL,
  `valid_id` varchar(50) DEFAULT NULL,
  `valid_idnum` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------


-- Table structure for table `payment`
CREATE TABLE `payment` (
  `payment_id` int(11) NOT NULL,
  `res_id` int(11) NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  `payment_method` enum('Cash','GCash','Maya','PayPal','Card','Bank Transfer') NOT NULL,
  `reference_no` varchar(100) DEFAULT NULL,
  `payment_date` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------


-- Table structure for table `reservation`
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
  `notes` text DEFAULT NULL,
  `created_at` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------


-- Table structure for table `room`
CREATE TABLE `room` (
  `room_id` int(11) NOT NULL,
  `room_type_id` int(11) NOT NULL,
  `room_number` varchar(20) NOT NULL,
  `floor` int(11) NOT NULL,
  `room_status` enum('Available','Occupied','Out of Order','Under Maintenance') NOT NULL DEFAULT 'Available',
  `amenities` text DEFAULT NULL,
  `created_at` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `room` (`room_id`, `room_type_id`, `room_number`, `floor`, `room_status`, `amenities`, `created_at`) VALUES
(1, 1, '101', 1, 'Available', 'Wi-Fi, TV, Air Conditioning', '2026-10-04 16:25:53'),
(2, 1, '102', 1, 'Available', 'Wi-Fi, TV, Air Conditioning', '2026-10-04 16:25:53'),
(3, 1, '103', 1, 'Available', 'Wi-Fi, TV, Air Conditioning', '2026-10-04 16:25:53'),
(4, 1, '104', 1, 'Available', 'Wi-Fi, TV, Air Conditioning', '2026-10-04 16:25:53'),
(5, 2, '201', 2, 'Available', 'Wi-Fi, TV, Air Conditioning, Mini Refrigerator', '2026-10-04 16:25:53'),
(6, 2, '202', 2, 'Available', 'Wi-Fi, TV, Air Conditioning, Mini Refrigerator', '2026-10-04 16:25:53'),
(7, 2, '203', 2, 'Available', 'Wi-Fi, TV, Air Conditioning, Mini Refrigerator', '2026-10-04 16:25:53'),
(8, 2, '204', 2, 'Available', 'Wi-Fi, TV, Air Conditioning, Mini Refrigerator', '2026-10-04 16:25:53'),
(9, 3, '301', 3, 'Available', 'Wi-Fi, TV, Air Conditioning, Living Area, Mini Refrigerator', '2026-10-04 16:25:53'),
(10, 3, '302', 3, 'Available', 'Wi-Fi, TV, Air Conditioning, Living Area, Mini Refrigerator', '2026-10-04 16:25:53'),
(11, 4, '401', 4, 'Available', 'Wi-Fi, TV, Air Conditioning, Living Area, Dining Area, Kitchenette', '2026-10-04 16:25:53'),
(12, 4, '402', 4, 'Available', 'Wi-Fi, TV, Air Conditioning, Living Area, Dining Area, Kitchenette', '2026-10-04 16:25:53'),
(13, 1, '13', 1, 'Available', 'sad', '2026-10-04 20:14:54'),
(14, 2, '14', 2, 'Available', 'ads', '2026-10-04 20:17:54');

-- --------------------------------------------------------


-- Table structure for table `room_type`
CREATE TABLE `room_type` (
  `room_type_id` int(11) NOT NULL,
  `type_name` varchar(100) NOT NULL,
  `room_size` decimal(6,2) NOT NULL,
  `standard_capacity` int(11) NOT NULL,
  `max_capacity` int(11) NOT NULL,
  `base_rate` decimal(10,2) NOT NULL,
  `extra_adult_fee` decimal(10,2) NOT NULL DEFAULT 800.00
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `room_type` (`room_type_id`, `type_name`, `room_size`, `standard_capacity`, `max_capacity`, `base_rate`, `extra_adult_fee`) VALUES
(1, 'Standard Room', 22.00, 2, 3, 2500.00, 800.00),
(2, 'Deluxe Room', 32.00, 2, 4, 3800.00, 800.00),
(3, 'Executive Suite', 48.00, 2, 4, 5500.00, 800.00),
(4, 'Family Suite', 55.00, 4, 6, 7000.00, 800.00);


-- Indexes for dumped tables
ALTER TABLE `account`
  ADD PRIMARY KEY (`account_id`),
  ADD UNIQUE KEY `username` (`username`);

ALTER TABLE `discount`
  ADD PRIMARY KEY (`discount_id`),
  ADD UNIQUE KEY `discount_name` (`discount_name`),
  ADD KEY `fk_discount_account` (`created_by`);

ALTER TABLE `guest`
  ADD PRIMARY KEY (`guest_id`);

ALTER TABLE `payment`
  ADD PRIMARY KEY (`payment_id`),
  ADD KEY `fk_payment_reservation` (`res_id`);

ALTER TABLE `reservation`
  ADD PRIMARY KEY (`res_id`),
  ADD UNIQUE KEY `res_code` (`res_code`),
  ADD KEY `fk_reservation_guest` (`guest_id`),
  ADD KEY `fk_reservation_room` (`room_id`),
  ADD KEY `fk_reservation_discount` (`discount_id`),
  ADD KEY `fk_reservation_account` (`created_by`);

ALTER TABLE `room`
  ADD PRIMARY KEY (`room_id`),
  ADD UNIQUE KEY `room_number` (`room_number`),
  ADD KEY `fk_room_type` (`room_type_id`);

ALTER TABLE `room_type`
  ADD PRIMARY KEY (`room_type_id`),
  ADD UNIQUE KEY `type_name` (`type_name`);


-- AUTO_INCREMENT for dumped tables
ALTER TABLE `account`
  MODIFY `account_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

ALTER TABLE `discount`
  MODIFY `discount_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

ALTER TABLE `guest`
  MODIFY `guest_id` int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE `payment`
  MODIFY `payment_id` int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE `reservation`
  MODIFY `res_id` int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE `room`
  MODIFY `room_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

ALTER TABLE `room_type`
  MODIFY `room_type_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;


-- Constraints for dumped tables
ALTER TABLE `discount`
  ADD CONSTRAINT `fk_discount_account` FOREIGN KEY (`created_by`) REFERENCES `account` (`account_id`) ON UPDATE CASCADE;

ALTER TABLE `payment`
  ADD CONSTRAINT `fk_payment_reservation` FOREIGN KEY (`res_id`) REFERENCES `reservation` (`res_id`) ON UPDATE CASCADE;

ALTER TABLE `reservation`
  ADD CONSTRAINT `fk_reservation_account` FOREIGN KEY (`created_by`) REFERENCES `account` (`account_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_reservation_discount` FOREIGN KEY (`discount_id`) REFERENCES `discount` (`discount_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_reservation_guest` FOREIGN KEY (`guest_id`) REFERENCES `guest` (`guest_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_reservation_room` FOREIGN KEY (`room_id`) REFERENCES `room` (`room_id`) ON UPDATE CASCADE;

ALTER TABLE `room`
  ADD CONSTRAINT `fk_room_type` FOREIGN KEY (`room_type_id`) REFERENCES `room_type` (`room_type_id`) ON UPDATE CASCADE;

COMMIT;
