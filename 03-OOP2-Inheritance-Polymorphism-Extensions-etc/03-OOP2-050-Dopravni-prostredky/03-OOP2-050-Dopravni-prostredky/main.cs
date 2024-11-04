using System;

namespace DopravniProstredky 
{
  class Program 
  {
    public static void Main (string[] args) 
    {
      Flotila flotila = new Flotila();

      flotila.PridejVozidlo(new ElektroAuto(160, 2));
      flotila.PridejVozidlo(new DieselAuto(180, 5));


      Console.WriteLine(flotila.Kapacita);
      flotila.Natankuj();

      flotila.PridejVozidlo(new DieselAuto(130, 5));

      Console.WriteLine();
      flotila.OdvezRychle(2);

      Console.WriteLine();
      flotila.OdvezRychle(6);

      Console.WriteLine();
      flotila.OdvezRychle(8);

      Console.WriteLine();
      flotila.OdvezRychle(15);

      flotila.PridejVozidlo(new Motocykl(220));

      Console.WriteLine(String.Join(", ", flotila.Pohony)); //nic by se nemělo ve výpisu opakovat


    }
  }
}

