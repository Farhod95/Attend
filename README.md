# Attend Application

## Overview

This is a simple **in-memory attendance management system** built in C#.  
It allows you to:

- Add students
- Track student attendance (enter and exit times)
- Display all students and their attendances

The application uses a **fake in-memory database** (`DbContext`) and demonstrates basic CRUD operations (`Add` and `GetAll`).

---

## Project Structure


### Domain Models

1. **Student**
   - FirstName
   - LastName
   - Code
   - Email

2. **Attendance**
   - Student
   - EnterDate
   - ExitDate
   - ParticipationMinutes
   - WaitingMinutes

3. **ExternalAttendance**
   - FullNameWithCode
   - Email
   - EnterDate
   - ExitDate
   - Duration
   - IsHost
   - IsWaiting

---

## Features

### 1. Add Student
Add a new student to the in-memory database.

### 2. Get All Students
Retrieve and display all students.

### 3. Add Attendance
Add attendance for a student with enter and exit times, participation, and waiting minutes.

### 4. Get All Attendances
Retrieve and display all attendance records.

---

## Usage

1. Clone the repository:
```bash
git clone <repository-url>
