# H.A.J.K High Rise Hotel Reservation System

A desktop application for managing hotel rooms, guests, reservations and payments.
Built with VB.NET (Windows Forms) and MySQL for SDF 104 – OOP, BSCS 2B.

## Features
- Admin and Staff login with different access
- Room, guest, reservation management
- Check-in, check-out, payments and invoice printing
- Reports with CSV and PDF export
- Settings: discounts, change password, system reset (Admin only)

## How to Run
1. Start MySQL in XAMPP.
2. In phpMyAdmin, import the **`schema.sql`** file located in the **`DataAccess > Database`** folder. This creates the `hajk` database.
3. Open `HajkHotel.slnx` in Visual Studio and press Start.

## Demo Accounts

**Admin:**
- admin0001 / admin123
- admin3104 / adminhans123

**Staff:**
- staff0001 / staff123
- staff1003 / staffjasper123

**Deactivated accounts (for testing the deactivated login message):**
- staff0839 / staffkirk123
- admin1268 / adminabe123
- staff1332 / staffjd123

## Team – H.A.J.K High Rise (BSCS 2B)

- **Project Manager / Documentation:** Ferolino, Abegail T.
- **Lead Programmer:** Olaes, Hans Norman T.
- **Assistant Programmer / Database Designer:** Galzote, John Dave J.
- **UI Designer / System Analyst:** Dela Cruz, Jasper E.
- **Business Analyst / Quality Assurance:** Cortal, Kirk Patrick S.

---

## ⚠️ DISCLAIMER

**This application requires an active MySQL database connection to run.**

- You **must** have **XAMPP** installed and running (specifically the Apache and MySQL modules).
- You **must** import the **`schema.sql`** file (located in the **`DataAccess > Database`** folder) into **phpMyAdmin** before attempting to log in. 
- If XAMPP is not running, or the database has not been imported, the application will open but will fail to log in or load any data.
