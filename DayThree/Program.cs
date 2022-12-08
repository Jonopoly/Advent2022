// See https://aka.ms/new-console-template for more information

namespace DayThree;

internal static class DayThree
{
    public static void Main()
    {
        var allLines = File.ReadAllLines("../../../input.txt");
        
        // Part One
        var partOneTotal = 0;
        foreach (var line in allLines)
        {
            var firstComponent = line.Substring(0, (int)(line.Length / 2)).ToCharArray();
            var lastComponent = line.Substring((int)(line.Length / 2), (int)(line.Length / 2)).ToCharArray();
            partOneTotal += GetTotal(lastComponent.Intersect(firstComponent).ToList());
        }

        // Part Two
        var partTwoTotal = 0;
        var skipper = 0;

        for (var index = 0; index < allLines.Length /3; index++)
        {
            var firstThreeLines = allLines.Skip(skipper).Take(3).ToList();
            var firstLine = firstThreeLines[0].ToCharArray().ToList();
            var secondLine = firstThreeLines[1].ToCharArray();
            var thirdLine = firstThreeLines[2].ToCharArray();
            partTwoTotal += GetTotal(firstLine.Find(x => secondLine.Contains(x) && thirdLine.Contains(x)));
            skipper += 3;
        }



        Console.WriteLine($"Total 2 Keys: {partOneTotal}");
        Console.WriteLine($"Total 3 Keys: {partTwoTotal}");

    }

    private static int GetTotal(char commonLetter) => GetTotal(new List<char> { commonLetter }); 

    private static int GetTotal(IEnumerable<char> commonletter)
    {
        var x = 0;
        foreach (var letter in commonletter)
        {
            var str = letter.ToString().ToLower().ToCharArray().FirstOrDefault(); //
            x = (int)str - 96;
            if (char.IsUpper(letter))
            {
                x += 26;
            }   
        }

        return x;
    }
}