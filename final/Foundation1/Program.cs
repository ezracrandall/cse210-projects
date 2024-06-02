using System;
using System.Collections.Generic;





class Program
{
    static void Main(string[] args)
    {
       
        List<Video> videos = new List<Video>();
        Video video1 = new Video("Abstraction", "Ezra Crandall", 600);
        video1.comment("student", "worked great for me ");
        video1.comment("student2", "I still need help :(");

        Video video2 = new Video("How to through a fooball", "bom trady", 1000);
        video2.comment("footballApprentice", "now I know !");
        video2.comment("athlete101", "I am going to the NFL!!!");

        Video video3 = new Video("How to register", "BYUI", 120);
        video3.comment("BYUI-GUY", "Now I can register!");
        video3.comment("BYU-GUY", "I am not sure I understand");


      
        videos.AddRange(new Video[] { video1, video2, video3 });

        
        foreach (Video video in videos)
        {
            
            video.DisplayInfo();
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^");
        }
    }
}
