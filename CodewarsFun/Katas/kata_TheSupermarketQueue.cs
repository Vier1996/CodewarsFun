using CodewarsFun.General;
using CodewarsFun.General.Interfaces;

namespace CodewarsFun.Katas;

public class kata_TheSupermarketQueue : TestableKata, IKataTestsHandler
{
    public kata_TheSupermarketQueue() => DeclareTests();

    public void DeclareTests()
    {
        KataTests = new List<object[]>()
        {
            new object[] { new int[] { }, 1, 0 },
            new object[] { new int[] { 1, 2, 3, 4 }, 1, 10 },
            new object[] { new int[] { 2, 2, 3, 3, 4, 4 }, 2, 9 },
            new object[] { new int[] { 1, 2, 3, 4, 5 }, 100, 5 },
        };
    }

    protected override string KataSolution(object[] @params) 
        => Task((int[])@params[0], (int)@params[1])
            .ToString();

    private int Task(int[] customers, int n)
    {
        Queue<int> customersQueue = new Queue<int>(customers);

        if (customersQueue.Count == 0) return 0;
        if (n > customersQueue.Count) return customersQueue.Max();

        int neededTime = 0;
        List<int> tills = new List<int>(n);
        
        for (int i = 0; i < n; i++) 
            tills.Add(customersQueue.Dequeue());

        while (tills.Any(residueTime => residueTime > 0))
        {
            int maxCustomerTime = tills.Max();

            tills = tills.OrderBy(time => time).Select(time => time -= maxCustomerTime).ToList();

            bool allReplaced = false;

            while (!allReplaced)
            {
                if (tills.Any(residueTime => residueTime <= 0))
                    for (int i = 0; i < n; i++)
                    {
                        if (customersQueue.Count <= 0)
                        {
                            allReplaced = true;
                            break;
                        }

                        if(tills[i] <= 0)
                            tills[i] += customersQueue.Dequeue();
                    }
                else
                    allReplaced = true;
            }

            neededTime += maxCustomerTime;
        }

        return neededTime;
    }
}