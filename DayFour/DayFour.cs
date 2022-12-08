// See https://aka.ms/new-console-template for more information

namespace DayFour
{
    
    public record ElfAssignment(int Begin, int End) {
        public static ElfAssignment Parse(string e) => 
            e.Split('-').Select(int.Parse).Chunk(2)
                .Select(p => new ElfAssignment(p[0], p[1])).Single();

        public bool Overlaps(ElfAssignment other) =>
            !(End < other.Begin || Begin > other.End);

        public bool OverlapsFully(ElfAssignment other) =>
            Begin >= other.Begin && End <= other.End
            || other.Begin >= Begin && other.End <= End;
    }

    public static class Assignments {
        private static ElfAssignment[] ParseAssignments(string ep) =>
            ep.Split(',').Select(ElfAssignment.Parse).Chunk(2).Single();

        public static int Part1() => 
            File.ReadLines("input.txt")
                .Select(ParseAssignments).Count(p => p[0].OverlapsFully(p[1]));

        public static int Part2() => 
            File.ReadLines("../../../input.txt")
                .Select(ParseAssignments).Count(p => p[0].Overlaps(p[1]));
    }
    
    
    static class DayFour
    {
        public static void Main(string[] args)
        {
            var allLines = File.ReadAllLines("../../../input.txt");
            // PartOne.Run(allLines);
            // PartTwo.Run(allLines);
            Console.WriteLine(Assignments.Part2());


        }
        
            
            
    }

    
    
    internal static class PartOne
    {
        public static void Run(string[] allLines)
        {
            var consumed = 0;
            foreach (var line in allLines)
            {
                var sectionPair = line.Split(',');
                var elfOne = sectionPair[0].Split("-");
                var elfTwo = sectionPair[1].Split("-");
                var eldOneRange = Utils.GetElfRange(elfOne);
                var elfTwoRange = Utils.GetElfRange(elfTwo);
                
                if (OneRangeFullyContainTheOther(eldOneRange, elfTwoRange))
                {
                    consumed++;
                }
            }
            Console.WriteLine(consumed + " Ranges are fully covered");
        }

        private static bool OneRangeFullyContainTheOther(List<int> firstList, List<int> secondList)
        {
            var x = firstList.Count < secondList.Count 
                ? firstList.Except(secondList).ToList() 
                : secondList.Except(firstList).ToList();
            return !x.Any();
        }

  
    }


    internal static class PartTwo
    {


        public static void Run(string[] allLines)
        {
            var AreasCovered = new List<int>();
            var ElvesOverlapping = 0;
            
            foreach (var line in allLines)
            {
                var sectionPair = line.Split(',');
                var elfOne = sectionPair[0].Split("-");
                var elfTwo = sectionPair[1].Split("-");
                
                var elfOneRange = Utils.GetElfRange(elfOne);
                var elfTwoRange = Utils.GetElfRange(elfTwo);
                if (IsAnyOverLapping(elfOneRange,AreasCovered) || IsAnyOverLapping(elfTwoRange,AreasCovered))
                {
                    ElvesOverlapping++;
                }


            }
            
            Console.WriteLine(ElvesOverlapping + " Ranges are fully covered");
        }

        private static bool IsAnyOverLapping(List<int> listOfElves, List<int> areasCovered)
        {
           var x = listOfElves.Except(areasCovered).ToList();
           if (x.Any())
           {
               areasCovered.AddRange(x);
           }
           return !x.Any();
            
            
        }
    }

    internal static class Utils
    {
        public static List<int> GetElfRange(string[] elfOne)
        {
            int.TryParse(elfOne[0], out var start);
            int.TryParse(elfOne[1], out var end);
            return GetRange(start, end);

        }

        public static List<int> GetRange(int start, int end)
        {
            var x = new List<int>();
            for (var i = start; i <= end; i++)
            {
                x.Add(i);
            }

            return x;
        }
    }
}