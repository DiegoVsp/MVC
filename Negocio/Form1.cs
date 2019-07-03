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

            autor.Nome = txtNome.Text;
            autor.Nacionalidade = txtNacionalidade.Text;

            autorBO.InserirAutor(autor);
            MessageBox.Show("Autor Cadastrado com Sucesso!");

            grpAutor.Enabled = false;
            txtNome.Clear();
            txtNacionalidade.Clear();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            txtAutorId.Enabled = true;
            grpAutor.Enabled=true;
            btnBuscaId.Visible = true;
            btnBuscaNome.Visible = true;
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
    }
}
