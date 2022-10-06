using DesafioPOO.Models;


// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia telefone1 = new Nokia(numero: "51 998903333", modelo: "N99", imei: "ADSR3343DSE998", memoria: 2000);

Iphone telefone2 = new Iphone(numero: "51 908764553", modelo: "XR", imei: "445FD23GT009WW", memoria: 4000);

Console.WriteLine("Testes referentes ao Telefone 1, da Nokia:");
telefone1.Ligar();
telefone1.ReceberLigacao();
telefone1.InstalarAplicativo("GPS Monitor");

Console.WriteLine("---------------------------");

Console.WriteLine("Testes referentes ao Telefone 2, da Apple:");
telefone2.Ligar();
telefone2.ReceberLigacao();
telefone2.InstalarAplicativo("Waze");