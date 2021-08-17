using System;
using System.Collections.Generic;
using System.Text;

namespace PostsAndComments.Entities
{
    class Comment
    {
        public string Text { get; set; }// Classe Comentário com atributos string "texto"

        //Construtor padrão
        public Comment()
        {
        }
        //Construtor com os parametros "Text"
        public Comment(string text)
        {
            Text = text;
        }
    }
}
