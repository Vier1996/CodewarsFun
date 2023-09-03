using System.Globalization;
using CodewarsFun.General;
using CodewarsFun.General.Interfaces;

namespace CodewarsFun.Katas;

public class kata_JadenCasingStrings : TestableKata, IKataTestsHandler
{
    public kata_JadenCasingStrings() => DeclareTests();

    public void DeclareTests()
    {
        KataTests = new List<object[]>()
        {
            new object[] { "How can mirrors be real if our eyes aren't real", "How Can Mirrors Be Real If Our Eyes Aren't Real" },
        };
    }

    protected override string KataSolution(object[] @params) 
        => Task((string)@params[0])
            .ToString();
    
    private string Task(string phrase)
    { 
        return phrase.ToJadenCase();
    }
}

public static class JadenCaseExtension
{
    public static string ToJadenCase(this string phrase)
    {
        return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase.ToLower());
    }
}