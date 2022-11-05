using DesafioPOO.Models;
/*
TODO: Realizar os testes com as classes Nokia e Iphone
IMPLEMENTADO!
*/

Console.WriteLine("Aparelho NOKIA");
Smartphone nokia = new Nokia(numero: "0123456789", modelo: "XR20", imei: "0101012145145474", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
nokia.SmartphoneMostrarConfiguracao("NOKIA");

Console.WriteLine("-------------------------------------------\n");

Console.WriteLine("Aparelho IPHONE");
Smartphone iphone = new Iphone(numero: "0987654321", modelo: "11 Pro", imei: "362457455211100", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
iphone.SmartphoneMostrarConfiguracao("IPHONE");