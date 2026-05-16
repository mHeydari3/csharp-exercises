
# C# Exercises - Learning Journey 🚀

A collection of C# console and Windows Forms applications built while learning .NET development.
This repository documents my progress in mastering C# fundamentals, OOP principles, UI development, and **Database Integration with ADO.NET**.

![Language](https://img.shields.io/badge/language-C%23-blue.svg)
![Framework](https://img.shields.io/badge/framework-.NET%20Framework%204.6-red.svg)
![License](https://img.shields.io/badge/license-MIT-green.svg)

## 📋 Overview

This repository contains hands-on exercises I'm building as I learn C# and .NET Framework. Each project focuses on specific concepts, progressing from basic syntax to object-oriented design, graphical user interfaces, and **data-driven applications**.

| # | Project | Type | Key Concepts |
| --- | --- | --- | --- |
| 01 | 🎓 GradeManager | Console | `List<T>`, Methods, Input Validation, Error Handling |
| 02 | 🏦 BankAccount | Console | Classes, Properties, Constructors, Static Members, Exceptions |
| 03 | 👋 HelloWorld | Windows Forms | Form Design, Event Handling, UI Controls |
| 04 | 🧮 CalculatorApp | Windows Forms | Interfaces, Separation of Concerns, Interactive UI |
| **05** | **📇 MyContacts** | **WinForms + SQL** | **ADO.NET, SQL Server, Repository Pattern, DataGridView, Data Binding** |

## 🛠 Technologies Used

*   **Language:** C#
*   **Framework:** .NET Framework 4.6
*   **UI Framework:** Windows Forms
*   **Database:** Microsoft SQL Server (LocalDB/Express)
*   **Data Access:** ADO.NET (`SqlConnection`, `SqlDataAdapter`, `DataTable`)
*   **IDE:** Visual Studio 2017+
*   **Tools:** SQL Server Management Studio (SSMS)

## 📁 Project Structure

```text
csharp-exercises/
├── 01_GradeManager/          # Student grade management system (Console)
│   ├── GradeManager.cs       # Business logic class
│   └── Program.cs            # Entry point
├── 02_BankAccount/           # Bank account simulation (Console)
│   ├── BankAccount.cs        # Main class with properties & methods
│   └── Program.cs            # Demo & testing
├── 03_WindowsFormApp/        # First GUI app: Hello World!
│   ├── FirstApp__HelloWorld.cs
│   ├── FirstApp__HelloWorld.Designer.cs
│   └── FirstApp__HelloWorld.resx
├── 04_CalculatorApp/         # Graphical calculator
│   ├── ICalculate.cs         # Interface for math operations
│   ├── Calculate.cs          # Interface implementation
│   ├── CalculatorMainForm.cs # Main form & UI logic
│   └── CalculatorMainForm.Designer.cs
├── 05_MyContacts/            # Contact Management System (DB-Connected)
│   ├── Repository/
│   │   └── IContactsRepository.cs  # Interface for data access
│   ├── Services/
│   │   └── ContactsRepository.cs   # ADO.NET Implementation
│   ├── MyContactsMainForm.cs       # UI with DataGridView
│   ├── MyContactsMainForm.Designer.cs
│   └── MyContactsMainForm.resx
├── Properties/
│   └── AssemblyInfo.cs
├── App.config                # Configuration (Connection Strings if needed)
├── csharp-exercises.csproj
└── csharp-exercises.sln
```

> ⚠️ **Note:** The `bin/` and `obj/` folders contain build artifacts and are excluded from version control via `.gitignore`.

## ▶️ How to Run

1.  **Clone the repository:**
    ```bash
    git clone https://github.com/mHeydari3/csharp-exercises.git
    cd csharp-exercises
    ```

2.  **Open in Visual Studio:**
    *   Double-click `csharp-exercises.sln`
    *   Or open Visual Studio → File → Open → Project/Solution

3.  **Database Setup (For Project 05 - MyContacts):**
    *   Ensure **SQL Server** is installed and running.
    *   Create a database named `Contact_DB`.
    *   Create the `MyContacts` table (Schema details can be found in the course resources or generated via SSMS).
    *   Verify the `ConnectionString` in `ContactsRepository.cs` matches your local SQL Server instance.

4.  **Select which project to run:**
    *   Open `Program.cs` and uncomment the `Application.Run(...)` line for the desired form.
    *   Alternatively, right-click the project in Solution Explorer → **Set as Startup Project**.

5.  **Build & Run:**
    *   Press `F5` or go to **Debug** → **Start Debugging**.

## 💡 Learning Highlights by Project

### 01 - GradeManager (Console)
*   Working with `List<int>`: adding, removing, sorting elements.
*   Input validation (grades must be between 0-20).
*   Basic error handling with conditional checks.
*   Helper methods: average calculation, min/max finding, list printing.

### 02 - BankAccount (Console)
*   **Encapsulation:** private fields with public properties.
*   **Static members:** tracking total accounts created.
*   **Exception handling:** throwing `ArgumentException` for invalid operations.
*   Constructor logic: initializing objects with validation and random account number generation.

### 03 - HelloWorld (Windows Forms)
*   Introduction to WinForms Designer and auto-generated `.Designer.cs` files.
*   Handling button `Click` events.
*   Runtime UI manipulation: changing colors, text, and focus.

### 04 - CalculatorApp (Windows Forms)
*   **Interface usage** (`ICalculate`) for decoupling business logic from UI.
*   Building interactive forms with `NumericUpDown` and `Button` controls.
*   Input validation before performing calculations.
*   Displaying results using `MessageBox`.

### 05 - MyContacts (WinForms + ADO.NET) 🆕
*   **Database Integration:** Connecting C# applications to **SQL Server** using **ADO.NET**.
*   **Disconnected Architecture:** Using `SqlDataAdapter` and `DataTable` to fetch data efficiently.
*   **Repository Pattern:** Implementing `IContactsRepository` to separate data access logic from UI code.
*   **Data Binding:** Binding `DataTable` sources to `DataGridView` controls for dynamic data display.
*   **SQL Management:** Using **SSMS** for database creation and table design.
*   **Connection Strings:** Managing secure connections with `Integrated Security`.

## 📈 Learning Progress

*   ✅ C# basics (variables, conditionals, loops, arrays)
*   ✅ Object-Oriented Programming: classes, objects, properties, constructors
*   ✅ Collections: `List<T>` and common operations
*   ✅ Error handling fundamentals
*   ✅ Windows Forms basics and event-driven programming
*   ✅ Interfaces and separation of concerns
*   ✅ **ADO.NET & SQL Server Integration**
*   ✅ **Repository Design Pattern**
*   ✅ **DataGridView & Data Binding**

## 🔜 Next Goals:

*   Implementing **CRUD** operations (Insert, Update, Delete) for MyContacts.
*   Parameterized Queries to prevent **SQL Injection**.
*   LINQ and Lambda expressions.
*   Async/Await and asynchronous database programming.
*   Entity Framework Core (ORM) introduction.
*   Unit testing with xUnit/NUnit.

## 🤝 Contributing & Feedback

This is a personal learning project, but I welcome:
*   Code review suggestions and best practices.
*   Bug reports or improvement ideas.
*   Recommendations for new exercises or topics.

Feel free to open an [Issue](https://github.com/mHeydari3/csharp-exercises/issues) or reach out via [my GitHub profile](https://github.com/mHeydari3).

## 📄 License

This project is for educational purposes and is distributed under the MIT License.

**MIT License** - Copyright (c) 2026 Mohammad Heydari

<div align="center">
✨ Learning in public, growing together ✨
[🔗 View Repository on GitHub](https://github.com/mHeydari3/csharp-exercises)
</div>
