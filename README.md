# SmartDine
A user login system with different roles (Admin, Customer)  
SmartDine is a C# WinForms desktop application designed to simplify and digitize the restaurant reservation process. It connects to a MySQL database using XAMPP and provides features for both customers and administrators.

🔧 Key Features
🔐 User Authentication
Supports multiple roles:

Admin: Manage and view all reservations

Customer: Book and manage personal reservations

📅 Table Reservation System
Customers can:

Select a date, time, and number of guests

View their existing reservations

Modify or cancel if allowed

🗂️ Admin Control Panel
Admins can:

View all reservations

Filter by date, status, or customer

💾 Database Initialization
On first run, the application:

Creates required tables (Users, Reservations)

Inserts sample users (admin and customer)

🧰 Tech Stack
Language: C#

UI Framework: WinForms

Database: MySQL (via XAMPP)

Library: MySql.Data for database connectivity
