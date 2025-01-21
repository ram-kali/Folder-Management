using ConsoleApp1.TestCases;
using ConsoleApp1.Utilities;

class Test : BaseClass
{
    public static void Main()
    {
        beforeAll();
        if (true)
        {
            try
            {
                stepInfo("*** Start of Test Case1 ***");
                var testCase1 = new testcase1();
                testCase1.task1();
                stepInfo("*** End of Test Case1 ***");
            }
            catch (Exception ex)
            {
                stepFail($"Test case 1 Failed. An error occurred: {ex.Message}");
            }

            finally
            {
                afterAll();
            }
        }
    }
}
