namespace Negocio
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpAutor = new System.Windows.Forms.GroupBox();
            this.btnBuscaNome = new System.Windows.Forms.Button();
            this.btnBuscaId = new System.Windows.Forms.Button();
            this.txtNacionalidade = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAutorId = new System.Windows.Forms.TextBox();
            this.lblNacionalidade = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblAutorId = new System.Windows.Forms.Label();
            this.grpLivro = new System.Windows.Forms.GroupBox();
            this.btnBuscaNomeL = new System.Windows.Forms.Button();
            this.btnBuscaIdL = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblLivroId = new System.Windows.Forms.Label();
            this.lblLivroAutorId = new System.Windows.Forms.Label();
            this.txtLivroAutorId = new System.Windows.Forms.TextBox();
            this.txtDataPublicacao = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtLivroId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnGravarAutor = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBuscarLivro = new System.Windows.Forms.Button();
            this.btnExcluirLivro = new System.Windows.Forms.Button();
            this.btnEditarLivro = new System.Windows.Forms.Button();
            this.btnGravarLivro = new System.Windows.Forms.Button();
            this.btnNovoLivro = new System.Windows.Forms.Button();
            this.grpAutor.SuspendLayout();
            this.grpLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAutor
            // 
            this.grpAutor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpAutor.Controls.Add(this.btnBuscaNome);
            this.grpAutor.Controls.Add(this.btnBuscaId);
            this.grpAutor.Controls.Add(this.txtNacionalidade);
            this.grpAutor.Controls.Add(this.txtNome);
            this.grpAutor.Controls.Add(this.txtAutorId);
            this.grpAutor.Controls.Add(this.lblNacionalidade);
            this.grpAutor.Controls.Add(this.lblNome);
            this.grpAutor.Controls.Add(this.lblAutorId);
            this.grpAutor.Location = new System.Drawing.Point(13, 12);
            this.grpAutor.Name = "grpAutor";
            this.grpAutor.Size = new System.Drawing.Size(310, 118);
            this.grpAutor.TabIndex = 0;
            this.grpAutor.TabStop = false;
            this.grpAutor.Text = "Autor";
            // 
            // btnBuscaNome
            // 
            this.btnBuscaNome.Location = new System.Drawing.Point(250, 19);
            this.btnBuscaNome.Name = "btnBuscaNome";
            this.btnBuscaNome.Size = new System.Drawing.Size(49, 23);
            this.btnBuscaNome.TabIndex = 7;
            this.btnBuscaNome.Text = "Nome";
            this.btnBuscaNome.UseVisualStyleBackColor = true;
            // 
            // btnBuscaId
            // 
            this.btnBuscaId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscaId.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnBuscaId.Location = new System.Drawing.Point(195, 19);
            this.btnBuscaId.Name = "btnBuscaId";
            this.btnBuscaId.Size = new System.Drawing.Size(49, 24);
            this.btnBuscaId.TabIndex = 6;
            this.btnBuscaId.Text = "Id";
            this.btnBuscaId.UseVisualStyleBackColor = true;
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.Location = new System.Drawing.Point(108, 81);
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Size = new System.Drawing.Size(170, 20);
            this.txtNacionalidade.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(108, 52);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(170, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtAutorId
            // 
            this.txtAutorId.Location = new System.Drawing.Point(108, 21);
            this.txtAutorId.Name = "txtAutorId";
            this.txtAutorId.Size = new System.Drawing.Size(80, 20);
            this.txtAutorId.TabIndex = 3;
            // 
            // lblNacionalidade
            // 
            this.lblNacionalidade.AutoSize = true;
            this.lblNacionalidade.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacionalidade.Location = new System.Drawing.Point(18, 84);
            this.lblNacionalidade.Name = "lblNacionalidade";
            this.lblNacionalidade.Size = new System.Drawing.Size(77, 14);
            this.lblNacionalidade.TabIndex = 2;
            this.lblNacionalidade.Text = "Nacionalidade:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(55, 55);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 14);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome: ";
            // 
            // lblAutorId
            // 
            this.lblAutorId.AutoSize = true;
            this.lblAutorId.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutorId.Location = new System.Drawing.Point(49, 28);
            this.lblAutorId.Name = "lblAutorId";
            this.lblAutorId.Size = new System.Drawing.Size(48, 14);
            this.lblAutorId.TabIndex = 0;
            this.lblAutorId.Text = "Autor Id:";
            // 
            // grpLivro
            // 
            this.grpLivro.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpLivro.Controls.Add(this.btnBuscaNomeL);
            this.grpLivro.Controls.Add(this.btnBuscaIdL);
            this.grpLivro.Controls.Add(this.lblData);
            this.grpLivro.Controls.Add(this.lblTitulo);
            this.grpLivro.Controls.Add(this.lblLivroId);
            this.grpLivro.Controls.Add(this.lblLivroAutorId);
            this.grpLivro.Controls.Add(this.txtLivroAutorId);
            this.grpLivro.Controls.Add(this.txtDataPublicacao);
            this.grpLivro.Controls.Add(this.txtTitulo);
            this.grpLivro.Controls.Add(this.txtLivroId);
            this.grpLivro.Location = new System.Drawing.Point(13, 167);
            this.grpLivro.Name = "grpLivro";
            this.grpLivro.Size = new System.Drawing.Size(310, 139);
            this.grpLivro.TabIndex = 1;
            this.grpLivro.TabStop = false;
            this.grpLivro.Text = "Livro";
            // 
            // btnBuscaNomeL
            // 
            this.btnBuscaNomeL.Location = new System.Drawing.Point(250, 15);
            this.btnBuscaNomeL.Name = "btnBuscaNomeL";
            this.btnBuscaNomeL.Size = new System.Drawing.Size(49, 23);
            this.btnBuscaNomeL.TabIndex = 9;
            this.btnBuscaNomeL.Text = "Nome";
            this.btnBuscaNomeL.UseVisualStyleBackColor = true;
            // 
            // btnBuscaIdL
            // 
            this.btnBuscaIdL.Location = new System.Drawing.Point(195, 16);
            this.btnBuscaIdL.Name = "btnBuscaIdL";
            this.btnBuscaIdL.Size = new System.Drawing.Size(49, 23);
            this.btnBuscaIdL.TabIndex = 8;
            this.btnBuscaIdL.Text = "Id";
            this.btnBuscaIdL.UseVisualStyleBackColor = true;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(7, 83);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(87, 14);
            this.lblData.TabIndex = 11;
            this.lblData.Text = "Data Publicação:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(60, 53);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 14);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Titulo:";
            // 
            // lblLivroId
            // 
            this.lblLivroId.AutoSize = true;
            this.lblLivroId.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivroId.Location = new System.Drawing.Point(55, 24);
            this.lblLivroId.Name = "lblLivroId";
            this.lblLivroId.Size = new System.Drawing.Size(45, 14);
            this.lblLivroId.TabIndex = 9;
            this.lblLivroId.Text = "Livro Id:";
            // 
            // lblLivroAutorId
            // 
            this.lblLivroAutorId.AutoSize = true;
            this.lblLivroAutorId.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivroAutorId.Location = new System.Drawing.Point(49, 113);
            this.lblLivroAutorId.Name = "lblLivroAutorId";
            this.lblLivroAutorId.Size = new System.Drawing.Size(48, 14);
            this.lblLivroAutorId.TabIndex = 8;
            this.lblLivroAutorId.Text = "Autor Id:";
            // 
            // txtLivroAutorId
            // 
            this.txtLivroAutorId.Location = new System.Drawing.Point(108, 110);
            this.txtLivroAutorId.Name = "txtLivroAutorId";
            this.txtLivroAutorId.Size = new System.Drawing.Size(80, 20);
            this.txtLivroAutorId.TabIndex = 7;
            // 
            // txtDataPublicacao
            // 
            this.txtDataPublicacao.Location = new System.Drawing.Point(108, 81);
            this.txtDataPublicacao.Name = "txtDataPublicacao";
            this.txtDataPublicacao.Size = new System.Drawing.Size(80, 20);
            this.txtDataPublicacao.TabIndex = 6;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(108, 50);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(170, 20);
            this.txtTitulo.TabIndex = 5;
            // 
            // txtLivroId
            // 
            this.txtLivroId.Location = new System.Drawing.Point(108, 20);
            this.txtLivroId.Name = "txtLivroId";
            this.txtLivroId.Size = new System.Drawing.Size(80, 20);
            this.txtLivroId.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(351, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(359, 281);
            this.dataGridView1.TabIndex = 2;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(348, 12);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(50, 13);
            this.lblPesquisa.TabIndex = 3;
            this.lblPesquisa.Text = "Pesquisa";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(12, 138);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(53, 23);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // btnGravarAutor
            // 
            this.btnGravarAutor.Location = new System.Drawing.Point(71, 138);
            this.btnGravarAutor.Name = "btnGravarAutor";
            this.btnGravarAutor.Size = new System.Drawing.Size(53, 23);
            this.btnGravarAutor.TabIndex = 5;
            this.btnGravarAutor.Text = "Gravar";
            this.btnGravarAutor.UseVisualStyleBackColor = true;
            this.btnGravarAutor.Click += new System.EventHandler(this.BtnGravarAutor_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(130, 138);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(53, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(194, 138);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(63, 23);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(263, 138);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(60, 23);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // btnBuscarLivro
            // 
            this.btnBuscarLivro.Location = new System.Drawing.Point(263, 312);
            this.btnBuscarLivro.Name = "btnBuscarLivro";
            this.btnBuscarLivro.Size = new System.Drawing.Size(60, 23);
            this.btnBuscarLivro.TabIndex = 13;
            this.btnBuscarLivro.Text = "Buscar";
            this.btnBuscarLivro.UseVisualStyleBackColor = true;
            // 
            // btnExcluirLivro
            // 
            this.btnExcluirLivro.Location = new System.Drawing.Point(194, 312);
            this.btnExcluirLivro.Name = "btnExcluirLivro";
            this.btnExcluirLivro.Size = new System.Drawing.Size(60, 23);
            this.btnExcluirLivro.TabIndex = 12;
            this.btnExcluirLivro.Text = "Excluir";
            this.btnExcluirLivro.UseVisualStyleBackColor = true;
            // 
            // btnEditarLivro
            // 
            this.btnEditarLivro.Location = new System.Drawing.Point(135, 312);
            this.btnEditarLivro.Name = "btnEditarLivro";
            this.btnEditarLivro.Size = new System.Drawing.Size(60, 23);
            this.btnEditarLivro.TabIndex = 11;
            this.btnEditarLivro.Text = "Editar";
            this.btnEditarLivro.UseVisualStyleBackColor = true;
            // 
            // btnGravarLivro
            // 
            this.btnGravarLivro.Location = new System.Drawing.Point(76, 312);
            this.btnGravarLivro.Name = "btnGravarLivro";
            this.btnGravarLivro.Size = new System.Drawing.Size(60, 23);
            this.btnGravarLivro.TabIndex = 10;
            this.btnGravarLivro.Text = "Gravar";
            this.btnGravarLivro.UseVisualStyleBackColor = true;
            // 
            // btnNovoLivro
            // 
            this.btnNovoLivro.Location = new System.Drawing.Point(13, 312);
            this.btnNovoLivro.Name = "btnNovoLivro";
            this.btnNovoLivro.Size = new System.Drawing.Size(60, 23);
            this.btnNovoLivro.TabIndex = 9;
            this.btnNovoLivro.Text = "Novo";
            this.btnNovoLivro.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 342);
            this.Controls.Add(this.btnBuscarLivro);
            this.Controls.Add(this.btnExcluirLivro);
            this.Controls.Add(this.btnEditarLivro);
            this.Controls.Add(this.btnGravarLivro);
            this.Controls.Add(this.btnNovoLivro);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGravarAutor);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpLivro);
            this.Controls.Add(this.grpAutor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAutor.ResumeLayout(false);
            this.grpAutor.PerformLayout();
            this.grpLivro.ResumeLayout(false);
            this.grpLivro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAutor;
        private System.Windows.Forms.GroupBox grpLivro;
        private System.Windows.Forms.Label lblNacionalidade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblAutorId;
        private System.Windows.Forms.TextBox txtNacionalidade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtAutorId;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblLivroId;
        private System.Windows.Forms.Label lblLivroAutorId;
        private System.Windows.Forms.TextBox txtLivroAutorId;
        private System.Windows.Forms.TextBox txtDataPublicacao;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtLivroId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.Button btnBuscaNome;
        private System.Windows.Forms.Button btnBuscaId;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnGravarAutor;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBuscarLivro;
        private System.Windows.Forms.Button btnExcluirLivro;
        private System.Windows.Forms.Button btnEditarLivro;
        private System.Windows.Forms.Button btnGravarLivro;
        private System.Windows.Forms.Button btnNovoLivro;
        private System.Windows.Forms.Button btnBuscaNomeL;
        private System.Windows.Forms.Button btnBuscaIdL;
    }
}

