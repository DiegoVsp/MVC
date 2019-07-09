using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.MODEL;
using Negocio.DAO;


namespace Negocio.BO
{
    public class AutorBO
    {
        public void InserirAutor(Autor autor)
        {
            AutorDAO autorDAO = new AutorDAO();
            if(autor.Nome != "")
            {
                autorDAO.Insert(autor);
            }
        }

        public void UpdateAutor(Autor autor)
        {
            AutorDAO autorDAO = new AutorDAO();
            if(autor.Nome != "")
            {
                autorDAO.Update(autor);
            }
        }
        public void DeletarAutor(Autor autor)
        {
            AutorDAO autorDAO = new AutorDAO();
            if (autor.AutorId != 0)
            {
                autorDAO.delete(autor);
            }
        }

        public void BuscarAutorID(Autor autor)
        {
            AutorDAO autorDAO = new AutorDAO();

            if (autor.AutorId >0)
            {
                var autorTemp = autorDAO.BuscarId(autor.AutorId);

                autor.Nome = autorTemp.Nome;
                autor.Nacionalidade = autorTemp.Nacionalidade;
            }
        }

        public IList<Autor> BuscarPorNome(Autor autor)
        {
            AutorDAO autorDAO = new AutorDAO();
            if (autor.Nome != "")
            {
                IList<Autor> autorTemp = autorDAO.BuscarPorAutor(autor.Nome);
                return autorTemp;

            }
            else
            {
                return null;
            }
        }
    }
}
