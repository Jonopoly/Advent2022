namespace DayFive;

public static class Extension
{
    /// <summary>
    /// Simple put this takes then removes but returns the removed from the list
    /// </summary>
    /// <param name="source"></param>
    /// <param name="i"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static List<T> TakeThenRemove<T>(this List<T> source, int i)
    {
        // Take 
        var takenList = source.TakeLast(i).ToList();

        source.RemoveRange(source.Count - i,i);
        
        // Return Taken
        return takenList;
    }
}