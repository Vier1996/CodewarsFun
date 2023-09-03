using CodewarsFun.General;
using CodewarsFun.General.Interfaces;

namespace CodewarsFun.Katas;

public class kata_MultiplesOf3Or5 : TestableKata, IKataTestsHandler
{
    public kata_MultiplesOf3Or5() => DeclareTests();

    public void DeclareTests()
    {
        KataTests = new List<object[]>()
        {
            new object[] { 10, 23 },
            new object[] { 10, 23 },
            new object[] { 10, 23 },
            new object[] { 10, 23 },
            new object[] { 10, 23 },
            new object[] { 10, 23 },
            new object[] { 20, 78 },
            new object[] { 20, 78 },
            new object[] { 20, 78 },
            new object[] { 20, 78 },
            new object[] { 20, 78 },
            new object[] { 20, 78 },
            new object[] { 200, 9168 },
            new object[] { 0, 0 },
        };
    }
    
    protected override string KataSolution(object[] @params) 
        => Task((int)@params[0])
            .ToString();

    private int Task(int value)
    {
        if (value is 3 or 5) return value;

        int summ = 0;

        for (int i = 3; i < value; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
                summ += i;
        }
        
        return summ;
    }
}