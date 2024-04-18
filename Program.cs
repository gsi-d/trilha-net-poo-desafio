using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "11999999999", modelo: "Modelo Nokia 3210", _IMEI: "123456789", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo Iphone 15 PRO", _IMEI: "19852341", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");