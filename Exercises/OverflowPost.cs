using System;

namespace OOP
{
    public class OverflowPost
    {
        public int CurrentVote { get; private set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }

        public OverflowPost(string title, string description)
        {
            Title = title;
            Description = description;
            CreatedTime = DateTime.Now;
        }

        public int UpVote()
        {
            CurrentVote += 1 ;
            Console.WriteLine("\nPost's current votes are: " + CurrentVote);
            return CurrentVote;
        }

        public int DownVote()
        {
            CurrentVote -= 1;
            Console.WriteLine("\nPost's current votes are " + CurrentVote);
            return CurrentVote;
        }

        public void PostInfo()
        {
            Console.WriteLine("\n" + Title);
            Console.WriteLine(Description);
            Console.WriteLine(CreatedTime);
            Console.WriteLine(CurrentVote);
        }
        //private static OverflowPost post = null;

        //private static void Main()
        //{

        //    CreatePost();
        //    Voting();
        //    post.PostInfo();

        //}

        //public static void CreatePost()
        //{
        //    Console.WriteLine("Write your post title");
        //    var postTitle = Console.ReadLine();

        //    Console.WriteLine("Write description to your post");
        //    var postDescription = Console.ReadLine();

        //    post = new OverflowPost(postTitle, postDescription);


        //}

        //public static void Voting()
        //{
        //    Console.WriteLine("Estimate current post:\n<+> - for up-voting\n<-> - for down-voting");
        //    var voting = Console.ReadKey().Key;

        //    while (voting != ConsoleKey.Escape)
        //    {
        //        switch (voting)
        //        {
        //            case ConsoleKey.OemPlus:
        //                post.UpVote();
        //                break;
        //            case ConsoleKey.OemMinus:
        //                post.DownVote();
        //                break;
        //            default:
        //                Console.WriteLine("Invalid Operation, try again");
        //                break;
        //        }

        //        Console.WriteLine("To exit application press <Escape>");
        //        voting = Console.ReadKey().Key;
        //    }


        //}
    }
}