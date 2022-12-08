using static DayTwo.HandEnum;

namespace DayTwo;

public class PartTwo
{
    public static void DoSomething(Dictionary<string, HandShape> rockPaperStuff)
    {
        var scoreHat = new Dictionary<string, Result>
        {
            { "X", Result.Lose },
            { "Y", Result.Draw },
            { "Z", Result.Win }
        };

        var myScoreboard = 0;

        foreach (var line in File.ReadAllLines("../../../Input.txt"))
        {
            var handStrategy = line.Split(" ");

            myScoreboard += BattleWithResults(rockPaperStuff[handStrategy[0]], scoreHat[handStrategy[1]]);
        }

        Console.WriteLine("[Part 2] - My Score is: " + myScoreboard);
    }
    private static int BattleWithResults(HandShape elfHand, Result expectedResult)
    {
        return elfHand switch
        {
            HandShape.Scissor when expectedResult == Result.Win => (int)Result.Win + (int)HandShape.Rock,
            HandShape.Rock when expectedResult == Result.Win => (int)Result.Win + (int)HandShape.Paper,
            HandShape.Paper when expectedResult == Result.Win => (int)Result.Win + (int)HandShape.Scissor,
            HandShape.Rock when expectedResult == Result.Draw => (int)Result.Draw + (int)HandShape.Rock,
            HandShape.Paper when expectedResult == Result.Draw => (int)Result.Draw + (int)HandShape.Paper,
            HandShape.Scissor when expectedResult == Result.Draw => (int)Result.Draw + (int)HandShape.Scissor,
            HandShape.Paper when expectedResult == Result.Lose => (int)Result.Lose + (int)HandShape.Rock,
            HandShape.Scissor when expectedResult == Result.Lose => (int)Result.Lose + (int)HandShape.Paper,
            HandShape.Rock when expectedResult == Result.Lose => (int)Result.Lose + (int)HandShape.Scissor,
            _ => 0
        };
    }

}