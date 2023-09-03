using CodewarsFun.General;
using CodewarsFun.General.Interfaces;

namespace CodewarsFun.Katas;

public class kata_BouncingBalls : TestableKata, IKataTestsHandler
{
    public kata_BouncingBalls() => DeclareTests();

    public void DeclareTests()
    {
        KataTests = new List<object[]>()
        {
            new object[] { 3.0, 0.66, 1.5, 3 },
            new object[] { 30.0, 0.66, 1.5, 15 },
        };
    }

    protected override string KataSolution(object[] @params) 
        => Task((double)@params[0], (double)@params[1], (double)@params[2])
            .ToString();
    
    private int Task(double h, double bounce, double window)
    {
        if (h <= 0 || bounce is <= 0 or >= 1 || window >= h)
            return -1;
        
        int bouncesCount = -2;
        
        while (h > window)
        {
            h *= bounce;
            bouncesCount += 2;
        }

        return bouncesCount + 1;
    }
}