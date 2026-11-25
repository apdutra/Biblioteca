using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Application.Services;
using Biblioteca.Domain.Entities;


namespace Biblioteca.Presentation
{
    public partial class FormAutor : Form
    {
        private AutorService? _autorService;
        private Autor? _autorEmEdicao;
        public FormAutor()
        {
            InitializeComponent();
        }

        public FormAutor(AutorService autorService)
        {
            InitializeComponent();
            _autorService = autorService;
        }
        public FormAutor(AutorService autorService, Autor autor)
        {
            InitializeComponent();

            _autorService = autorService;
            _autorEmEdicao = autor;
        }

        private void FormAutor_Load(object sender, EventArgs e)
        {
            if (_autorEmEdicao != null)
            {
                txtNome.Text = _autorEmEdicao.Nome;
                txtNacionalidade.Text = _autorEmEdicao.Nacionalidade;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Verifica se os campos foram preenchidos
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtNacionalidade.Text))
            {
                MessageBox.Show(
                    "Preencha todos os campos!",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (_autorEmEdicao == null)
            {
                // Cria um novo autor
                Autor autor = new Autor
                {
                    Nome = txtNome.Text.Trim(),
                    Nacionalidade = txtNacionalidade.Text.Trim()
                };

                // Salva o novo autor
                _autorService!.Adicionar(autor);
            }
            else
            {
                // Atualiza os dados do autor existente
                _autorEmEdicao.Nome = txtNome.Text.Trim();
                _autorEmEdicao.Nacionalidade = txtNacionalidade.Text.Trim();

                // Atualiza o autor no banco de dados
                _autorService!.Atualizar(_autorEmEdicao);
            }

            // Exibe mensagem de sucesso
            if (_autorEmEdicao == null)
            {
                MessageBox.Show(
                    "Autor cadastrado com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Autor atualizado com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            if (_autorEmEdicao == null)
            {
                // Limpa os campos para um novo cadastro
                txtNome.Clear();
                txtNacionalidade.Clear();

                // Coloca o cursor no campo Nome
                txtNome.Focus();
            }
            else
            {
                // Fecha o formulário após editar
                this.Close();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtNacionalidade.Clear();

            txtNome.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
