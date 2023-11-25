namespace EnumerableExtensions;

public static class EnumerableExtensions
{
    public static IEnumerable<T> Pad<T>(this IEnumerable<T> elements, int amount, T item)
    {
        foreach (var element in elements)
        {
            yield return element;
        }
        for (var i = 0; i < amount; i++)
        {
            yield return item;
        }
    }
    
    public static IEnumerable<T> PadLeft<T>(this IEnumerable<T> elements, int amount, T item)
    {
        for (var i = 0; i < amount; i++)
        {
            yield return item;
        }
        foreach (var element in elements)
        {
            yield return element;
        }
    }

    public static IEnumerable<T> PadTo<T>(this IEnumerable<T> elements, int count, T item)
    {
        var amount = 0;
        
        foreach (var element in elements)
        {
            amount++;
            yield return element;
        }

        for (var i = 0; i < count - amount; i++)
        {
            yield return item;
        }
    }
}
