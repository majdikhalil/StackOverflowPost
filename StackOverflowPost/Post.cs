using System;

namespace StackOverflowPost
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        DateTime DateCreated { get; set; }

        public int NumberOfVotes { get; set; }

        public void CreatePost(string title, string description)
        {
            if(!string.IsNullOrWhiteSpace(title))
            {
                Title = title;
            }
            else
            {
                throw new ArgumentNullException("Title Can't be empty");
            }

            if(!string.IsNullOrWhiteSpace(description))
            {
                Description = description;
            }
            else
            {
                throw new ArgumentNullException("Description Can't be empty");
            }

            DateCreated = DateTime.Now;



        }

        public void UpVote ()
        {
            NumberOfVotes += 1;

        }

        public void DownVote()
        {
            NumberOfVotes -= 1;

        }

        public int ShowTally()
        {
            return NumberOfVotes;
        }

    }
}
