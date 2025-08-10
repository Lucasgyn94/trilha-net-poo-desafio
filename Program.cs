using System.Data;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("$$$ TESTES COM NOKIA $$$");
Nokia nokia = new Nokia(numero: "62995956321", modelo: "Nokia C-5", imei: "1236548987", 32);
Console.WriteLine(nokia);

Console.WriteLine();

nokia.Ligar();
Console.WriteLine();

nokia.ReceberLigacao();
Console.WriteLine();

nokia.InstalarAplicativo("Chrome");


// testes iphone
Console.WriteLine("\n$$$ TESTES COM IPHONE $$$");
Iphone iphone = new Iphone(numero: "62925584725", modelo: "Iphone 11", imei: "994455228899", 128);
Console.WriteLine(iphone);

Console.WriteLine();

iphone.Ligar();
Console.WriteLine();

iphone.ReceberLigacao();
Console.WriteLine();

iphone.InstalarAplicativo("Chrome");
