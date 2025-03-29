using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Tutorial for Beginners", "Programming Master", 600);
        video1.AddComment(new Comment("User1", "Muy bueno tutorial!"));
        video1.AddComment(new Comment("User2", "Very helpful, thanks!"));
        video1.AddComment(new Comment("User3", "Could you make one about OOP?"));

        Video video2 = new Video("Learn Python in 10 Minutes", "Code Guru", 720);
        video2.AddComment(new Comment("PythonFan", "Me gusto mucho"));
        video2.AddComment(new Comment("Newbie", "Perfect for beginners"));
        video2.AddComment(new Comment("Expert", "Too basic for me"));

        Video video3 = new Video("Building a Website with HTML/CSS", "Web Wizard", 900);
        video3.AddComment(new Comment("FrontendDev", "Bueno trabajo"));
        video3.AddComment(new Comment("Designer", "Love the design tips"));
        video3.AddComment(new Comment("Student", "Exactly what I needed"));
        video3.AddComment(new Comment("Teacher", "I'll use this in my class"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // This part displays video information and comments
        foreach (Video video in videos)
        {
            Console.WriteLine("=================================");
            Console.WriteLine(video.GetVideoInfo());
            Console.WriteLine("\nComments:");
            
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommentInfo()}");
            }
            
            Console.WriteLine("=================================\n");
        }
    }
}