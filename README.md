# Speedrunning Community

A Windows Forms CRUD application built in C# for managing speedrun records across different games and categories. Created as a college project to simulate a desktop application for an internal organization.

---

## 🕹️ Features

- Keep track of, add, edit, and delete speedrun records, players, games, and platforms
- Structured relational database with foreign key constraints
- Basic input validation and error handling

---

## 💻 Tech Stack

- **Framework:** Windows Forms (.NET Framework)
- **Language:** C#
- **Database:** SQL Server (local instance)

---

## 🗂️ Data Structure

- **Players**: Nick, Age, 
- **Games**: Title, Genre, Platform
- **Platforms**: Name
- **Categories**: Name, Description
- **Records**: Player, Game, Category, Timer, Date

---

## 🚀 How to Run

1. Clone this repository:
    ```bash
    git clone https://github.com/Mario64NP/SRC-PS.git
    ```

2. Open the `.sln` file in Visual Studio

3. Ensure you have a local SQL Server instance running

4. Create the required database using the provided `.sql` script

5. Update the connection string in `App.config` or in code to match your SQL Server setup

6. Build and run the app via Visual Studio

---

## 📦 Notes

This project was later reworked in WPF using MVVM and modern UI principles. See the [WPF version here](https://github.com/Mario64NP/SRC).

