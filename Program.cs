using DesafioPOO.Models;

// DONE: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone: Nokia");

Smartphone smartphoneNokia = new Nokia(numero: "19997204682", modelo: "Nokia Tijolo", iMEI: "111111111", memoria: 8);
smartphoneNokia.Ligar();
smartphoneNokia.InstalarAplicativo("Snake Game");

Console.WriteLine();

Console.WriteLine("Smartphone: Iphone");

Smartphone smartphoneIphone = new Iphone(numero: "1988684827", modelo: "Iphone505", iMEI: "222222222", memoria: 128);
smartphoneIphone.Ligar();
smartphoneIphone.InstalarAplicativo("Apple Bank");