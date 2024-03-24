using DesafioPOO.Models;

Smartphone nokia = new Nokia(numero: "1234-5678", modelo: "Nokia 1", imei: "11111111", memoria: 64);
Smartphone iphone = new Iphone(numero: "0987-4321", modelo: "Iphone 1", imei: "22222222", memoria: 16);

Console.WriteLine("Smartphone Nokia: ");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");