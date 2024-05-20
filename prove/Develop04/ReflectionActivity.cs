using System;

namespace MindfulnessApp
{
    public class ReflectionActivity : MindfulnessActivity
    {
          string[] Prompts = new[]
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

          string[] Questions = new[]
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        public ReflectionActivity() : base("Reflection", "This will help you to remmeber the good things.")
        {
        }

        public void PerformActivity()
        {
            base.PerformActivity();
            string prompt = Prompts[new Random().Next(Prompts.Length)];
            Console.WriteLine(prompt);
            for (int i = 0; i < Duration / 10; i++)
            {
                string question = Questions[new Random().Next(Questions.Length)];
                Console.WriteLine(question);
                PauseWithAnimation(5);
            }
            Console.WriteLine("Great!");
            Console.WriteLine($" {Name} activity has been completed  (Duration: {Duration} seconds.");
            PauseWithAnimation(5);
        }
    }
}
