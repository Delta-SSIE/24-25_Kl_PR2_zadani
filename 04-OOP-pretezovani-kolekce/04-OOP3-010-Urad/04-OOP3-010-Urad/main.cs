using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {

        int pocetPrepazek = 3;

        Clovek[] lide =
        {
            new Clovek("Josef", "Smutný", 4),
            new Clovek("Anna", "Veselá", 3),
            new Clovek("Marie", "Zelená", 12),
            new Clovek("Jiří", "Červenka", 3),
            new Clovek("Antonín", "Černý", 5),
            new Clovek("Antonie", "Bohatá", 7),
            new Clovek("Richard", "Těsný", 4),
            new Clovek("Luisa", "Podhorská", 15),
        };

    }
}

class Clovek
{
    public string Jmeno { get; private set; }
    public string Prijmeni { get; private set; }
    public int Trvani { get; private set; }

    public Clovek(string jmeno, string prijmeni, int trvani)
    {
        Jmeno = jmeno;
        Prijmeni = prijmeni;
        Trvani = trvani;
    }
}