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
    }
}
