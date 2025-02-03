using ConsoleApp1.keyword;
using ConsoleApp1.Pages;
using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;
using System;
using System.Diagnostics;
using FlaUI.Core;

using FlaUI.Core.Input;
using System;
using System.Threading;
using FlaUI.Core.WindowsAPI;


namespace ConsoleApp1.TestCases
{
    public class testcase1:Task1_Page
    {
        string drivePath = @"D:\";
        string newFolderName = "TrumpfMetamation";
        string textFileName = "Welcome.txt";
        string textToBeWritten = "Welcome to Trumpf Metamation!";
        string expectedText = "Welcome to Trumpf Metamation!";
        string app = "explorer.exe";
        string folderName = "TrumpfMetamation_1";


        public void task1()
        {
            // Open D drive in File Explorer
            Process.Start("explorer.exe", "D:");

            // Wait for the File Explorer window to open
            wait(5);

            // Initialize FlaUI
            var app = Application.Attach("explorer.exe");
            using (var automation = new UIA3Automation())
            {
                var window = app.GetMainWindow(automation);
                createNewFolder(newFolderName);
                wait(2);
                string folderPath = Path.Combine(drivePath, newFolderName);
                string texFilePath = Path.Combine(folderPath, textFileName);
                CreateNewTextFileWithText(texFilePath, textToBeWritten);
                verifyTextInNotePad(folderPath, textFileName, expectedText);
                deleteCreatedFolder(folderPath);

            }
            
        }    
        
    }
}
