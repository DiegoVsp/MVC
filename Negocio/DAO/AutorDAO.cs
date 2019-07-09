using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Negocio.MODEL;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Negocio.DAO

{
    class AutorDAO
    {
        public void Insert(Autor autor)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Insert into Autor(nome,nacionalidade) values(@nome,@nacionalidade)";

                comando.Parameters.AddWithValue("@nome", autor.Nome);
                comando.Parameters.AddWithValue("@nacionalidade", autor.Nacionalidade);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel se conectar" + ex.Message);
            }
        }
        public void Update(Autor autor)
        {

            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Update Autor set nome=@nome,nacionalidade=@nacionalidade where autorId=@autorId";

            comando.Parameters.AddWithValue("@autorId", autor.AutorId);
            comando.Parameters.AddWithValue("@nome", autor.Nome);
            comando.Parameters.AddWithValue("@nacionalidade", autor.Nacionalidade);

            ConexaoBanco.CRUD(comando);


        }
        public void delete(Autor autor)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "delete from Autor where autorId=@autorId";

            comando.Parameters.AddWithValue("autorId", autor.AutorId);

            ConexaoBanco.CRUD(comando);
        }

        public Autor BuscarId(int id)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from Autor where autorId=@id";

            comando.Parameters.AddWithValue("@id", id);

            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            Autor autor = new Autor();
            if (dr.HasRows)
            {
                dr.Read();

                autor.AutorId=(int)dr["autorId"];
                autor.Nome = (string)dr["nome"];
                autor.Nacionalidade = (string)dr["nacionalidade"];
            }
            else
            {
                autor.AutorId = 0;
                autor.Nome = "";
                autor.Nacionalidade = "";
            }
            return autor;
        }

        public IList<Autor> BuscarPorAutor(string nome)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from autor where nome like @nome";

            comando.Parameters.AddWithValue("@nome", "%" + nome + "%");

            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            //Instancia uma nova lista de autor
            IList<Autor> autores = new List<Autor>();//instancia uma nova lista de autores

            //se tiver linhas em dr
            if (dr.HasRows)
            {
                //enquanto estiver lendo o dr faça
                while (dr.Read())
                {
                    //instancia autor dentro do looping para ser criado um objeto para cada
                    // elemento  da lista
                    Autor autor = new Autor();
                    autor.Nome = (string)dr["nome"];
                    autor.Nacionalidade = (string)dr["nacionalidade"];
                    autor.AutorId = (int)dr["autorId"];

                    autores.Add(autor); // adiciona na lista autores os valores encontrados em autor
                }
            }
            else
            {
                autores = null;
            }
            return autores;

        }
    }
}
