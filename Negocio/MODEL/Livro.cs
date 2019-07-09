using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.MODEL
{
    public class Livro
    {
        private int livroId;
        private string titulo;
        private DateTime datapublicacao;
        private Autor autor; 

        public Livro()
        {
            autor = new Autor();// foi  criado autor do tipo autor;
                                //no momento que o livro for instanciado o autor tbm sera instanciado
        }
        public int LivroId { get => livroId; set => livroId = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public DateTime Datapublicacao { get => datapublicacao; set => datapublicacao = value; }
        public Autor Autor { get => autor; set => autor = value; }

        public override string ToString()
        {
            return autor.ToString();
        }
    }
}
