using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_oop_shop
{
    public class Shop
    {

        public int Codice { get; private set; }
        public string? Nome { get; set; }
        public string? Descrizione { get; set; }
        public double Prezzo { get; set; }
        public int Iva { get; set; }

        //public Shop()
        //{
        //    Random random = new Random();
        //    Codice = random.Next(0, 1000);
        //}

        public Shop(int codice, string? nome, string? descrizione, double prezzo, int iva)
        {
            Random random = new Random();

            Codice = random.Next(0, 1000);
            Nome = nome;
            Descrizione = descrizione;
            Prezzo = prezzo;
            Iva = iva;
        }

        public double PrezzoConIva()
        {
            return Prezzo + ((Prezzo * Iva) / 100);
        }

        public string NomeCodice()
        {
            return Nome + " " + Codice;
        }
    }

}
