namespace DayTwo;

public class PartOne
{
    public static void DoSomething(Dictionary<string, HandEnum.HandShape> rockPaperStuff)
    {
  
            var myScoreboard = 0;

            foreach (var line in File.ReadAllLines("../../../Input.txt"))
            {
                var handStrategy = line.Split(" ");

                var elfHand = handStrategy[0];
                var humanHand = handStrategy[1];

                var battleResults = BattleOfTheHands((int)rockPaperStuff[humanHand], (int)rockPaperStuff[elfHand]);
                myScoreboard += (int)rockPaperStuff[humanHand] + battleResults[0];
            }

            Console.WriteLine("[Part 1] - My Score is: " + myScoreboard);
        }

    private static int[] BattleOfTheHands(int yourHand, int theirHand)
    {
        switch (yourHand)
        {
            //Win
            case 1 when theirHand == 3:
            case 2 when theirHand == 1:
            case 3 when theirHand == 2:
                return new[] { 6, 0 };
            // Draw
            case 1 when theirHand == 1:
            case 2 when theirHand == 2:
            case 3 when theirHand == 3:
                return new[] { 3, 3 };
            // Loss
            default:
                return new[] { 0, 6 };
        }
    }

}