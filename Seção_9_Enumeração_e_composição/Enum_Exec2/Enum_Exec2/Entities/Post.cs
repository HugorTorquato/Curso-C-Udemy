using System;
using System.Collections.Generic;
using System.Text;

namespace Enum_Exec2.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        // - Declarar uma lista de comentários, do tipo da classe comment
        // - Important instanciar essa lista para ela n ter chance de ser null, por isso 
        // o "= new List<Comment>()" no final 

        // A ideia é criar uma lista que pode relacionar a classe Posts a vários comentários
        // por isso a criação da lista 

        public List<Comment> Comments { get; set; } = new List<Comment>();

        // Construtores

        public Post()
        {

        }

        // O atributo da lista vai ser desmarcado, não é passado ao construtor
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        // Colocar os operadores de adicionar e remover comentários

        public void AddComment(Comment comment)
        {
            Comments.Add(comment); // Usa o atributo Comments e não a classe Comment
        }
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        // Implementar o ToString para definir como ele vai ser definido para string na saida
        public override string ToString()
        {
            // String builder -> monta uma string de forma eficiente e retorna o resultado tipo string
            // Ajuda no caso de ter muitos objetos ligados a classe... e no caso não tem de fazer um por um
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Title);
            sb.AppendLine(Likes + " Likes - " + Moment);
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");

            // Parte dos comentários - Percorrer a lista de comentários
            foreach (Comment Com in Comments)
            {
                sb.AppendLine(Com.Text);
            }

            return sb.ToString();                
        }
    }
}
