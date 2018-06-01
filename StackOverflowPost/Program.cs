using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post();

            try
            {
                do
                {
                    if (string.IsNullOrEmpty(post.Title))
                    {
                        Console.WriteLine("Please enter a title for your post: ");
                        var titleInput = Console.ReadLine();
                        Console.WriteLine("Please enter a description for your post: ");
                        var descriptioInput = Console.ReadLine();
                        
                        post.CreatePost(titleInput, descriptioInput);
                    }
                    else
                    {
                        Console.WriteLine("Please Press U to upvote and d to down vote");
                        var input = Console.ReadLine().ToLower();
                        if (input == "u")
                        {
                            post.UpVote();
                            Console.WriteLine("Total votes: " + post.ShowTally());

                        }
                        else if (input == "d")
                        {
                            post.DownVote();
                            Console.WriteLine("Total votes: " + post.ShowTally());

                        }
                    }

                } while (true);
                
                   

      
                
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured: here are some details" + ex);
            }
            







        }
    }
}
