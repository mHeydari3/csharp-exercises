# C# Exercises - Learning Journey 🚀

> A collection of C# console and Windows Forms applications built while learning .NET development.  
> This repository documents my progress in mastering C# fundamentals, OOP principles, and UI development.

[![C#](https://img.shields.io/badge/language-C%23-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![.NET Framework](https://img.shields.io/badge/framework-.NET%20Framework%204.6-red.svg)](https://dotnet.microsoft.com/)
[![License: MIT](https://img.shields.io/badge/license-MIT-green.svg)](LICENSE)

---

## 📋 Overview

This repository contains hands-on exercises I'm building as I learn **C#** and **.NET Framework**. Each project focuses on specific concepts, progressing from basic syntax to object-oriented design and graphical user interfaces.

| # | Project | Type | Key Concepts |
|---|---------|------|-------------|
| 01 | 🎓 GradeManager | Console | `List<T>`, Methods, Input Validation, Error Handling |
| 02 | 🏦 BankAccount | Console | Classes, Properties, Constructors, Static Members, Exceptions |
| 03 | 👋 HelloWorld | Windows Forms | Form Design, Event Handling, UI Controls |
| 04 | 🧮 CalculatorApp | Windows Forms | Interfaces, Separation of Concerns, Interactive UI |

---

## 🛠 Technologies Used

- **Language**: C#
- **Framework**: .NET Framework 4.6
- **UI Framework**: Windows Forms (for projects 03 & 04)
- **IDE**: Visual Studio 2017+

---

## 📁 Project Structure

```
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
├── Properties/
│   └── AssemblyInfo.cs
├── App.config
├── csharp-exercises.csproj
└── csharp-exercises.sln
```

> ⚠️ The `bin/` and `obj/` folders contain build artifacts and are typically excluded from version control. Consider adding them to your `.gitignore` file.

---

## ▶️ How to Run

1. **Clone the repository**:
   ```bash
   git clone https://github.com/mHeydari3/csharp-exercises.git
   cd csharp-exercises
   ```

2. **Open in Visual Studio**:
   - Double-click `csharp-exercises.sln`
   - Or open Visual Studio → File → Open → Project/Solution

3. **Select which project to run**:
   - Open `Program.cs` and uncomment the `Main()` method for the desired exercise
   - Alternatively, right-click the project in Solution Explorer → Set as Startup Project

4. **Build & Run**:
   - Press `F5` or go to **Debug → Start Debugging**

---

## 💡 Learning Highlights by Project

### 01 - GradeManager (Console)
- Working with `List<int>`: adding, removing, sorting elements
- Input validation (grades must be between 0-20)
- Basic error handling with conditional checks
- Helper methods: average calculation, min/max finding, list printing

### 02 - BankAccount (Console)
- **Encapsulation**: private fields with public properties
- **Static members**: tracking total accounts created
- **Exception handling**: throwing `ArgumentException` for invalid operations
- **Constructor logic**: initializing objects with validation and random account number generation

### 03 - HelloWorld (Windows Forms)
- Introduction to WinForms Designer and auto-generated `.Designer.cs` files
- Handling button `Click` events
- Runtime UI manipulation: changing colors, text, and focus

### 04 - CalculatorApp (Windows Forms)
- **Interface usage** (`ICalculate`) for decoupling business logic from UI
- Building interactive forms with `NumericUpDown` and `Button` controls
- Input validation before performing calculations
- Displaying results using `MessageBox`

---

## 📈 Learning Progress

✅ C# basics (variables, conditionals, loops, arrays)  
✅ Object-Oriented Programming: classes, objects, properties, constructors  
✅ Collections: `List<T>` and common operations  
✅ Error handling fundamentals  
✅ Windows Forms basics and event-driven programming  
✅ Interfaces and separation of concerns  

🔜 Next Goals:
- LINQ and Lambda expressions
- Async/Await and asynchronous programming
- File I/O and database integration
- Unit testing with xUnit/NUnit

---

## 🤝 Contributing & Feedback

This is a personal learning project, but I welcome:
- Code review suggestions and best practices
- Bug reports or improvement ideas
- Recommendations for new exercises or topics

Feel free to open an [Issue](https://github.com/mHeydari3/csharp-exercises/issues) or reach out via [my GitHub profile](https://github.com/mHeydari3).

---

## 📄 License

This project is for educational purposes and is distributed under the **MIT License**.

```
MIT License - Copyright (c) 2026 Mohammad Heydari
```

---

<div align="center">

**✨ Learning in public, growing together ✨**  
[🔗 View Repository on GitHub](https://github.com/mHeydari3/csharp-exercises)

</div>




