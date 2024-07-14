//Benefits: it's not possible to create instance member accidentaly.

public static class Country
{
    public static string CountryName = "Bangladesh";
    public static int NoOfStates = 28;

    public static int GetNoOfUnionTerritories()
    {
        return 8;
    }
}