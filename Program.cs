
using csharp_oop_shop;


//Shop Powerbank = new Shop();

//Powerbank.Nome = "Powerbank sfk300ultra";
//Powerbank.Descrizione = "Questo è un prodotto troppo bello e costa pure poco";
//Powerbank.Prezzo = 9.99;
//Powerbank.Iva = 22;
//Console.WriteLine("Codice: " + Powerbank.Codice);
//Console.WriteLine("Nome: " + Powerbank.Nome);
//Console.WriteLine("Descrizione: " + Powerbank.Descrizione);
//Console.WriteLine("Prezzo: " + Powerbank.Prezzo);
//Console.WriteLine($"Prezzo con Iva calcolata: {Powerbank.PrezzoConIva()}");
//Console.WriteLine($"Nome completo con codice: {Powerbank.NomeCodice()}");

Shop Monitor = new Shop("Monitor Ultra Wide" ,"Monitor ultra sottile", 199.99,22) ;

Console.WriteLine("Codice: " + Monitor.Codice);
Console.WriteLine("Nome: " + Monitor.Nome);
Console.WriteLine("Descrizione: " + Monitor.Descrizione);
Console.WriteLine("Prezzo: " + Monitor.Prezzo);
Console.WriteLine($"Prezzo con Iva calcolata: {Monitor.PrezzoConIva()}");
Console.WriteLine($"Nome completo con codice: {Monitor.NomeCodice()}");

