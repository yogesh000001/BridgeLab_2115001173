using System;

class LegacyAPI
{
    [Obsolete("This method is obsolete. Use NewFeature instead.")]
    public void OldFeature()
    {
        Console.WriteLine("Old feature method");
    }

    public void NewFeature()
    {
        Console.WriteLine("New feature method");
    }
}

class Program
{
    static void Main()
    {
        LegacyAPI api = new LegacyAPI();
        api.OldFeature();
        api.NewFeature();
    }
}