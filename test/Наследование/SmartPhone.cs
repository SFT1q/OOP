using System.Threading.Channels;

public class BaseSmartPhone
{
    public string Call()
    {
        return "Простой звонок";
    }
}

public class ProSmartPhone : BaseSmartPhone
{
    ProSmartPhone smartPhone = new ProSmartPhone();
    public string VideoCall()
    {
        return "Звонок по видеосвязи";
    }

    public void Test()
    {
        Console.WriteLine(smartPhone.Call());
        Console.WriteLine(smartPhone.VideoCall());       
    }   
}

