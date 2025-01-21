# Folder-Management
This project uses the **Page Object Model (POM)** framework combined with the **Test-Driven Development (TDD)** model and **FlaUI** for automating file operations in a Windows environment.

## Steps Performed

### 1. Create New Project
- Create a new C# project.
- Select **Console App (.NET)** and choose **C#** as the language.
- Set the target framework to **.NET 6.0** and complete the project setup.

### 2. NuGet Packages Installed:
To enable UI automation with FlaUI, the following NuGet packages are included:
- **FlaUI.Core**: The core FlaUI library for interacting with UI elements.
- **FlaUI.UIA3**: FlaUI library for UI automation based on the UI Automation framework (UIA3).

---

## Documentation

### **GenericKeyword.cs**
This class contains all the generic keyword methods that automate common tasks. Documentation for each method is included within the class.

### **Pages/Task1_Page.cs**
This class contains the core logic for automating file operations:
- **createNotePadFileWithText()**:
  - Creates a directory at a specified path.
  - Writes the given text to a file within the created directory.
  - Returns the path of the created folder.
  
- **verifyTextInNotePad()**:
  - Reads and verifies the content in the created file.
  - Logs whether the verification was successful or failed.
  
- **deleteCreatedFolder()**:
  - Deletes the created folder and its contents.

### **TestCases/testcase1.cs**
This file implements a specific test case by calling methods from **Task1_Page** to execute the following actions:
- Create the folder and file.
- Write text to the file and verify the content.
- Delete the folder and file.

### **Utilities/baseClass.cs**
This file contains reusable components and base logic necessary for executing tests, such as logging, error handling, and other common functionality.

---

## Framework Overview

This project is structured using the **Page Object Model (POM)** pattern. This approach organizes automation code into separate classes, each representing a specific page or task within the application. The goal is to improve code maintainability, scalability, and reusability.

### Framework Highlights:
- **FlaUI Integration**: FlaUI is used to interact with Windows UI for automating tasks, such as file operations and verifying UI elements.
- **Logging**: The framework logs detailed results and test steps to the file **TestResults/log.txt** for easy debugging and analysis.
- **Reusability**: Common tasks, such as creating files, verifying content, and deleting files, are encapsulated in reusable methods within the **GenericKeyword** and **Task1_Page** classes.

---

## How to Execute Task 1

1. **Clone or Download the Project**:
   - Clone the repository or download the ZIP file.

2. **Open the Solution in Visual Studio**:
   - Open the solution file (`.sln`) in Visual Studio.

3. **Customize Test Data (Optional)**:
   - You can edit or customize the input data in the **testcase1.cs** file. 
   - While there are plans to implement JSON or Excel files for easier test data management, this functionality has not yet been implemented due to time constraints.

4. **Ensure the Flag is Set to `true` in `Test.cs`**:
   - In the **Test.cs** file, make sure the flag for TestCase 1 is set to `true` to execute the corresponding test case.

5. **Run the Test**:
   - Run the **Test.cs** file in Visual Studio. The framework will automatically execute the defined steps.

6. **Review the Logs**:
   - After execution, check the **TestResults/log.txt** file for detailed results, logs, and status of the test steps.

---



