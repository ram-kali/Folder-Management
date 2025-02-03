using ConsoleApp1.keyword;
using FlaUI.Core.Input;
using FlaUI.Core.WindowsAPI;
using System.Diagnostics;


namespace ConsoleApp1.Pages
{
    public class Task1_Page:GenericKeyword
    {
        public string createNotePadFileWithText(string drivePath, string newFolderName, string textFileName, string textToBeWritten)
        {
            string newFolderPath = Path.Combine(drivePath, newFolderName);
            CreateDirectory(newFolderPath);
            string textFilePath = Path.Combine(newFolderPath, textFileName);
            CreateNewTextFileWithText(textFilePath, textToBeWritten);

            wait(1);
            return newFolderPath;
        }


        public void verifyTextInNotePad(string folderPath, string textFileName, string expectedText)
        {
            string textFilePath = Path.Combine(folderPath, textFileName);
            StartApplication("explorer.exe", folderPath);
            stepPass("Open Created Folder");
            wait(1);
            string actualText = File.ReadAllText(textFilePath);
            if (actualText == expectedText)
            {
                stepPass("Text verification succeeded! Expected Text: "+expectedText+" Actual Text: "+ actualText);                
            }
            else
            {
                stepFail("Failed to verify Text! Expected Text: " + expectedText + " Actual Text: " + actualText);
            }
        }

        public void deleteCreatedFolder(string folderPath)
        {
            DeleteFolder(folderPath);
        }

        public void createNewFolder(string folderName)
        {
            
            Keyboard.Press(VirtualKeyShort.LCONTROL);
            Keyboard.Press(VirtualKeyShort.SHIFT);
            Keyboard.Press(VirtualKeyShort.KEY_N);
            Keyboard.Release(VirtualKeyShort.KEY_N);
            Keyboard.Release(VirtualKeyShort.SHIFT);
            Keyboard.Release(VirtualKeyShort.LCONTROL);
            wait(2);
            Keyboard.Type(folderName);

            // Press Enter to confirm the folder name
            Keyboard.Press(FlaUI.Core.WindowsAPI.VirtualKeyShort.RETURN);
            Keyboard.Release(FlaUI.Core.WindowsAPI.VirtualKeyShort.RETURN);
            //typeString(folderName);


        }

        
    }
}
