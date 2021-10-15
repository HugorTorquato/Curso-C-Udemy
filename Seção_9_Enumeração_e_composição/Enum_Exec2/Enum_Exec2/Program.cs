using System;
using Enum_Exec2.Entities;

namespace Enum_Exec2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar os comentários primeiro

            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow, that is awesome!");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zeland",
                "I'm going to visit this wanterfull coountry",
                12);

            // Adicionar os comentáros na lista
            p1.AddComment(c1);
            p1.AddComment(c2);


            Comment c3 = new Comment("Good Night");
            Comment c4 = new Comment("May the Force be with you");
            
            Post p2 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Good Night Guys",
                "See you tomorrow",
                5);

            p2.AddComment(c3);
            p2.AddComment(c4);


            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}
