
using csharp_oop_shop;


Shop Powerbank = new Shop();

Powerbank.Nome = "Powerbank sfk300ultra";
Powerbank.Descrizione = "Questo è un prodotto troppo bello e costa pure poco";
Powerbank.Prezzo = 9.99;
Powerbank.Iva = 0.22m;
Console.WriteLine("Codice: " + Powerbank.Codice);
Console.WriteLine("Nome: " + Powerbank.Nome);
Console.WriteLine("Descrizione: " + Powerbank.Descrizione);
Console.WriteLine("Prezzo: " + Powerbank.Prezzo);
Console.WriteLine("Iva: " + Powerbank.Iva);