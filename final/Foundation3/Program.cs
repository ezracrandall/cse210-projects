using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var address1 = new Address("address 1", "Rexburg", "ID", "83440");
        var address2 = new Address("address 2", "Salt Lake City", "UT", "80015");
        var address3 = new Address("address 3", "Durango","CO","81301");

        var events = new List<Event>
        {
            new Lecture("Ezra Talk","talk about football science", new DateTime(2023, 11, 3), new DateTime(2023, 11, 3, 18, 30,0), address1, "Dr. Crandall",1000),
            new Reception("Ezra's Wedding", "Ezra will be getting married", new DateTime(2023, 12, 15),new DateTime(2023, 11, 3, 18, 30,0), address2, "rainy"),
            new OutdoorGathering("Crandall Family BBQ", "BBQ at the Crandall home", new DateTime(2023, 7, 4), new DateTime(2023, 7, 4, 12, 0, 30), address3, "ezracrandall@byui.edu")
        };

        foreach (var ev in events)
        {
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine();
        }
    }
}
