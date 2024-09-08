using System;

class Program {
    public static void Main (string[] args) {
        int[,] cisla =
        {
            { 0,  0, 12, 0,  7},
            {13,  0,  5, 0,  1},
            { 0, -1,  0, 4,  5},
            { 1, -1,  0, 0, -5},
        };

        Console.WriteLine(NejvicNul(cisla)); //vypíše 3
    }
}