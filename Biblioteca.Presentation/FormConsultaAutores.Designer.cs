namespace Biblioteca.Presentation
{
    partial class FormConsultaAutores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dgvAutores = new DataGridView();
            btnVoltar = new Button();
            lblPesquisar = new Label();
            txtPesquisar = new TextBox();
            btnPesquisar = new Button();
            btnLimparPesquisa = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAutores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(274, 9);
            label1.Name = "label1";
            label1.Size = new Size(287, 38);
            label1.TabIndex = 0;
            label1.Text = "Autores Cadastrados";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvAutores
            // 
            dgvAutores.AllowUserToAddRows = false;
            dgvAutores.AllowUserToDeleteRows = false;
            dgvAutores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAutores.Location = new Point(43, 109);
            dgvAutores.MultiSelect = false;
            dgvAutores.Name = "dgvAutores";
            dgvAutores.ReadOnly = true;
            dgvAutores.RowHeadersWidth = 51;
            dgvAutores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAutores.Size = new Size(775, 306);
            dgvAutores.TabIndex = 1;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = SystemColors.HotTrack;
            btnVoltar.ForeColor = SystemColors.ButtonHighlight;
            btnVoltar.Location = new Point(743, 438);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 35);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(43, 69);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(114, 20);
            lblPesquisar.TabIndex = 3;
            lblPesquisar.Text = "Pesquisar Autor:";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(163, 66);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(447, 27);
            txtPesquisar.TabIndex = 4;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = SystemColors.HotTrack;
            btnPesquisar.ForeColor = SystemColors.ButtonHighlight;
            btnPesquisar.Location = new Point(616, 61);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(100, 42);
            btnPesquisar.TabIndex = 5;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnLimparPesquisa
            // 
            btnLimparPesquisa.BackColor = SystemColors.ControlLight;
            btnLimparPesquisa.ForeColor = SystemColors.ActiveCaptionText;
            btnLimparPesquisa.Location = new Point(718, 61);
            btnLimparPesquisa.Name = "btnLimparPesquisa";
            btnLimparPesquisa.RightToLeft = RightToLeft.Yes;
            btnLimparPesquisa.Size = new Size(100, 42);
            btnLimparPesquisa.TabIndex = 6;
            btnLimparPesquisa.Text = "Limpar";
            btnLimparPesquisa.UseVisualStyleBackColor = false;
            btnLimparPesquisa.Click += btnLimparPesquisa_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.HotTrack;
            btnEditar.ForeColor = SystemColors.ButtonHighlight;
            btnEditar.Location = new Point(581, 438);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 35);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Firebrick;
            btnExcluir.ForeColor = SystemColors.ButtonHighlight;
            btnExcluir.Location = new Point(662, 438);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 35);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // FormConsultaAutores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 503);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnLimparPesquisa);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(lblPesquisar);
            Controls.Add(btnVoltar);
            Controls.Add(dgvAutores);
            Controls.Add(label1);
            MinimumSize = new Size(900, 550);
            Name = "FormConsultaAutores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta de Autores";
            Load += FormConsultaAutores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAutores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvAutores;
        private Button btnVoltar;
        private Label lblPesquisar;
        private TextBox txtPesquisar;
        private Button btnPesquisar;
        private Button btnLimparPesquisa;
        private Button btnEditar;
        private Button btnExcluir;
    }
}