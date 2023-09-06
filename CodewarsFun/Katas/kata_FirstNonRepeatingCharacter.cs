using CodewarsFun.General;
using CodewarsFun.General.Interfaces;
using System.Linq;

namespace CodewarsFun.Katas;

public class kata_FirstNonRepeatingCharacter : TestableKata, IKataTestsHandler
{
    public kata_FirstNonRepeatingCharacter() => DeclareTests();

    public void DeclareTests()
    {
        KataTests = new List<object[]>()
        {
            new object[] { "tT", "" },
            new object[] { "a", "a" },
            new object[] { "moonmen", "e" },
        };
    }

    protected override string KataSolution(object[] @params) 
        => Task((string)@params[0])
            .ToString();

    private string Task(string inputString) =>
        inputString
            .GroupBy(char.ToLower)
            .Where(chr => chr.Count() == 1)
            .Select(chr => chr.First().ToString())
            .DefaultIfEmpty("")
            .First();
}