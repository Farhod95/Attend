![Console App Demo](Assets/animation.gif)
# 🎓 Attend Application

Welcome to the **Attend Application** – a simple **in-memory attendance management system** built with **C#**.  
This project demonstrates basic **CRUD operations** using `Add` and `GetAll` methods.

---

## 🗂️ Project Structure


---

## 🧩 Domain Models

- **👤 Student**
  - `FirstName` – First Name
  - `LastName` – Last Name
  - `Code` – Student Code
  - `Email` – Email Address

- **🕒 Attendance**
  - `Student` – Student reference
  - `EnterDate` – Date and time of entry
  - `ExitDate` – Date and time of exit
  - `ParticipationMinutes` – Minutes actively participated
  - `WaitingMinutes` – Minutes waiting

- **🌐 ExternalAttendance**
  - `FullNameWithCode`
  - `Email`
  - `EnterDate`, `ExitDate`
  - `Duration`
  - `IsHost`, `IsWaiting`

---

## ✨ Features

- **➕ Add Student** – Add a new student to the in-memory database
- **📋 Get All Students** – Display all students
- **🕘 Add Attendance** – Record attendance with enter/exit times
- **📊 Get All Attendances** – Display all attendance records

---

## 🚀 Usage

1. **Clone the repository**
```bash
git clone <repository-url>
var services = new Services();

// Adding students
services.AddStudent("Ali", "Valiyev", "1110", "ali@gmail.com");
services.AddStudent("Gul", "Karimova", "1111", "gul@gmail.com");

// Adding attendance
services.AddAttendence(
    new DateTime(2025, 12, 23, 9, 0, 0),   // EnterDate
    new DateTime(2025, 12, 23, 10, 30, 0), // ExitDate
    90,                                     // ParticipationMinutes
    10                                      // WaitingMinutes
);

// Display data
services.GetAllStudents();
services.GetAllAttends();
