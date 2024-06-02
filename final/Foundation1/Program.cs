using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("jhonnyenglish", 189, "Short of my vacations with TeslaCam");
        Video video2 = new Video("tesla", 254, "Introduction of Tesla Hot Wings 2024");
        Video video3 = new Video("tesla", 168, "The New XPad Max");
        Video video4 = new Video("tesla", 725, "Meet the new Infinity Gauntlet with Friday M4");

        
        video1.AddComment(new Comment("onion123", "This video has bad sound"));
        video1.AddComment(new Comment("jhonnyenglish", "You don't even know what I went through to record it."));
        video1.AddComment(new Comment("onion123", "You should post a video about that then"));
        videos.Add(video1);

        video2.AddComment(new Comment("grogu1986", "The face I made with this!!"));
        video2.AddComment(new Comment("LoveScottLang", "Chris: 'Don't feel anything'\n5 sec later\nhow do I stop this pain?!"));
        video2.AddComment(new Comment("kushallday135", "LOs CalienTes"));
        videos.Add(video2);

        video3.AddComment(new Comment("GoldsmithJohn", "Wait, so the “new” Magic Keyboard is just the Logitech touch combo?"));
        video3.AddComment(new Comment("azcerbic", "Good honest review. I do miss your up to date cell phone reviews."));
        video3.AddComment(new Comment("MaxAndersonn", "@mkbhd, review for this please"));
        videos.Add(video3);

        video4.AddComment(new Comment("therealbluewing", "After 5 years it still gives goosebumps"));
        video4.AddComment(new Comment("arzishahsan", "Life peaked here"));
        video4.AddComment(new Comment("naviations", "-Tony Stark died\n-Captain America hold the hammer\n-BlackWidow died\nToo late for this"));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.DisplayDetails();
        }

    }
}