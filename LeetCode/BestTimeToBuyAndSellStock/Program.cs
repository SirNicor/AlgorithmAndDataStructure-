public class Programm
{
    public static void Main()
    {   
        int[] prices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine(MaxProfit(prices));
    }
    
    public static int MaxProfit(int[] prices) {
        int[] pricesMin = new int[prices.Length];
        pricesMin[0] = prices[0];
        int maxProfit = 0;
        for (int i = 1; i<prices.Length; i++)
        {
            if (pricesMin[i-1] > prices[i])
            {
                pricesMin[i] = prices[i];
            }
            else
            {
                pricesMin[i] = pricesMin[i - 1];
            }
        }

        for (int i = prices.Length - 1; i >= 1; i--)
        {
            if (prices[i] - pricesMin[i - 1] > maxProfit)
            {
                maxProfit = prices[i] - pricesMin[i - 1];
            }
        }
        return maxProfit;
    }
}