class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string choice;
        string prompt;
        string response;
        string date;
        Console.WriteLine("Welcome to your journal");

        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write(" enter prompt ");
                    prompt = Console.ReadLine();
                    Console.Write("Enter entry: ");
                    response = Console.ReadLine();
                    date = " 05/26/2003";
                    journal.AddEntry(prompt, response, date);
                    
                    break;
                case "2":
                    Console.WriteLine("Journal Entries:");
                    journal.DisplayEntries();
                    break;
                case "3":
                    Console.WriteLine("save to file");
                    break;
                case "4":
                    Console.WriteLine("load to file");
                    break;
                case "5":
                    Console.WriteLine("exiting ");
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }

        } while (choice != "5");
    }
}