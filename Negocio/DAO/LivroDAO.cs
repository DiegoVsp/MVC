using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.MODEL;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace Negocio.DAO
{
    class LivroDAO
    {
        public void Insert(Livro livro)
        {

            try
            {


                MySqlCommand comando = new MySqlCommand();//instanciar MyqSqlCommand para poder entrar com uma string mysql de insert
                comando.CommandType = CommandType.Text;//CommandType - Informa que o comando é do tipo texto
                comando.CommandText = "Insert into Livro(titulo,datapublicacao,autorId) values(@titulo, @datapublicacao, @autorId)";

                comando.Parameters.AddWithValue("@titulo", livro.Titulo);
                comando.Parameters.AddWithValue("@datapublicacao", livro.Datapublicacao);
                comando.Parameters.AddWithValue("@autorId", livro.Autor.AutorId);//Detalhe AutorID esta na classe Autor

                ConexaoBanco.CRUD(comando);//Esta sendo  enviado o comando para  o metodo CRUD
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel se conectar" + ex.Message);
            }

        }
        public void Update(Livro livro)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Update Livro set titulo=@titulo,datapublicacao=@datapublicacao,autorId=@autorId where livroId=@livroId";
                                 
            comando.Parameters.AddWithValue("@titulo", livro.Titulo);
            comando.Parameters.AddWithValue("@datapublicacao", livro.Datapublicacao);
            comando.Parameters.AddWithValue("@autorId", livro.Autor.AutorId);
            comando.Parameters.AddWithValue("@livroId", livro.LivroId);

            ConexaoBanco.CRUD(comando);
        }

        public void Delete(Livro livro)
        {
            MySqlCommand comando = new MySqlCommand();

            comando.CommandType = CommandType.Text;
            comando.CommandText = "Delete from livro where livroId=@livroId";

            comando.Parameters.AddWithValue("@livroId", livro.LivroId);

            ConexaoBanco.CRUD(comando);
        }

        public Livro BuscarPorId(int id)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from livro where livroId=@id";

            comando.Parameters.AddWithValue("@id", id);

            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            Livro livro = new Livro();
            AutorDAO autorDAO = new AutorDAO();
            if (dr.HasRows)
            {
                //Preenche o objeto
                dr.Read();
                livro.Titulo = (string)dr["titulo"]; // tem que fazer um cast para string pois dr é um objeto e Titulo é um string
                livro.LivroId = (int)dr["livroId"];
                livro.Datapublicacao = (DateTime)dr["datapublicacao"]; //aqui
                //Busco o autorId atraves do metodo BuscarPorId na classe AutorDAO
                livro.Autor = autorDAO.BuscarId((int)dr["autorId"]);

            }
            else
            {
                //Zera o objeto
                livro.LivroId = 0;
                livro.Titulo = "";

            }
            return livro;
        }

        public IList<Livro> BuscarPorLivro (string titulo)
        {
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Select * from livro where titulo like @titulo";

                comando.Parameters.AddWithValue("@titulo", "%" + titulo + "%");

                MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

                //Instancia uma nova lista de livro
                IList<Livro> livros = new List<Livro>();//instancia uma nova lista de autores

                //se tiver linhas em dr
                if (dr.HasRows)
                {
                    //enquanto estiver lendo o dr faça
                    while (dr.Read())
                    {
                        //instancia livro dentro do looping para ser criado um objeto para cada
                        // elemento  da lista
                        Livro livro = new Livro();
                        livro.Titulo = (string)dr["titulo"];
                        livro.Datapublicacao = (DateTime)dr["datapublicacao"];
                        livro.LivroId = (int)dr["livroId"];
                        livro.Autor.AutorId= (int)dr["autorId"];

                        livros.Add(livro); // adiciona na lista livros os valores encontrados em autor
                    }
                }
                else
                {
                    livros = null;
                }
                return livros;

            }
        }


    }
}
