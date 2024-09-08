using System;

class Program {
  public static void Main (string[] args) {
    
    int[] nums = { 1, 4, 9, 16, 25 };
    Loop l = new Loop(nums);

    Console.WriteLine(l.Current); //vypíše 1
    
    l.Right();
    Console.WriteLine(l.Current); //vypíše 4

    l.Right();
    l.Right();
    Console.WriteLine(l.Current); //vypíše 16

    l.Right();
    l.Right();
    Console.WriteLine(l.Current); //vypíše 1


    l.Left();
    Console.WriteLine(l.Current); //vypíše 25

  }
}