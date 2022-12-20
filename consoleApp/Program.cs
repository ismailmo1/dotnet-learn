class Hello
{
    static void Main()
    {
        Pair<int, int> p = new Pair<int, int>(1, 2);
        Console.WriteLine(p.First);
    }
}
public class Pair<TFirst, TSecond>
{
    public TFirst First { get; }
    public TSecond Second { get; }

    public Pair(TFirst first, TSecond second) => (First, Second) = (first, second);
}