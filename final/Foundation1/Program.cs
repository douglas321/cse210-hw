using System;

class Comment
{
    public string Commenter { get; set; }
    public string Text { get; set; }

    public Comment(string commenter, string text)
    {
        Commenter = commenter;
        Text = text;
    }
}

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    public Comment[] Comments { get; set; }
    private int commentCount;

    public Video(string title, string author, int length, int maxComments)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new Comment[maxComments];
        commentCount = 0;
    }

    public void AddComment(string commenter, string text)
    {
        if (commentCount < Comments.Length)
        {
            Comment newComment = new Comment(commenter, text);
            Comments[commentCount] = newComment;
            commentCount++;
        }
        else
        {
            Console.WriteLine("Cannot add more comments. Comment limit reached.");
        }
    }

    public int GetNumComments()
    {
        return commentCount;
    }
}

class Program
{
    static void Main()
    {
        List<Video> videoList = new List<Video>();

        // Create videos
        Video video1 = new Video("Birds, Animals or Government Spies?", "Roe Jogan", 3, 5);
        video1.AddComment("Alice", "Life Changing!");
        video1.AddComment("Bob", "I learned a lot, thanks!");
        video1.AddComment("Tonald Drump", "Fake News");

        Video video2 = new Video("The Efficasy of Horse Drawn Tanks", "Master Cheif", 45, 5);
        video2.AddComment("Charlie", "Interseting diagrams.");
        video2.AddComment("David", "Could you cover more examples?");
        video2.AddComment("Harry", "Magical!");

        Video video3 = new Video("ROBOTS ARE NOT TAKING OVER THE WORLD BY POISONING ALL OF THE APPLE JUICE", "Notrobot Smith", 6, 5);
        video3.AddComment("NotRobot John", "I can confirm.");
        video3.AddComment("68 75 6D 61 6E", "I'm human and this makes me feel peace and like not worrying!");
        video3.AddComment("RobotKiller34", "Unplug all the robots just in case!");

        // Display information for each video
        videoList.Add(video3);
        videoList.Add(video2);
        videoList.Add(video1);

        foreach (Video video in videoList)
        {
            DisplayVideoInfo(video);
        }
    }

    static void DisplayVideoInfo(Video video)
    {
        Console.WriteLine("Title: " + video.Title);
        Console.WriteLine("Author: " + video.Author);
        Console.WriteLine("Length: " + video.Length + " minutes");
        Console.WriteLine("Number of Comments: " + video.GetNumComments());

        // List out all comments for the video
        Console.WriteLine("Comments:");
        foreach (Comment comment in video.Comments)
        {
            if (comment != null)
            {
                Console.WriteLine($"{comment.Commenter}: {comment.Text}");
            }
        }

        Console.WriteLine("\n");
    }
}
