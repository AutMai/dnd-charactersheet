namespace Domain.Extensions; 

public static class Extensions {
    public static bool ToBool(this sbyte num) => (num == 1);
}