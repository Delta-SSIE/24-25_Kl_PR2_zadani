using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //string filename = "smalltree.json";
        string filename = "largetree.json";
        Salesman boss = Salesman.DeserializeTree(File.ReadAllText(filename));

        DisplaySalesmenTree(boss);
    }
    static void DisplaySalesmenTree(Salesman node, string indent = "")
    {
        Console.WriteLine($"{indent}{node.Name} {node.Surname} - Sales: {node.Sales}");

        foreach (var subordinate in node.Subordinates)
        {
            DisplaySalesmenTree(subordinate, indent + "    ");
        }
    }
}
