using CodewarsFun.General;
using CodewarsFun.General.Interfaces;

namespace CodewarsFun.Katas;

public class kata_NumberOfPeopleInTheBus : TestableKata, IKataTestsHandler
{
    public kata_NumberOfPeopleInTheBus() => DeclareTests();

    public void DeclareTests()
    {
        KataTests = new List<object[]>()
        {
            new object[]
            {
                new List<int[]>()
                {
                    new[] { 3, 0 }, 
                    new[] { 9, 1 }, 
                    new[] { 4, 10 }, 
                    new[] { 12, 2 }, 
                    new[] { 6, 1 }, 
                    new[] { 7, 10 }
                }, 
                17
            },
        
            new object[]
            {
                new List<int[]>()
                {
                    new[] { 3, 0 }, 
                    new[] { 9, 1 }, 
                    new[] { 4, 8 }, 
                    new[] { 12, 2 }, 
                    new[] { 6, 1 }, 
                    new[] { 7, 8 }
                }, 
                21
            },
        };
    }

    protected override string KataSolution(object[] @params) 
        => Task((List<int[]>)@params[0])
            .ToString();
    
    private int Task(List<int[]> peopleListInOut)
    {
        return peopleListInOut.Sum(pair => pair[0] - pair[1]);
    }
}