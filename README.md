# ✈️ Flight Management System – VB.NET & SQL Server

A fully functional airline database application built with **Visual Basic (VB.NET)** in **Visual Studio** and connected to a **SQL Server** database. This multi-form Windows Forms application includes secure login for both **passengers** and **employees**, dynamic form navigation based on user roles, and complete database interaction through **stored procedures** for all CRUD operations.

---

## 📌 Overview

This project simulates a complete airline management system for an educational or demonstration environment. It allows:

- **Passengers** to manage their profiles and book flights  
- **Employees** (pilots and attendants) to view schedules and update profiles  
- **Administrators** to manage all data, assign staff, view statistics, and create new flights

All database interactions are handled with **stored procedures**, and the backend is prepopulated with sample data to showcase logic and functionality immediately.

---

## 🔧 Technologies Used

- **Visual Basic (VB.NET)** – Windows Forms Application
- **SQL Server** – Relational database with prepopulated data
- **ADO.NET** – For database connectivity
- **Stored Procedures** – Used exclusively for SELECT, INSERT, UPDATE, DELETE operations
- **Modular Architecture** – Reusable database utilities and global variable modules

---

## 📁 Project Structure

- `Project2_RE.sln` – Main Visual Studio solution file  
- `/Forms/` – All user interface forms (Passenger, Employee, Admin)  
- `/Modules/` – Includes:
  - A DB utilities module for opening/closing connections
  - A global variables module for session/user info
- `/SQL/` – Contains:
  - `IT-102 Final Project.sql` – Prepopulated schema and seed data

---

## 🧩 Key Features

### 🔐 Login System
- **Main Menu** provides options for:
  - Passenger Login
  - Employee Login
- **Authentication** via stored procedures, based on login ID and password
- Redirects to appropriate dashboard based on user type:
  - Passenger → Passenger Main Menu
  - Employee → Pilot / Attendant / Admin menu (based on `EmployeeTypeID`)

---

### 👤 Passenger Functionality

- **New Passenger** – Registers new passengers by inserting into the database
- **Login** – Validates credentials using stored procedure
- **Update Profile** – Prepopulated form; allows editing and saving info
- **View Past Flights** – Shows flight history, flight details, and total miles flown
- **Add Future Flight** – Allows booking of upcoming flights
- **View Future Flights** – Displays booked future flights and miles expected

---

### 🧑‍✈️ Employee Functionality

- **Login** – Uses separate employee table (`TEmployees`)
- Determines role by `EmployeeTypeID`:
  - **Pilot** Menu – View/update profile, flight schedule
  - **Attendant** Menu – Same as Pilot
  - **Admin** Menu – Full administrative controls

---

### 🛠️ Admin Functionality

#### 1. Manage Pilots
- Add, update, delete pilot records
- Assign pilots to future flights
- Selection via dropdown (prepopulated with names)

#### 2. Manage Attendants
- Same full functionality as pilot management

#### 3. View Statistics
- Two list boxes showing:
  - Total miles flown per pilot
  - Total miles flown per attendant
- Additional passenger stats:
  - Total passengers
  - Total flights taken
  - Average miles flown

#### 4. Create New Flights
- Input all flight data and add to the system
- Enables future bookings for both staff and passengers

---

## 🧠 Application Architecture

- **Modules**
  - `modDatabaseUtilities` – Procedures for opening/closing database connections
  - `modGlobalVariables` – Stores global variables like current user info

- **Forms**
  - Passenger, Pilot, Attendant, and Admin each have dedicated forms
  - Menus use button navigation and stored procedure queries

- **Database Design**
  - Includes tables like:
    - `TPassengers`
    - `TEmployees`
    - `TFlights`
    - `TPassengerFlights`
    - `TPilotFlights`
    - `TAttendantFlights`
  - Preloaded with data for realistic interaction

---

## 🚀 Getting Started

1. **Clone or Download the Repository**
2. **Open `Project2_RE.sln` in Visual Studio**
3. **Update Connection String**
   - In the relevant module or config file, point it to your local SQL Server instance
4. **Set Up the Database**
   - Run `IT-102 FinalProject.sql` in SQL Server Management Studio
5. **Build and Run**
   - Start the app via Visual Studio
   - Use sample credentials to log in as a passenger or employee

---

## 🎯 Skills Demonstrated

- Frontend/back-end integration with ADO.NET
- Stored procedure-based database control
- Role-based UI and logic flow
- Modular programming with reusable procedures and variables
- Practical SQL database design with relationships and sample data
- Prepopulated dropdowns, live data display, and summary stats
