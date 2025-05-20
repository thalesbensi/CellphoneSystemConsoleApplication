using DefaultNamespace;

namespace CellphoneSystem.Models;

public class Samsung : Smartphone
{
    public Samsung(string number, string model, string imei, double memory) : base(number, model, imei, memory)
    {
    }

    public override void InstallApp(string name)
    {
        Console.WriteLine($"Installing {name} app from Play Store");
    }
}