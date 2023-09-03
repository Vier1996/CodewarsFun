using CodewarsFun.Constants;
using CodewarsFun.General.Interfaces;

namespace CodewarsFun.General;

public class TestableKata : ITestableKata
{
    public delegate string KataSolutionDelegate(object[] @params);

    protected List<object[]> KataTests = new List<object[]>();
    
    public void Run()
    {
        Console.WriteLine(KataDebugConstants.TESTING_KATA_NAME + GetType().Name);
        
        if (new KataTester(KataSolution, KataTests).RunTests())
        {
            Console.WriteLine(KataDebugConstants.TESTING_SUCCESS_RESULT);
            Console.WriteLine(KataDebugConstants.TESTING_APPROVE_TO_GLOBAL_TEST);
        }
        else
        {
            Console.WriteLine(KataDebugConstants.TESTING_FAILED_RESULT);
        }
    }
    
    protected virtual string KataSolution(object[] @params) => String.Empty;
}