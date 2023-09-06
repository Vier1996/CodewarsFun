using CodewarsFun.Examples;
using CodewarsFun.General.Interfaces;
using CodewarsFun.Katas;

namespace CodewarsFun.Main;

public class CodewarsClass
{
    public void Run()
    {
        //////////// EXAMPLES ////////////
        /* IKata sampleKata = new ExampleKata();
        ITestableKata sampleTestableKata = new ExampleTestableKata();
        
        sampleKata.Run(new object[] { 99, 99 });
        sampleTestableKata.Run(); */
        //////////////////////////////////
        
        ITestableKata sampleTestableKata = new kata_PathFinder();
        sampleTestableKata.Run();
    }
}