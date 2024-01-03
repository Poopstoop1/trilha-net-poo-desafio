using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123", modelo: "Modelo 2", imei: "124349387",memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "14", modelo: "Modelo 2", imei: "124349387",memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");

