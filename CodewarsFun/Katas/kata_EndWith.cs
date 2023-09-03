using CodewarsFun.General;
using CodewarsFun.General.Interfaces;

namespace CodewarsFun.Katas;

public class kata_EndWith : TestableKata, IKataTestsHandler
{
    public kata_EndWith() => DeclareTests();

    public void DeclareTests()
    {
        KataTests = new List<object[]>()
        {
            new object[] { "samurai", "ai", true },
            new object[] { "sumo", "omo", false },
            new object[] { "ninja", "ja", true },
            new object[] { "sensei", "i", true },
            new object[] { "samurai", "ra", false },
            new object[] { "abc", "abcd", false },
            new object[] { "abc", "abc", true },
            new object[] { "abcabc", "bc", true },
            new object[] { "ails", "fails", false },
            new object[] { "fails", "ails", true },
            new object[] { "this", "fails", false },
            new object[] { "abc", "", true },
            new object[] { ":-)", ":-(", false },
            new object[] { "!@#$%^&*() :-)", ":-)", true },
            new object[] { "abc\n", "abc", false },
        };
    }

    protected override string KataSolution(object[] @params) 
        => Task((string)@params[0], (string)@params[1])
            .ToString();
    
    private bool Task(string str, string ending)
    {
        if (str.Length < ending.Length || !str.Contains(ending))
            return false;
        
        return str.Substring(str.Length - ending.Length, ending.Length).Equals(ending);
    }
}