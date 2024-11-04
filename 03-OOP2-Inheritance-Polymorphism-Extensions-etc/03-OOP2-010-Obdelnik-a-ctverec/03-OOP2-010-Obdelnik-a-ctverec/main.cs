using System;

namespace Inheritance {

  class Program {
    public static void Main (string[] args) {
      Obdelnik abcd = new Obdelnik(3, 4.5);
      Console.WriteLine(abcd) ;

      Ctverec efgh = new Ctverec(3);
      Console.WriteLine(efgh);
    }
  }

}