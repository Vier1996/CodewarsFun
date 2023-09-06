using CodewarsFun.General;
using CodewarsFun.General.Interfaces;

namespace CodewarsFun.Katas;

public class kata_PathFinder : TestableKata, IKataTestsHandler
{
    public kata_PathFinder() => DeclareTests();

    public void DeclareTests()
    {
        KataTests = new List<object[]>()
        {
            new object[] { ".W.\n" +
                           ".W.\n" +
                           "...", true },
            
            new object[] { ".W.\n" +
                           ".W.\n" +
                           "W..", false },
            
            new object[] { "......\n" +
                           "......\n" +
                           "......\n" +
                           "......\n" +
                           "......\n" +
                           "......", true },
            
            new object[] { "......\n" +
                           "......\n" +
                           "......\n" +
                           "......\n" +
                           ".....W\n" +
                           "....W.", false },
            
            new object[] { "..........W.................................W..................................\n" +
                           "..........W.................................W..................................\n" +
                           "..........W.................................W..................................\n" +
                           "..........W.................................W..................................\n" +
                           "..........W....................................................................\n" +
                           "..........W.............WWWWWWWWWWWWWWWWWWWWWW.................................\n" +
                           "..........W.......................W........W...................................\n" +
                           "..........W.......................W........W..WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW\n" +
                           "..........WWWWWWWWWWWWWWWWWWWWW...W........W..W................................\n" +
                           "..............................W...W........W..W...........W....................\n" +
                           "..............................W...W........W..............W....................\n" +
                           "..............................W...W........W..W...........W....................\n" +
                           "..............................W............W..W...........W....................\n" +
                           "..............................W...W........W..W...........W....................\n" +
                           "..............................W...W........W..W...........W....................\n" +
                           "..............................W...W........W..W...........W....................\n" +
                           "..............................W...W........W..W...........W....................\n" +
                           "..............................W...W........W..............W....................\n" +
                           "..............................W...W........W..W...........W....................\n" +
                           "..............................W...W........W..W...........W....................\n" +
                           "..................................W........W..W...........W....................\n" +
                           "WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW...W........WWWW...........W....................", true },
        };
    }

    protected override string KataSolution(object[] @params) 
        => Task((string)@params[0])
            .ToString();

    private bool Task(string maze)
    {
        bool containsPath = false;
        
        string[] split = maze.Split('\n');
        int width = split.Length;
        int length = split[0].Length;

        StepInto(0, 0, 1);
        
        void StepInto(int newX, int newY, int direction)
        {
            if(containsPath) return;
            if ((newX < 0 || newY < 0) || (newX >= length || newY >= width)) return;

            string line = split[newY];
            char cell = line[newX];
            
            if (cell == 44 || cell == 87) return;

            if (newX == length - 1 && newY == width - 1)
            {
                containsPath = true;
                return;
            }

            char[] array = line.ToCharArray();
            array[newX] = (char)44;
            split[newY] = new string(array);
            
            if(direction != 2) StepInto(newX, newY - 1, 0);
            if(direction != 3) StepInto(newX + 1, newY, 1);
            if(direction != 0) StepInto(newX, newY + 1, 2);
            if(direction != 1) StepInto(newX - 1, newY, 3);
        }

        return containsPath;
    }
}