using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone - Implementado!
Console.WriteLine("Smartphone Nokia:");
Console.WriteLine("\n");

Smartphone nokia = new Nokia(numero: "119335596031", modelo: "N90", imei: "SDOSID021093", memoria: 8);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");
Console.WriteLine("Smartphone Iphone:");
Console.WriteLine("\n");

Smartphone iphone = new Iphone(numero: "119147625120", modelo: "13", imei: "ADFMAS09320", memoria: 4);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("iFood");

