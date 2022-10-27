using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");

Nokia nokiaG1 = new Nokia(numero: "1234567", modelo: "Modelo 2", imei: "9999999999", memoria: 64);
nokiaG1.Ligar();
nokiaG1.InstalarAplicativo("Facebook");

Console.WriteLine("\n");


Console.WriteLine("Smartphone Iphone");
Iphone iphone30g = new Iphone(numero: "987654321", modelo: "Modelo G-40", imei: "11111111111", memoria: 98);
iphone30g.ReceberLigacao();
iphone30g.InstalarAplicativo("Telegram");