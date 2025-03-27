public class BasicCinema
{
    public string DefaultCinema()
    {
        return "Просмотр обычного кино";
    }
}

public class LuxuryCinema : BasicCinema
{
    LuxuryCinema luxuryCinema = new LuxuryCinema();
    public string Cinema3D()
    {
        return "Просмотр кино в 3D";
    }

    public void Test()
    {
        Console.WriteLine(luxuryCinema.DefaultCinema());
        Console.WriteLine(luxuryCinema.Cinema3D());
    }
}