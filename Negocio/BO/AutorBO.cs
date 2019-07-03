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
    }
}
