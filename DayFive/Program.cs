namespace DayFive;

internal class Program
{
    public static void Main(string[] args)
    {
        var allLines = File.ReadAllLines("../../../input.txt").ToList();

        var (buckets, moves) = ParseInput(allLines);
        var (buckets2, moves2) = ParseInput(allLines);
        PartOne.Run("Part One Total:", buckets, moves);
        PartTwo.Run("Part Two Total:", buckets2, moves2);
    }

    private static (List<List<string>> buckets, List<string> moves) ParseInput(List<string> fileContent)
    {
        var fileInput = new List<string>();
        fileInput.AddRange(fileContent);

        // Get all boxes until blank line...
        var boxesList = fileInput.TakeWhile(t => t != "").ToList();

        // Get Columns from line before
        var columns = boxesList.Last().Trim().Split("   ");

        // Remove Stack from list...
        fileInput.RemoveRange(0, boxesList.Count + 1);

        // Remove last entry from list...
        boxesList.RemoveAt(boxesList.Count - 1);

        var stackList = columns.Select(_ => new List<string>()).ToList();

        foreach (var boxes in boxesList)
        {
            int count = 0;
            for (var index = 0; index < columns.Length; index++)
            {
                var enumerable = boxes.Skip(count).Take(4).ToList();
                var asString = string.Join("", enumerable).Trim();
                if (!string.IsNullOrWhiteSpace(asString))
                {
                    stackList[index].Add(asString);
                }

                count += 4;
            }
        }

        stackList.ForEach(e => e.Reverse());

        return (stackList, fileInput);
    }
}

internal abstract class PartTwo
{
    public static void Run(string sample, List<List<string>> buckets, IEnumerable<string> lineList)
    {
        foreach (var line in lineList.Select(line => line.Split(' ')))
        {
            int.TryParse(line[1], out var howManyToMove);
            int.TryParse(line[3], out var moveFromStack);
            int.TryParse(line[5], out var moveIntoWhichStack);

            buckets[moveFromStack - 1]
                .TakeThenRemove(howManyToMove)
                .ForEach(e => buckets[moveIntoWhichStack - 1]
                    .Add(e));
        }

        var result = buckets.Aggregate<List<string>?, string?>(null, (current, bucket) =>
            $"{current}{bucket?.LastOrDefault()?.Replace("[", "").Replace("]", "")}");

        Console.WriteLine($"{sample} {result}");
    }
}

internal class PartOne
{
    public static void Run(string sample, List<List<string>> buckets, List<string> allLines)
    {
        foreach (var stuff in allLines.Select(line => line.Split(' ')))
        {
            int.TryParse(stuff[1], out var howManyToMove);
            int.TryParse(stuff[3], out var moveFromStack);
            int.TryParse(stuff[5], out var moveIntoWhichStack);
            var cargoList = buckets[moveFromStack - 1].TakeThenRemove(howManyToMove);
            
            cargoList.Reverse();
            
            cargoList.ForEach(e => buckets[moveIntoWhichStack - 1].Add(e));
        }

        var result = buckets.Aggregate<List<string>?, string?>(null, (current, bucket) =>
            $"{current}{bucket?.LastOrDefault()?.Replace("[", "").Replace("]", "")}");

        Console.WriteLine($"{sample} {result}");
    }
}