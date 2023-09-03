using CodewarsFun.General;

namespace CodewarsFun.Examples;

public class ExampleKata : Kata
{
    protected override string KataSolution(object[] @params) 
        => Task((int)@params[0], (int)@params[1])
            .ToString();

    private int Task(int a, int b) => a + b;
}