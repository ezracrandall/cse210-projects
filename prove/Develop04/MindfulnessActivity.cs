using System;
using System.Threading;

namespace MindfulnessApp
{
    public class MindfulnessActivity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }

        public MindfulnessActivity(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public virtual void PerformActivity()
        {
            Console.WriteLine($"Starting {Name} activity.");
            Console.WriteLine(Description);
            Console.Write(" enter the duration of activity (seconds) ");
            Duration = int.Parse(Console.ReadLine());
            Console.WriteLine("prepare for activity");
            PauseWithAnimation(5);
        }

        public void PauseWithAnimation(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
    }
}
