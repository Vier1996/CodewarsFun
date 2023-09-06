using System.Numerics;
using CodewarsFun.General;
using CodewarsFun.General.Interfaces;

namespace CodewarsFun.Katas;

public class kata_SumStringsAsNumbers : TestableKata, IKataTestsHandler
{
    public kata_SumStringsAsNumbers() => DeclareTests();

    public void DeclareTests()
    {
        KataTests = new List<object[]>()
        {
            new object[] { "712577413488402631964821328","1", "712577413488402631964821329" },
        };
    }

    protected override string KataSolution(object[] @params)
        => Task((string)@params[0], (string)@params[1])
            .ToString();

    private string Task(string a, string b)
    {
        BigInteger first = BigInteger.Parse(string.IsNullOrEmpty(a) ? "0" : a);
        BigInteger second = BigInteger.Parse(string.IsNullOrEmpty(b) ? "0" : b);
        
        return (first + second).ToString();
    }
}