using CodewarsFun.General;
using CodewarsFun.General.Interfaces;

namespace CodewarsFun.Katas;

public class kata_WhoLikesIt : TestableKata, IKataTestsHandler
{
    public kata_WhoLikesIt() => DeclareTests();

    public void DeclareTests()
    {
        KataTests = new List<object[]>()
        {
            new object[] { new string[0], "no one likes this" },
            new object[] { new string[] { "Peter" }, "Peter likes this" },
            new object[] { new string[] { "Jacob", "Alex" }, "Jacob and Alex like this" },
            new object[] { new string[] { "Max", "John", "Mark" }, "Max, John and Mark like this" },
            new object[] { new string[] { "Alex", "Jacob", "Mark", "Max" }, "Alex, Jacob and 2 others like this" },
        };
    }

    protected override string KataSolution(object[] @params)
        => Task((string[])@params[0])
            .ToString();

    private string Task(string[] name)
    {
        switch (name.Length)
        {
            case 0: return "no one likes this";
            case 1: return $"{name[0]} likes this";
            case 2: return $"{name[0]} and {name[1]} like this";
            case 3: return $"{name[0]}, {name[1]} and {name[2]} like this";
            default:
                return $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
        }
    }
}