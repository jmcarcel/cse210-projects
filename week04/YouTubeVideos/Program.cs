using System;

class Program
{
    static void Main(string[] args)
    {

        Video video1 = new Video();
        video1._title = "Trouble waters";
        video1._author = "Alex Warren";
        video1._length = 210;

        Video video2 = new Video();
        video2._title = "In the stars";
        video2._author = "Benson Boone";
        video2._length = 216;

        Video video3 = new Video();
        video3._title = "Consider the Lilies";
        video3._author = "Roger Hoffman";
        video3._length = 330;

        video1.AddComments ("David", "Beautiful!");
        video1.AddComments ("Jhon", "Great video!");
        video1.AddComments("Sara", "I like how It sounds"); 

        video2.AddComments("Laura", "I love it!");
        video2.AddComments("Thomas", "Great song!");
        video2.AddComments("Bethanny", "I love this kind of music");
       
        video3.AddComments("Sebastian", "So peaceful");
        video3.AddComments("Grace", "Excellent music!");
        video3.AddComments("Ana", "This song brigs me hope");

        List<Video> _videos = new List<Video>();

        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);

        int count = 1;
        foreach (Video video in _videos)
        {
            System.Console.WriteLine($"Video {count}");
            video.DisplayVideo();
            count++;
        }

    }
}