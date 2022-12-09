// See https://aka.ms/new-console-template for more information

using static System.Int32;

namespace DayFour
{
    static class DayFour
    {
        public static void Main()
        {
            var allLines = File.ReadAllLines("../../../input.txt");
            PartOne.Run("Part One Total is: ", allLines);
            PartTwo.Run("Part Two Total is: ", allLines);
        }
    }


    internal static class PartOne
    {
        public static void Run(string str, string[] allLines)
        {
            var consumed = 0;
            foreach (var line in allLines)
            {
                var pairs = line.Split(',');
                var eldOneRange = Utils.GetElfRange(pairs[0].Split("-"));
                var elfTwoRange = Utils.GetElfRange(pairs[1].Split("-"));

                if (RangeIsFulledConsumed(eldOneRange, elfTwoRange))
                {
                    consumed++;
                }
            }

            Console.WriteLine($"{str}: {consumed}");
        }

        private static bool RangeIsFulledConsumed(List<int> firstList, List<int> secondList)
        {
            return !(firstList.Count < secondList.Count
                ? firstList.Except(secondList).ToList()
                : secondList.Except(firstList).ToList()).Any();
        }
    }


    internal static class PartTwo
    {
        public static void Run(string str, IEnumerable<string> allLines)
        {
            var totalPairMatch = 0;

            foreach (var pairAssignment in allLines)
            {
                var pairs = pairAssignment.Split(',');

                var eldOneRange = Utils.GetElfRange(pairs[0].Split("-"));
                var elfTwoRange = Utils.GetElfRange(pairs[1].Split("-"));

                if (RangeOverlaps(eldOneRange, elfTwoRange).Any())
                {
                    totalPairMatch++;
                }
            }

            Console.WriteLine($"{str}: {totalPairMatch}");
        }

        private static List<int> RangeOverlaps(List<int> firstList, List<int> secondList)
        {
            return firstList.Count < secondList.Count
                ? firstList.Intersect(secondList).ToList()
                : secondList.Intersect(firstList).ToList();
        }
    }

    internal static class Utils
    {
        public static List<int> GetElfRange(string[] elfOne)
        {
            _ = TryParse(elfOne[0], out var start);
            _ = TryParse(elfOne[1], out var end);

            return GetRangeForElf(start, end);
        }

        private static List<int> GetRangeForElf(int start, int end)
        {
            var range = new List<int>();
            for (var i = start; i <= end; i++)
            {
                range.Add(i);
            }

            return range;
        }
    }
}