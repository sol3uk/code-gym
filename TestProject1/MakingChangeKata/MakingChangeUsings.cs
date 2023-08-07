using System.Text;

namespace TestProject1;

public class MakingChangeUsings
{
    public static List<string> GetChange(int changeToReturn)
    {
        var allPermutations = new List<string>();
        var coinDenominations = new List<string>()
        {
            "1", "5", "10", "25", "50", "100"
        };

        var possibleCoinDenominations = new List<int>();

        foreach (var coin in coinDenominations)
        {
            var coinValue = Int32.Parse(coin);


            if (coinValue <= changeToReturn)
            {
                possibleCoinDenominations.Add(coinValue);
            }
        }

        foreach (var coin in possibleCoinDenominations)
        {
            if (coin == changeToReturn) // Can only fit one instance of coin type as change
            {
                allPermutations.Add(coin.ToString());
                continue;
            }

            if (changeToReturn % coin != 0) // Not directly divisible, but smaller than total
            {
                var changeTotal = coin;
                
                // GetChange() Recursion here?
            }
            
            if (changeToReturn % coin == 0) // Change directly divisible by coin
            {
                var newPermutation = "";
                for (int i = 0; i < (changeToReturn / coin); i++)
                {
                    newPermutation += $"{coin} ";
                }

                allPermutations.Add(newPermutation.Trim());
            }


            return allPermutations;
        }

        return new List<string>();
    }
}