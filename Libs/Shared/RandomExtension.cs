namespace Shared;

public static class RandomExtension
{
    public static T PickRandom<T>(this List<T> source)
    {
        return source[Random.Shared.Next(source.Count)];
    }
}