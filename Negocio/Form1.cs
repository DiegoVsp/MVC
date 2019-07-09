using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.MODEL;
using Negocio.BO;

namespace Negocio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            grpAutor.Enabled = true;
            txtAutorId.Enabled = false;
            btnBuscaId.Visible = false;
            btnBuscaNome.Visible = false;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            grpAutor.Enabled = false;
            grpLivro.Enabled = false;
            btnBuscaId.Visible = false;
            btnBuscaNome.Visible = false;
        }

        private void BtnGravarAutor_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor();
            AutorBO autorBO = new AutorBO();

            autor.Nome = txtNome.Text.ToUpper();
            autor.Nacionalidade = txtNacionalidade.Text.ToUpper();

            autorBO.InserirAutor(autor);
            MessageBox.Show("Autor Cadastrado com Sucesso!");

            grpAutor.Enabled = false;
            txtNome.Clear();
            txtNacionalidade.Clear();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            txtAutorId.Enabled = true;
            grpAutor.Enabled = true;
            btnBuscaId.Visible = true;
            btnBuscaNome.Visible = true;
            grpLivro.Enabled = false;
            btnBuscaIdL.Visible = false;
            btnBuscaNomeL.Visible = false;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].DataGridView.Columns.Clear();
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor();
            AutorBO autorBO = new AutorBO();

            autor.AutorId = Convert.ToInt16(txtAutorId.Text);
            autor.Nome = txtNome.Text;
            autor.Nacionalidade = txtNacionalidade.Text;

            autorBO.UpdateAutor(autor);
            MessageBox.Show("Update realizado com sucesso!!");
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor();
            AutorBO autorBO = new AutorBO();

            autor.AutorId = Convert.ToInt16(txtAutorId.Text);
            try
            {
                autorBO.DeletarAutor(autor);
                MessageBox.Show("Autor deletado com sucesso!!");
            }
            catch
            {
                MessageBox.Show("Não foi possivel deletar o autor!", "ATENÇÃO!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnBuscaId_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor();
            AutorBO autorBO = new AutorBO();
            try
            {
                autor.AutorId = Convert.ToInt16(txtAutorId.Text);
                autorBO.BuscarAutorID(autor);

                if (autor.Nome == "")
                {
                    MessageBox.Show("Autor não encontrado");

                    txtNome.Clear();
                    txtNacionalidade.Clear();
                    txtAutorId.Clear();


                }
                else
                {
                    txtNome.Text = autor.Nome;
                    txtNacionalidade.Text = autor.Nacionalidade;

                }
            }
            catch
            {
                MessageBox.Show("Preencha os dados corretamente");
            }
        }

        private void BtnGravarLivro_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro();
            LivroBO livroBO = new LivroBO();
            try
            {
                livro.Titulo = txtTitulo.Text.ToUpper();
                livro.Datapublicacao = Convert.ToDateTime(txtDataPublicacao.Text);
                livro.Autor.AutorId = Convert.ToInt32(txtLivroAutorId.Text);

                livroBO.Inserir(livro);
                MessageBox.Show("Livro Cadastrado com Sucesso!");

                grpLivro.Enabled = false;
                txtTitulo.Clear();
                //txtDataPublicacao.Clear();
                txtLivroAutorId.Clear();
            }
            catch
            {
                MessageBox.Show("Autor não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void BtnNovoLivro_Click(object sender, EventArgs e)
        {
            grpLivro.Enabled = true;
            txtLivroId.Enabled = false;
            btnBuscaIdL.Visible = false;
            btnBuscaNomeL.Visible = false;
        }

        private void BtnEditarLivro_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro();
            LivroBO livroBO = new LivroBO();

            livro.LivroId = Convert.ToInt16(txtLivroId.Text);
            livro.Titulo = txtTitulo.Text.ToUpper();
            livro.Datapublicacao = Convert.ToDateTime(txtDataPublicacao.Text);
            livro.Autor.AutorId = Convert.ToInt16(txtLivroAutorId.Text);

            livroBO.Editar(livro);
            MessageBox.Show("Update realizado com sucesso!!");
        }

        private void BtnBuscarLivro_Click(object sender, EventArgs e)
        {
            grpAutor.Enabled = false;
            txtLivroId.Enabled = true;
            grpLivro.Enabled = true;
            btnBuscaIdL.Visible = true;
            btnBuscaNomeL.Visible = true;
            btnEditarLivro.Enabled = true;
            btnBuscaId.Visible = false;
            btnBuscaNome.Visible = false;



            for (int i = 0; i< dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].DataGridView.Columns.Clear();
            }
        }

        private void BtnExcluirLivro_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro();
            LivroBO livroBO = new LivroBO();
            try
            {
                livro.LivroId = Convert.ToInt16(txtLivroId.Text);
                livro.Titulo = txtTitulo.Text.ToUpper();
                livro.Datapublicacao = Convert.ToDateTime(txtDataPublicacao.Text);
                livro.Autor.AutorId = Convert.ToInt16(txtLivroAutorId.Text);

                livroBO.DeletarLivro(livro);
                MessageBox.Show("Livro Deletado com sucesso!");
            }
            catch
            {
                MessageBox.Show("Livro não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnBuscaIdL_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro();
            LivroBO livroBO = new LivroBO();


            livro.LivroId = Convert.ToInt16(txtLivroId.Text);
            livroBO.BuscarPorId(livro);

            if (livro.Titulo == "")
            {
                MessageBox.Show("Livro Não encontrado!");

                txtLivroId.Clear();
            }
            else
            {
                txtTitulo.Text = livro.Titulo;
                txtDataPublicacao.Text = Convert.ToString(livro.Datapublicacao);
                txtLivroAutorId.Text = Convert.ToString(livro.Autor.AutorId);
            }

        }

        private void BtnBuscaNome_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor();
            AutorBO autorBO = new AutorBO();

            try
            {
                autor.Nome = txtNome.Text;
                dataGridView1.DataSource = autorBO.BuscarPorNome(autor);
            }
            catch
            {
                MessageBox.Show("Preencha os dados corretamente!!");
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linhaselecionada;
            linhaselecionada = dataGridView1.CurrentRow;
            if (grpAutor.Enabled == true)
            {
                txtAutorId.Text = linhaselecionada.Cells[0].Value.ToString();
                txtNome.Text = linhaselecionada.Cells[1].Value.ToString();
                txtNacionalidade.Text = linhaselecionada.Cells[2].Value.ToString();
            }
            else
            {
                if (grpLivro.Enabled == true)
                {
                    txtLivroId.Text = linhaselecionada.Cells[0].Value.ToString();
                    txtTitulo.Text = linhaselecionada.Cells[1].Value.ToString();
                    txtDataPublicacao.Text = linhaselecionada.Cells[2].Value.ToString();
                    txtLivroAutorId.Text = linhaselecionada.Cells[3].Value.ToString();
                }
            }
        }

        private void BtnBuscaNomeL_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro();
            LivroBO livroBO = new LivroBO();

            try
            {
                livro.Titulo = txtTitulo.Text;
                dataGridView1.DataSource = livroBO.BuscarPorTiTulo(livro);
               
            }
            catch
            {
                MessageBox.Show("Preencha os dados corretamente!!");
            }
        }
    }
}