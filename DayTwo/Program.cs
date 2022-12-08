
using static DayTwo.HandEnum;

namespace DayTwo;

// Part A Solution: 11386
public class DayTwo
{
    private static readonly Dictionary<string, HandShape> RockPaperStuff = new()
    {
        { "A", HandShape.Rock },
        { "B", HandShape.Paper },
        { "C", HandShape.Scissor },
        { "X", HandShape.Rock },
        { "Y", HandShape.Paper },
        { "Z", HandShape.Scissor }
    };

    public static void Main()
    {
        PartOne.DoSomething(RockPaperStuff);
        PartTwo.DoSomething(RockPaperStuff);

    }
}