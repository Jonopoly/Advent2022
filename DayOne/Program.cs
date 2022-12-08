// See https://aka.ms/new-console-template for more information

namespace DayOne;

internal class DayOne
{
    private static void Main()
    {
        // Read file and go straight into the work shop with it.
        var elfList = WorkShop2(File.ReadAllText("../../../InputFile.txt"));

        // Order by Descending based on Total Calories and get the first one
        var elf = elfList.OrderByDescending(e => e.TotalCalories).ToList().FirstOrDefault();

        Console.WriteLine(elf);
    }

    private static IEnumerable<Elf> WorkShop2(string fileString)
    {
        var elfList = new List<Elf>();

        var calorieArrayList = fileString.Split(new[] { "\r\n\r\n" }, StringSplitOptions.None);

        foreach (var calorieArray in calorieArrayList)
            elfList.Add(new Elf
            {
                CaloriesCarrying = calorieArray.Split("\r\n").Select(s => Convert.ToInt32(s)).ToList()
            });

        return elfList;
    }
}

internal class Elf
{
    public List<int> CaloriesCarrying { get; set; } = new();

    public int TotalCalories => CaloriesCarrying?.Sum() ?? 0;

    public override string ToString()
    {
        return $"This elf is currently carrying {CaloriesCarrying.Count} Items. Calories Total: {TotalCalories}";
    }
}