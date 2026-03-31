// https://www.geeksforgeeks.org/c-sharp/list-class-in-c-sharp/
// https://essentialcsharp.com/declaring-and-instantiating-a-class

using System;

class Program
{
    static void Main(string[] args)
    {
        // Youtube Video 1 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        string video1Title = "C# Guide Part 1";
        string video1Author = "C# Man";
        string video1Length = "23 minutes";

        string video1Comment1Text = "Great video!";
        string video1Comment2Text = "Can you explain how you instantiated the class at the 10 min mark? Thanks!";
        string video1Comment3Text = "Stupid video!!!";

        string video1Comment1Name = "Mark H.";
        string video1Comment2Name = "Jenny O.";
        string video1Comment3Name = "Samuel B.";

        Comment video1Comment1 = new Comment(video1Comment1Name, video1Comment1Text);
        Comment video1Comment2 = new Comment(video1Comment2Name, video1Comment2Text);
        Comment video1Comment3 = new Comment(video1Comment3Name, video1Comment3Text);
        List<Comment> video1Comments = new List<Comment> {video1Comment1, video1Comment2, video1Comment3};

        Video youtubeVideo1 = new Video(video1Title, video1Author, video1Length, video1Comments);

        // Youtube Video 2 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        string video2Title = "Astrocraft Beginners Guide";
        string video2Author = "Astrocrafter17";
        string video2Length = "11 min";

        string video2Comment1Text = "Wow cool game!";
        string video2Comment2Text = "Anyone else thing this video is too short?";
        string video2Comment3Text = "Here first!";
        string video2Comment4Text = "Lame!";

        string video2Comment1Name = "Jeff N..";
        string video2Comment2Name = "Henry L.";
        string video2Comment3Name = "Sherry F.";
        string video2Comment4Name = "Sharkboy";

        Comment video2Comment1 = new Comment(video2Comment1Name, video2Comment1Text);
        Comment video2Comment2 = new Comment(video2Comment2Name, video2Comment2Text);
        Comment video2Comment3 = new Comment(video2Comment3Name, video2Comment3Text);
        Comment video2Comment4 = new Comment(video2Comment4Name, video2Comment4Text);
        List<Comment> video2Comments = new List<Comment> {video2Comment1, video2Comment2, video2Comment3, video2Comment4};

        Video youtubeVideo2 = new Video(video2Title, video2Author, video2Length, video2Comments);

        // Youtube Video 3 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        string video3Title = "Shower Head Replacement Guide";
        string video3Author = "DIY Girl";
        string video3Length = "17 minutes";

        string video3Comment1Text = "Cool video!";
        string video3Comment2Text = "Hmmm idk about this.";
        string video3Comment3Text = "Delete ur channel!!!!!";

        string video3Comment1Name = "Louis B.";
        string video3Comment2Name = "Louis B.";
        string video3Comment3Name = "Wendy W.";

        Comment video3Comment1 = new Comment(video3Comment1Name, video3Comment1Text);
        Comment video3Comment2 = new Comment(video3Comment2Name, video3Comment2Text);
        Comment video3Comment3 = new Comment(video3Comment3Name, video3Comment3Text);
        List<Comment> video3Comments = new List<Comment> {video3Comment1, video3Comment2, video3Comment3};

        Video youtubeVideo3 = new Video(video3Title, video3Author, video3Length, video3Comments);

        // Youtube Video 4 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        string video4Title = "How to run a sub-5 mile.";
        string video4Author = "Running Blog";
        string video4Length = "8 minutes";

        string video4Comment1Text = "Won't work!";
        string video4Comment2Text = "This is decent.";
        string video4Comment3Text = "Cool!";

        string video4Comment1Name = "Jean B.";
        string video4Comment2Name = "Sarah S.";
        string video4Comment3Name = "Ben W.";

        Comment video4Comment1 = new Comment(video4Comment1Name, video4Comment1Text);
        Comment video4Comment2 = new Comment(video4Comment2Name, video4Comment2Text);
        Comment video4Comment3 = new Comment(video4Comment3Name, video4Comment3Text);
        List<Comment> video4Comments = new List<Comment> {video4Comment1, video4Comment2, video4Comment3};

        Video youtubeVideo4 = new Video(video4Title, video4Author, video4Length, video4Comments);

        // Main Program
        List<Video> videos = new List<Video>() {youtubeVideo1, youtubeVideo2, youtubeVideo3, youtubeVideo4};

        foreach (Video vid in videos)
        {
            vid.DisplayVideoSummary();
        }
    }
}