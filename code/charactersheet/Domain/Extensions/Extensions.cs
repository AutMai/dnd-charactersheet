namespace Domain.Extensions;

public static class Extensions {
    public static bool ToBool(this sbyte num) => (num == 1);

    public static int ToInt(this char c) => Convert.ToInt32(c.ToString());
    public static int ToInt(this string c) => Convert.ToInt32(c);
}