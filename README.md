# C# Exercises - Learning Journey 🚀

A collection of C# console and Windows Forms applications built while learning .NET development.
This repository documents my progress in mastering C# fundamentals, OOP principles, UI development, and **Database Integration with ADO.NET**.

![Language](https://img.shields.io/badge/language-C%23-blue.svg)
![Framework](https://img.shields.io/badge/framework-.NET%20Framework%204.6-red.svg)
![License](https://img.shields.io/badge/license-MIT-green.svg)

## 📋 Overview

This repository contains hands-on exercises I'm building as I learn C# and .NET Framework. Each project focuses on specific concepts, progressing from basic syntax to object-oriented design, graphical user interfaces, and **fully-featured data-driven applications with complete CRUD + Search operations**.

| # | Project | Type | Key Concepts |
| --- | --- | --- | --- |
| 01 | 🎓 GradeManager | Console | `List<T>`, Methods, Input Validation, Error Handling |
| 02 | 🏦 BankAccount | Console | Classes, Properties, Constructors, Static Members, Exceptions |
| 03 | 👋 HelloWorld | Windows Forms | Form Design, Event Handling, UI Controls |
| 04 | 🧮 CalculatorApp | Windows Forms | Interfaces, Separation of Concerns, Interactive UI |
| 05 | 📇 MyContacts | WinForms + SQL | ADO.NET, SQL Server, Repository Pattern, DataGridView, **Full CRUD + Real-time Search, ToolStrip, Modal Dialogs, Dual-Purpose Forms** |

## 🛠 Technologies Used

*   **Language:** C#
*   **Framework:** .NET Framework 4.6
*   **UI Framework:** Windows Forms
*   **Database:** Microsoft SQL Server (LocalDB/Express)
*   **Data Access:** ADO.NET (`SqlConnection`, `SqlCommand`, `SqlDataAdapter`, `DataTable`, **Parameterized Queries**, **LIKE Operator**)
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
├── 05_MyContacts/            # Contact Management System (DB-Connected) ✅ FULL CRUD + SEARCH
│   ├── Repository/
│   │   └── IContactsRepository.cs  # Interface for data access (CRUD + Search contract)
│   ├── Services/
│   │   └── ContactsRepository.cs   # ADO.NET Implementation with Parameterized Queries (INSERT/UPDATE/DELETE/SEARCH)
│   ├── frmAddOrEdit.cs             # 🔄 Dual-purpose modal form: Add NEW or Edit EXISTING contact
│   ├── frmAddOrEdit.Designer.cs
│   ├── frmAddOrEdit.resx
│   ├── MyContactsMainForm.cs       # Main UI with ToolStrip, DataGridView, Search Box, Edit/Delete buttons
│   ├── MyContactsMainForm.Designer.cs
│   └── MyContactsMainForm.resx
├── Properties/
│   ├── AssemblyInfo.cs
│   ├── Resources.Designer.cs  # Auto-generated resource accessor
│   └── Resources.resx         # Embedded ToolStrip icons (Base64)
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
    *   Create the `MyContacts` table with schema:
        ```sql
        CREATE TABLE MyContacts (
            ContactID INT PRIMARY KEY IDENTITY(1,1),
            Name NVARCHAR(100) NOT NULL,
            Family NVARCHAR(100) NOT NULL,
            Mobile NVARCHAR(20),
            Email NVARCHAR(100),
            Age INT,
            Address NVARCHAR(500)
        );
        ```
    *   Verify the `ConnectionString` in `ContactsRepository.cs` matches your local SQL Server instance:
        ```csharp
        "Data Source=.;Initial Catalog=Contact_DB;Integrated Security=true"
        ```

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

### 05 - MyContacts (WinForms + ADO.NET) ✅ Full CRUD + Search

#### ✅ Core Architecture:
*   **Repository Pattern:** `IContactsRepository` interface for loose coupling and testability.
*   **Disconnected Data Access:** `SqlDataAdapter` + `DataTable` for efficient data fetching.
*   **Data Binding:** Dynamic `DataGridView` population with `AutoGenerateColumns = false`.

#### ✅ CRUD Operations Implemented:
| Operation | Method | Security | Description |
|-----------|--------|----------|-------------|
| 🔹 **Create** | `Insert()` | ✅ Parameterized | Add new contact with validation |
| 🔹 **Read** | `SelectAll()` | ✅ Safe | Load all contacts into grid |
| 🔹 **Read One** | `SelectRow(id)` | ⚠️ **Fix Needed** | Load single contact for edit *(uses string concatenation - see Technical Debt)* |
| 🔹 **Update** | `Update()` | ✅ Parameterized | Edit existing contact with full field binding |
| 🔹 **Delete** | `Delete()` | ✅ Parameterized | Remove contact with confirmation dialog |
| 🔹 **Search** | `Search(keyword)` | ✅ Parameterized | Real-time fuzzy search on Name/Family with `LIKE %keyword%` |

#### ✅ UI/UX Features:
*   **ToolStrip Toolbar:** Professional action buttons with icons (`btnNewContact`, `btnRefresh`).
*   **Dual-Purpose Modal Form:** `frmAddOrEdit` handles both Add and Edit via `contactId` state flag.
*   **Real-time Search:** `txtSearch_TextChanged` event triggers instant filtering without full reload.
*   **Confirmation Dialogs:** User-friendly `MessageBox` with RTL support for Delete operations.
*   **Row Selection Handling:** `CurrentRow` checks prevent null-reference errors.
*   **Primary Key Hiding:** `ContactID` column hidden from end-user view for cleaner UI.

#### 🔐 Security Best Practices Applied:
```csharp
// ✅ Parameterized INSERT - Prevents SQL Injection
string query = "INSERT INTO MyContacts (...) VALUES (@Name, @Family, ...)";
sqlCommand.Parameters.AddWithValue("@Name", name);

// ✅ Parameterized UPDATE - All fields bound safely
sqlCommand.Parameters.AddWithValue("@ContactId", contactId); // Critical for WHERE clause

// ✅ Parameterized DELETE - Safe record removal
command.Parameters.AddWithValue("@ID", contactId);

// ✅ Parameterized SEARCH - LIKE with wildcards, no concatenation
adapter.SelectCommand.Parameters.AddWithValue("@parameter", "%" + keyword + "%");

// ✅ Resource Management - using statements prevent connection leaks
using (SqlConnection connection = new SqlConnection(connectionString))
{
    using (SqlCommand cmd = new SqlCommand(query, connection))
    {
        connection.Open();
        cmd.ExecuteNonQuery();
    } // Auto-dispose
} // Auto-close & dispose
```

#### 🔄 Dual-Purpose Form Pattern (`frmAddOrEdit`):
```csharp
// State flag determines operation mode
public int contactId = 0;  // 0 = Add Mode, >0 = Edit Mode

// Conditional logic in btnSubmit_Click
bool isEditMode = (contactId != 0);
if (isEditMode) {
    repository.Update(contactId, ...);  // Edit existing
} else {
    repository.Insert(...);             // Add new
}

// Auto pre-fill in Load event for Edit mode
if (contactId != 0) {
    DataTable dt = repository.SelectRow(contactId);
    txtName.Text = dt.Rows[0]["Name"].ToString();  // Populate fields
    // ... other fields
}
```

## 📈 Learning Progress

*   ✅ C# basics (variables, conditionals, loops, arrays)
*   ✅ Object-Oriented Programming: classes, objects, properties, constructors
*   ✅ Collections: `List<T>` and common operations
*   ✅ Error handling fundamentals
*   ✅ Windows Forms basics and event-driven programming
*   ✅ Interfaces and separation of concerns
*   ✅ ADO.NET & SQL Server Integration
*   ✅ Repository Design Pattern
*   ✅ DataGridView & Data Binding
*   ✅ ToolStrip Component & Resource Management
*   ✅ Modal Dialog Pattern & DialogResult Communication
*   ✅ Client-Side Input Validation with Guard Clauses
*   ✅ Parameterized Queries & SQL Injection Prevention (INSERT/UPDATE/DELETE/SEARCH)
*   ✅ **Full CRUD Operations: Create, Read, Update, Delete**
*   ✅ **Real-time Search with LIKE Operator**
*   ✅ **Dual-Purpose Form Pattern (Add/Edit)**
*   ✅ **Row Selection & State Passing Between Forms**

## 🔜 Next Goals:

### 🟡 Important (Architecture & Maintainability)
*   ⏳ **Move Validation Logic to Service Layer**: Separate UI validation from business rules for better testability
*   ⏳ **Implement Structured Error Logging**: Replace `catch { return false; }` with proper logging (`try-catch-log`)
*   ⏳ **Add Async/Await Support**: Use `ExecuteNonQueryAsync()` for non-blocking database operations

### 🟢 Enhancement (UX & Scalability)
*   ⏳ **Add Pagination to DataGridView**: Handle large datasets with `LIMIT/OFFSET` or server-side paging
*   ⏳ **Implement Column Sorting**: Enable user-click sorting on DataGridView headers
*   ⏳ **Add Export Feature**: Allow exporting contacts to CSV or Excel
*   ⏳ **Introduce Entity Framework Core**: Migrate from ADO.NET to ORM for cleaner data access code

### 🔵 Future Learning
*   ⏳ **Unit Testing with xUnit/NUnit**: Write tests for Repository and Service layers with Mocking
*   ⏳ **Dependency Injection Container**: Use `Microsoft.Extensions.DependencyInjection` for automatic wiring
*   ⏳ **Multi-language Support**: Implement resource files for Persian/English UI localization

## 🤝 Contributing & Feedback

This is a personal learning project, but I welcome:
*   🔍 **Code review suggestions** and security best practices (especially regarding `SelectRow` vulnerability).
*   🐛 **Bug reports** or improvement ideas for UI/UX flow.
*   💡 **Recommendations** for new exercises or advanced C# topics.

Feel free to open an [Issue](https://github.com/mHeydari3/csharp-exercises/issues) or reach out via [my GitHub profile](https://github.com/mHeydari3).

## 📄 License

This project is for educational purposes and is distributed under the MIT License.

**MIT License** - Copyright (c) 2026 Mohammad Heydari

<div align="center">

✨ Learning in public, growing together ✨

[🔗 View Repository on GitHub](https://github.com/mHeydari3/csharp-exercises)

</div>

