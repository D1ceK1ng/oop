using System;
using System.ComponentModel;

namespace OOP
{
    internal class Program
    {
        private static OverflowPost post = null;

        private static void Main()
        {
            
            CreatePost();
            Voting();
            post.PostInfo();

        }

        public static void CreatePost()
        {
            Console.WriteLine("Write your post title");
            var postTitle = Console.ReadLine();

            Console.WriteLine("Write description to your post");
            var postDescription = Console.ReadLine();

            post = new OverflowPost(postTitle, postDescription);

            
        }

        public static void Voting()
        {
            Console.WriteLine("Estimate current post:\n<+> - for up-voting\n<-> - for down-voting");
            var voting = Console.ReadKey().Key;

            while (voting != ConsoleKey.Escape)
            {
                switch (voting)
                {
                    case ConsoleKey.OemPlus:
                        post.UpVote();
                        break;
                    case ConsoleKey.OemMinus:
                        post.DownVote();
                        break;
                    default:
                        Console.WriteLine("Invalid Operation, try again");
                        break;
                }

                Console.WriteLine("To exit application press <Escape>");
                voting = Console.ReadKey().Key;
            }

            
        }
    }  
}

