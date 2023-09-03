using CodewarsFun.General;
using CodewarsFun.General.Interfaces;

namespace CodewarsFun.Examples;

public class ExampleTestableKata : TestableKata, IKataTestsHandler
{
    public ExampleTestableKata() => DeclareTests();

    public void DeclareTests()
    {
        KataTests = new List<object[]>()
        {
            new object[] { 1, 1, 2 },
            new object[] { 2, 2, 4 },
            new object[] { 3, 3, 6 },
            new object[] { 4, 4, 8 },
            new object[] { 5, 5, 10 },
            new object[] { 6, 6, 12 },
            new object[] { 7, 7, 14 },
            new object[] { 8, 8, 16 },
            new object[] { 9, 9, 18 },
            new object[] { 10, 10, 20 },
            new object[] { 11, 11, 22 },
            new object[] { 12, 12, 24 },
            new object[] { 13, 13, 26 },
            new object[] { 14, 14, 28 },
            new object[] { 15, 15, 30 },
        };
    }
    
    protected override string KataSolution(object[] @params) 
        => Task((int)@params[0], (int)@params[1])
            .ToString();

    private int Task(int a, int b) => a + b;
}