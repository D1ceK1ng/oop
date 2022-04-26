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
    }
}