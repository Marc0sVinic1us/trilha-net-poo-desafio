using DesafioPOO.Models;

// Testando os métodos e funcionalidades abstraídas dos SmartPhones

Console.WriteLine("SmartPhone Nokia");
Smartphone nokia = new Nokia(numero: "11912345678", modelo: "Android", imei: "111121222343", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("SmartPhone iPhone");
Smartphone iPhone = new Iphone (numero: "119098861213", modelo: "IOS", imei: "5858292319123", memoria: 64);
iPhone.Ligar();
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Tik Tok");
