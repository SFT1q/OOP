public class SmartPhone
{
    private int _batteryLife;

    public void Charge(int amount)
    {
        if (amount <= 0 || amount > 100)
        {
            throw new ArgumentException("В метод для зарядки телефона передано значение меньше либо равное нулю или больше ста");

        }
        _batteryLife += amount;
    }

    public int GetBatteryLife()
    {
        return _batteryLife;
    }
}
