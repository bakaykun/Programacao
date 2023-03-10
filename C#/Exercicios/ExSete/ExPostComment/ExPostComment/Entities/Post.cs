using System;
using System.Collections.Generic;
using System.Text;

namespace ExPostComment.Entities
{
    public class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        { 
        }

        public Post(DateTime moment, string title, string content, int like)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = like;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder exb = new StringBuilder();
            exb.AppendLine(Title);
            exb.Append(Likes + " Likes -" );
            exb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            exb.AppendLine(Content);
            exb.AppendLine("Comments: ");
            foreach (Comment c in Comments)
            {
                exb.AppendLine(c.Text);
            }
            return exb.ToString();
        }
    }
}