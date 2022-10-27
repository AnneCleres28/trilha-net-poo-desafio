using DesafioPOO.Models;

// Teste

Smartphone iphone = new Iphone("925485699", "Iphone Pro", 542186555, 128);
Smartphone nokia = new Nokia("941289543", "Nokia", 584691222, 46);

Console.WriteLine(" Celular Iphone ");

iphone.Ligar();
Console.WriteLine();

iphone.InstalarAplicativo(" Instagram");

Console.WriteLine();

iphone.Numero = "Nr° 925485699";
iphone.MostrarNumero();

iphone.ReceberLigacao();

Console.WriteLine("----------------------------");
Console.WriteLine(" Celular Nokia ");

nokia.Ligar();
Console.WriteLine();

nokia.InstalarAplicativo(" Snapchat");

Console.WriteLine();
nokia.Numero = "Nr° 941289543";
nokia.MostrarNumero();

nokia.ReceberLigacao();