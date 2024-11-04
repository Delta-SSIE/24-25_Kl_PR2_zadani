using System;

namespace Interfaces 
{
    class Clovek
    {
        public string Jmeno { get; private set; }
        public double Hmotnost {get; private set;}
        public double Vyska { get; private set; }

        public Clovek(string jmeno, double hmotnost, double vyska) {
            if (jmeno.Length < 1) throw new ArgumentException("Příliš krátké jméno");
            if (hmotnost <= 0) throw new ArgumentOutOfRangeException();
            if (vyska <= 0) throw new ArgumentOutOfRangeException();

            this.Jmeno = jmeno;
            this.Hmotnost = hmotnost;
            this.Vyska = vyska;
        }

    }

}