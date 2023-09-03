using CodewarsFun.Constants;

namespace CodewarsFun.General;

public class KataTester
{
    private readonly TestableKata.KataSolutionDelegate _solution;
    private readonly List<object[]> _tests;
    
    public KataTester(TestableKata.KataSolutionDelegate solution, List<object[]> tests)
    {
        _solution = solution;
        _tests = tests;
    }
    
    public bool RunTests()
    {
        Console.WriteLine(KataDebugConstants.TESTING_STARTS);

        int testIndex = 1;
        bool result = true;
        
        string testPrefix = KataDebugConstants.TESTING_SPECIAL_SYMBOL + " " + KataDebugConstants.TESTING_TEST_NUMBER;
        
        foreach (object[] kataTest in _tests)
        {
            if (_solution.Invoke(kataTest).Equals(kataTest.Last().ToString()))
            {
                Console.WriteLine(testPrefix + testIndex + 
                                  $" | {KataDebugConstants.TESTING_PASSED} {KataDebugConstants.TESTING_SPECIAL_SYMBOL}");
            }
            else
            {
                Console.WriteLine(testPrefix + testIndex +
                                  $" | {KataDebugConstants.TESTING_FAILED} | {KataDebugConstants.TESTING_WITH_ARGS} " + 
                                  $"<{(int)kataTest[0]}, {(int)kataTest[1]}> {KataDebugConstants.TESTING_SPECIAL_SYMBOL}");

                result = false;
            }
            
            testIndex++;
        }

        return result;
    }
}