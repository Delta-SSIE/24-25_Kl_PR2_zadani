using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] nums = { 1, 4, 9, 16, 25 };
        Loop<int> l = new Loop<int>(nums);

        Console.WriteLine(l.Current); //vypíše 1
        l.Current = 0;
        Console.WriteLine(l.Current); //vypíše 0

        l.Right();
        Console.WriteLine(l.Current); //vypíše 4

        l.Right(2);
        Console.WriteLine(l.Current); //vypíše 16

        l.Right(2);
        Console.WriteLine(l.Current); //vypíše 0

        l.Left();
        Console.WriteLine(l.Current); //vypíše 25

        string[] numbers = { "one", "four", "nine", "sixteen", "twenty-five" };
        Loop<string> l2 = new Loop<string>(numbers);

        Console.WriteLine(l2.Current); //vypíše "one"
        l2.Current = "zero";
        Console.WriteLine(l2.Current); //vypíše "zero"

        l2.Right();
        Console.WriteLine(l2.Current); //vypíše "four"

        l2.Right(2);
        Console.WriteLine(l2.Current); //vypíše "sixteen"

        l2.Right(2);
        Console.WriteLine(l2.Current); //vypíše "zero"

        l2.Left();
        Console.WriteLine(l2.Current); //vypíše "twenty-five"

    }
}