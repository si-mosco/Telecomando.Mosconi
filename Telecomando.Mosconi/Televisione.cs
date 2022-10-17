﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecomando.Mosconi
{
    internal class Televisione
    {
        //attributi
        private string modello;
        private string produttore;
        private string[] conettori;
        private bool stato;
        private int canale;
        private string risoluzione;

        //costruttori
        public Televisione(string produttore1, string modello1)
        {
            produttore = produttore1;
            modello = modello1;
        }
        public Televisione(string modello1)
        {
            modello = modello1;
        }

        //metodi
        public void accendi()
        {
            stato = true;
        }
        public void spegni()
        {
            stato = false;
        }
        public void setCanale(int n)
        {
            canale = n;
        }
        public string getModello()
        {
            return modello;
        }
        public string getProduttore()
        {
            return produttore;
        }
        public string[] getConnettori()
        {
            return connettori;
        }
        public bool getStato()
        {
            return stato;
        }
        public int getCanale()
        {
            return canale;
        }
        public string getRisoluzione()
        {
            return risoluzione;
        }
    }
}
