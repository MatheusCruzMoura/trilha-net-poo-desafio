using DesafioPOO.Models;

Console.Clear();

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "91234-5678", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine();

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "98765-4321", modelo: "Modelo 2", imei: "222222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");