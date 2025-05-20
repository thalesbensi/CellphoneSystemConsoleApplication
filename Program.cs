
using CellphoneSystem.Models;
using DefaultNamespace;

Console.WriteLine("Smartphone Nokia:");
Smartphone galaxy = new Samsung(number: "123456", model: "Modelo 1", imei: "11111111", memory: 64);
galaxy.Call();
galaxy.InstallApp("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(number: "4987", model: "Modelo 2", imei: "22222222", memory: 128);
iphone.ReceiveCall();
iphone.InstallApp("Telegram");



