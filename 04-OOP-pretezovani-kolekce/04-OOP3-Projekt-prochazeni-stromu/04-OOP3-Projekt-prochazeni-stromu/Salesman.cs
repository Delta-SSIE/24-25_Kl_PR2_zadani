using System;
using System.Collections.Generic;

class Salesman
{
    public int ID { get; init; }
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public int Sales { get; private set; }
    public List<Salesman> Subordinates { get; private set; }

    private static int lastID = 0;

    public Salesman(string surname, string name, int sales)
    {
        ID = lastID;
        lastID++;

        Name = name;
        Surname = surname;
        Sales = sales;
        Subordinates = new List<Salesman>();
    }

    public void AddSubordinate(Salesman subordinate)
    {
        Subordinates.Add(subordinate);
    }

}