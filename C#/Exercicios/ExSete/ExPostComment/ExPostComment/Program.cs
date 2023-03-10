using ExPostComment.Entities;
using static System.Console;
using System;

namespace ExPostComment 
{
    class Program 
    {
        static void Main()
        {
            Post p1 = new Post(
                DateTime.Parse("30/11/1999 22:23:20"),
                "Slk cachorro",
                "Tudo na vida passa, até a uva passa",
                2
            );

            Comment c = new Comment(" Opai véi");
            p1.AddComment(c);

            Write(p1);
        }
    }
}