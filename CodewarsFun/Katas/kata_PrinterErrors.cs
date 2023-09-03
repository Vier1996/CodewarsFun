using CodewarsFun.General;
using CodewarsFun.General.Interfaces;

namespace CodewarsFun.Katas;

public class kata_PrinterErrors : TestableKata, IKataTestsHandler
{
    public kata_PrinterErrors() => DeclareTests();

    public void DeclareTests()
    {
        KataTests = new List<object[]>()
        {
            new object[] { "aaabbbbhaijjjm", "0/14" },
            new object[] { "aaaxbbbbyyhwawiwjjjwwm", "8/22" },
            new object[] { "aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz", "3/56" },
        };
    }

    protected override string KataSolution(object[] @params) 
        => Task((string)@params[0])
            .ToString();
    
    private string Task(string s)
    {
        return $"{s.ToCharArray().Count(chr => (int)chr >= 110)}/{s.Length}";
    }
}