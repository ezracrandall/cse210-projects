using System;

namespace MindfulnessApp
{
    public class ListingActivity : MindfulnessActivity
    {
         string[] PromptsListing = new[]
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
        }

        public override void PerformActivity()
        {
            base.PerformActivity();
            string prompt = PromptsListing[new Random().Next(PromptsListing.Length)];
            Console.WriteLine(prompt);
            Console.WriteLine("Start listing items:");
            int count = 0;
            DateTime endTime = DateTime.Now.AddSeconds(Duration);
            while (DateTime.Now < endTime)
            {
                Console.Write("List an item: ");
                string item = Console.ReadLine();
                if (!string.IsNullOrEmpty(item))
                {
                    count++;
                }
            }
            Console.WriteLine($"you listed {count} items");
            Console.WriteLine("Great!");
            Console.WriteLine($" {Name} activity has been completed  (Duration: {Duration} seconds.");
            PauseWithAnimation(5);
        }
    }
}
