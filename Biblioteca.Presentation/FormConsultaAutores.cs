using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Application.Services;
using Biblioteca.Domain.Entities;
using System.Linq;

namespace Biblioteca.Presentation
{
    public partial class FormConsultaAutores : Form
    {
        private AutorService? _autorService;
        public FormConsultaAutores()
        {
            InitializeComponent();
        }

        public FormConsultaAutores(AutorService autorService)
        {
            InitializeComponent();
            _autorService = autorService;
        }

        private void FormConsultaAutores_Load(object sender, EventArgs e)
        {
            if (_autorService is null)
                return;

            dgvAutores.AutoGenerateColumns = true;

            dgvAutores.DataSource = _autorService.ListarTodos();
            dgvAutores.ClearSelection();

            // Oculta a coluna Livros
            dgvAutores.Columns["Livros"].Visible = false;

            // Altera os títulos das colunas
            dgvAutores.Columns["IdAutor"].HeaderText = "Código";
            dgvAutores.Columns["Nome"].HeaderText = "Nome do Autor";
            dgvAutores.Columns["Nacionalidade"].HeaderText = "Nacionalidade";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (_autorService is null)
                return;

            string pesquisa = txtPesquisar.Text.Trim();

            var autores = _autorService.ListarTodos();

            var autoresFiltrados = autores
                .Where(a => a.Nome.Contains(pesquisa, StringComparison.OrdinalIgnoreCase))
                .ToList();

            dgvAutores.DataSource = autoresFiltrados;
        }

        private void btnLimparPesquisa_Click(object sender, EventArgs e)
        {
            txtPesquisar.Clear();

            dgvAutores.DataSource = _autorService!.ListarTodos();

            txtPesquisar.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvAutores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um autor para editar!",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Autor autorSelecionado = (Autor)dgvAutores.SelectedRows[0].DataBoundItem;

            FormAutor formAutor = new FormAutor(_autorService!, autorSelecionado);

            formAutor.ShowDialog(this);

            // Atualiza a tabela após fechar o formulário
            dgvAutores.DataSource = _autorService!.ListarTodos();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvAutores.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Selecione um autor para excluir!",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Autor autorSelecionado = (Autor)dgvAutores.SelectedRows[0].DataBoundItem;

            DialogResult resposta = MessageBox.Show(
                $"Deseja realmente excluir o autor {autorSelecionado.Nome}?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                _autorService!.Excluir(autorSelecionado.IdAutor);

                dgvAutores.DataSource = _autorService!.ListarTodos();

                MessageBox.Show(
                    "Autor excluído com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}

