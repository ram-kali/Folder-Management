using ConsoleApp1.Pages;


namespace ConsoleApp1.TestCases
{
    public class testcase1:Task1_Page
    {
        string drivePath = @"D:\";
        string newFolderName = "TrumpfMetamation";
        string textFileName = "Welcome.txt";
        string textToBeWritten = "Welcome to Trumpf Metamation!";
        string expectedText = "Welcome to Trumpf Metamation!";
       
        public void task1()
        {
            string newFolderPath = createNotePadFileWithText(drivePath, newFolderName, textFileName, textToBeWritten);
            verifyTextInNotePad(newFolderPath, textFileName, expectedText);
            deleteCreatedFolder(newFolderPath);
        }

        
    }
}
