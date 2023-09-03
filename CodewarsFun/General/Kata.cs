using CodewarsFun.Constants;
using CodewarsFun.General.Interfaces;

namespace CodewarsFun.General;

public class Kata : IKata
{
    public void Run(object[] @params)
    {
        Console.WriteLine(KataDebugConstants.TESTING_KATA_NAME + GetType().Name);
        Console.WriteLine(KataDebugConstants.TESTING_ANSWER + KataSolution(@params));
    }

    protected virtual string KataSolution(object[] @params) => String.Empty;
}