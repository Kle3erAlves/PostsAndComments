using System;
using System.Collections.Generic;
using System.Text;

namespace PostsAndComments.Entities
{
    class Post //Classe "Post"
    {
        public DateTime Moment { get; set; } //declaração de propriedade DateTime Moment para registrar a hora do post
        public string Title { get; set; }//declaração de propriedade Title para registrar o titulo do post
        public string Content { get; set; }//declaração de propriedade Content para registrar o conteudo
        public int Likes { get; set; }//declaração de propriedade Likes para registrar as curtidas
        public List<Comment> Comments { get; set; } = new List<Comment>();//Declaração de lista de comentarios 
        //Construtor padrão
        public Post()
        {
        }
        //Construtor post
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }
        //Metodo Adicionar
        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        //Metodo Remover
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }
       //Metodo StringBuilder
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM//yyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");

            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }

            return sb.ToString();
        }


    }
}
