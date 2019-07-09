using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.MODEL;
using Negocio.DAO;

namespace Negocio.BO
{
    class LivroBO
    {
        public void Inserir(Livro livro)
        {
            LivroDAO livroDao = new LivroDAO();
            // Regra só será gravada se o autor for preenchido, se for nulo não poderá

            if (livro.Autor != null)
            {
                if (livro.LivroId != 0)
                {
                    livroDao.Update(livro);
                }
                else
                {
                    livroDao.Insert(livro);
                }
            }

        }

        public void Editar(Livro livro)
        {
            LivroDAO livroDao = new LivroDAO();
            if ((livro.Titulo != "") && (livro.Autor.AutorId != 0))
            {
                livroDao.Update(livro);
            }
        }

        public void DeletarLivro(Livro livro)
        {
            LivroDAO livroDAO = new LivroDAO();
            if (livro.LivroId != 0)
            {
                livroDAO.Delete(livro);
            }
        }

        public void BuscarPorId(Livro livro)
        {
            LivroDAO livroDAO = new LivroDAO();
            if(livro.LivroId >0)
            {
                var livroTemp = livroDAO.BuscarPorId(livro.LivroId);

                livro.Titulo = livroTemp.Titulo;
                livro.Datapublicacao = livroTemp.Datapublicacao;
                livro.Autor.AutorId = livroTemp.Autor.AutorId;
            }
        }

        public IList<Livro> BuscarPorTiTulo(Livro livro)
        {
            LivroDAO livroDAO = new LivroDAO();
            if (livro.Titulo != "")
            {
                IList<Livro> livroTemp = livroDAO.BuscarPorLivro(livro.Titulo);
                return livroTemp;

            }
            else
            {
                return null;
            }
        }
    }
}


