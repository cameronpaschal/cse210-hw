using System;


class Program
{
    static void Main(string[] args)
    {

        Video video1 = new Video("March Madness Bracket Busted in Record Time! (Shocking Upsets)", "Hoops Havoc", 300 );
        Video video2 = new Video("Cinderella Story? This Underdog Just Shocked the Tournament!", "Bracket Busters", 360 );
        Video video3 = new Video("Top 10 Insane Buzzer Beaters in March Madness History!", "Final Four Frenzy", 240 );
        Video video4 = new Video("I Bet $10,000 on My Bracket... Here's What Happened!", "Madness Unleashed", 190 );

        string[] video1Comments = {
        "Bro, I spent HOURS researching my picks, and by day one, it was all over. Never again!",
        "I swear March Madness is just designed to humble us all. RIP my perfect bracket.",
        "Every year I believe, and every year my team lets me down. Pain."
        };

        string[] video2Comments = {
            "This team is making me believe in miracles. Let’s goooo!",
            "Imagine being the #1 seed and getting cooked like this… embarrassing.",
            "Calling it now—this is gonna be the biggest upset of the decade!"
        };

        string[] video3Comments = {
            "#3 gave me chills! That crowd reaction was unreal.",
            "I still remember watching #7 live… I lost my mind!",
            "Petition to rename March Madness to ‘Heart Attack Month’ after watching this."
        };

        string[] video4Comments = {
            "This is why I only bet with Monopoly money.",
            "Dude just paid for someone else’s vacation with that bet.",
            "This is either the smartest or dumbest thing I’ve ever seen. No in-between."
        };

        AddComments(video1Comments, video1);
        AddComments(video2Comments, video2);
        AddComments(video3Comments, video3);
        AddComments(video4Comments, video4);
        List<Video> videos = new List<Video> {video1, video2, video3, video4};

        foreach (Video video in videos){
            video.Display();
        }
    }
    public static void AddComments(string[] list, Video video){
            string name = "user";
            int counter = 1;
            foreach (string comment in list){
                string uname = name + counter;
                Comment newComment = new Comment(uname, comment);
                video.AddComment(newComment);
                counter++;
            }
        }
}