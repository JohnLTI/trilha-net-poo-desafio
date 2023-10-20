using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.Clear();
Console.WriteLine("Modelo Nokia:");

Nokia n1 = new Nokia(numero: "(00) 987651423", modelo: "XEvolution", imei: "001122", memoria: 64);
n1.ReceberLigacao();
n1.InstalarAplicativo("Facebook");

Console.WriteLine("\n");


Console.WriteLine("Modelo Iphone:");

Iphone i1 = new Iphone(numero: "(00) 987651423", modelo: "X Pro", imei: "001122", memoria: 256);
i1.Ligar();
i1.InstalarAplicativo("Whatsapp");