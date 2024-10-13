using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to make a delicious soup", "Alberto Barrios", 300);
        Video video2 = new Video("Programming with classes", "Mark Stevenson", 1964);
        Video video3 = new Video("LDS Chapel Open House", "Eduardo Villalobos", 612);

        video1.AddComment(new Comment("Candy", "Great video!"));
        video1.AddComment(new Comment("Alice", "Officially the first viewer of any video on this channel."));
        video1.AddComment(new Comment("Max", "That looked so delicius!! make more pls!"));

        video2.AddComment(new Comment("Todd", "The moment you came here is at 05:17."));
        video2.AddComment(new Comment("Alex", "The video is lengthy, but I am glad that you covered the most part."));
        video2.AddComment(new Comment("Inti", "Wow, YouTube is getting better at recommending videos."));

        video3.AddComment(new Comment("Ivonne", "I wanna learn more about your doctine"));
        video3.AddComment(new Comment("Dann", "Whoever is reading this, I hope this day will be a great day."));
        video3.AddComment(new Comment("Bob", "Such an interesting video this is."));

        List<Video> videos = new List<Video> {video1, video2, video3}; //Shorthand initializer that populates the list with three Video objects when the list is created.
//  a concise way to initialize the list with values right away.        
        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetVideoInfo());
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            video.DisplayComment();
            Console.WriteLine();
        }
    }
}