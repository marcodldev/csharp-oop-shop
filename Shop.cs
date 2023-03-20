﻿using System;
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

     /*   Un prodotto è caratterizzato da:
    - codice(numero intero)
    - nome
    - descrizione
     prezzo
    - iva
    Usate opportunamente i livelli di accesso(public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
    alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
    Il codice prodotto sia accessibile solo in lettura
        Gli altri attributi siano accessibili sia in lettura che in scrittura
    Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
    Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
    Testate poi i vostri oggetti Prodotto, istanziandoli e provando ad interargirci per testare tutti i metodi che avete previsto. */

        public int Codice { get; private set; }
        public string? Nome { get; set; }
        public string? Descrizione { get; set; }
        public double Prezzo { get; set; }
        public int Iva { get; set; }

        public Shop()
        {
            Random random = new Random();
            Codice = random.Next(0, 1000);
        }


        public double PrezzoConIva()
        {
            return Prezzo + ((Prezzo * Iva) / 100);
        }

        public string NomeCodice()
        {
            return Nome + Codice;
        }
    }

}
