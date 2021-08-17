using System;
using PostsAndComments.Entities;

namespace PostsAndComments
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment ("Have a nice trip");//Adiciona o conteúdo entre parenteses para a variavel "c1" refente a classe "Comment"
            Comment c2 = new Comment ("Wow that's awesome!");//Adiciona o conteúdo entre parenteses para a variavel "c1" refente a classe "Comment"

            Post p1 = new Post( //instancia a classe Post
                DateTime.Parse("21/06/2018 13:05:44"),//adiciona a string na variavel "p1"
                "Travelling to New Zealand",
                "I'm going to visit this wonderful country!",
                12);
            p1.AddComment(c1); //Adiciona o comentário 1 ao Post
            p1.AddComment(c2); //Adiciona o comentário 2 ao Post

            Comment c3 = new Comment("Good Night"); //Adiciona o conteúdo entre parenteses para a variavel "c1" refente a classe "Comment"
            Comment c4 = new Comment("May the Force be with you");//Adiciona o conteúdo entre parenteses para a variavel "c1" refente a classe "Comment"

            Post p2 = new Post(//instancia a classe Post
                DateTime.Parse("28/07/2018 23:14:19"),//adiciona a string na variavel "p2"
                "Good night guys",
                "See you tomorrow",
                5);

            p2.AddComment(c3);//Adiciona o comentário 3 ao Post
            p2.AddComment(c4);//Adiciona o comentário 4 ao Post

            Console.WriteLine(p1);//escreve na tela o post 1
            Console.WriteLine(p2);//escreve na tela o post 2
        }
    }
}
