using System;

namespace MindfulnessApp
{
    public class BreathingActivity : MindfulnessActivity
    {
        public BreathingActivity() : base("Breathing Activity", " breath in and out when prompted")
        {
        }

        public void PerformActivity()
        {
            base.PerformActivity();
            for (int i = 0; i < Duration / 6; i++)
            {
                Console.WriteLine("In");
                PauseWithAnimation(3);
                Console.WriteLine("Out");
                PauseWithAnimation(3);
            }
            Console.WriteLine("Great!");
            Console.WriteLine($" {Name} activity has been completed  (Duration: {Duration} seconds.");
            PauseWithAnimation(5);
        }
    }
}
