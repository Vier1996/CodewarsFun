using System.Drawing;
using CodewarsFun.General;
using CodewarsFun.General.Interfaces;

namespace CodewarsFun.Katas;

public class kata_RGBToHexConversion : TestableKata, IKataTestsHandler
{
    public kata_RGBToHexConversion() => DeclareTests();

    public void DeclareTests()
    {
        KataTests = new List<object[]>()
        {
            new object[] { 255,255,255, "FFFFFF" },
            new object[] { 255,255,300, "FFFFFF" },
            new object[] { 0,0,0, "000000" },
            new object[] { 148,0,211, "9400D3" },
            new object[] { 148,-20,211, "9400D3" },
            new object[] { 144,195,212, "90C3D4" },
            new object[] { 212,53,12, "D4350C" },
        };
    }
    
    protected override string KataSolution(object[] @params) 
        => Task((int)@params[0], (int)@params[1], (int)@params[2])
            .ToString();

    private string Task(int r, int g, int b)
    {
        r = Math.Clamp(r, 0, 255);
        g = Math.Clamp(g, 0, 255);
        b = Math.Clamp(b, 0, 255);
        
        return $"{r:X2}{g:X2}{b:X2}";
    }
}