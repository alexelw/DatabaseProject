namespace MyProject.Enums
{
    public enum BusType
    {
        Standard = 1,
        Mini = 2,
        DoubleDecker = 3,
        Electric = 4
    }
    public enum BusStatus
    {
        OnRoute,
        Delayed,
        OutOfService,
        Unknown
    }
    public enum RouteStatus
    {
        active,
        inactive
    }
    public enum PopularityScore
    {
        VeryLow = 1,
        Low = 2,
        Medium = 3,
        High = 4,
        VeryHigh = 5
    }
}