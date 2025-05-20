namespace DefaultNamespace;

public abstract class Smartphone
{
    public string Number { get; set; }
    private string Model { get; }
    private string IMEI { get; }
    private double Memory { get; }

    protected Smartphone(string number, string model, string imei, double memory)
    {
        Number = number;
        Model = model;
        IMEI = imei;
        Memory = memory;
    }

    public void Call()
    {
        Console.WriteLine("Calling...");
    }
    
    public void ReceiveCall()
    {
        Console.WriteLine("Receiving Call...");
    }

    public abstract void InstallApp(string name);
}