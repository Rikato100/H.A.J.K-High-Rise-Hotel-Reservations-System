CREATE DATABASE IF NOT EXISTS hajk_hotel_db;
USE hajk_hotel_db;

CREATE TABLE IF NOT EXISTS account (
    account_id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password_hash VARCHAR(255) NOT NULL,
    fullname VARCHAR(100) NOT NULL,
    role VARCHAR(20) NOT NULL,
    account_status VARCHAR(20) NOT NULL DEFAULT 'Active',
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    updated_at DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);

-- test accounts (plain text passwords for now, hash these later)
INSERT INTO account (username, password_hash, fullname, role) VALUES
('Admin3104', 'admin123', 'Hans Norman Olaes', 'Admin'),
('E0223', 'emp123', 'Jasper Dela Cruz', 'Employee');
