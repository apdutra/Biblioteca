namespace Biblioteca.Presentation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            btnAutores = new Button();
            btnLivros = new Button();
            btnConsulta = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.HotTrack;
            lblTitulo.Location = new Point(287, 45);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(246, 54);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "BIBLIOTECA";
            lblTitulo.Click += label1_Click;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = SystemColors.GrayText;
            lblSubtitulo.Location = new Point(241, 99);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(338, 28);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Sistema de Gerenciamento de Acervo";
            // 
            // btnAutores
            // 
            btnAutores.BackColor = SystemColors.HotTrack;
            btnAutores.FlatStyle = FlatStyle.Flat;
            btnAutores.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAutores.ForeColor = SystemColors.ButtonHighlight;
            btnAutores.Location = new Point(298, 153);
            btnAutores.Name = "btnAutores";
            btnAutores.Size = new Size(220, 50);
            btnAutores.TabIndex = 2;
            btnAutores.Text = "Cadastrar Autores";
            btnAutores.UseVisualStyleBackColor = false;
            btnAutores.Click += btnAutores_Click;
            // 
            // btnLivros
            // 
            btnLivros.BackColor = SystemColors.HotTrack;
            btnLivros.FlatStyle = FlatStyle.Flat;
            btnLivros.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLivros.ForeColor = SystemColors.ButtonHighlight;
            btnLivros.Location = new Point(298, 234);
            btnLivros.Name = "btnLivros";
            btnLivros.Size = new Size(220, 50);
            btnLivros.TabIndex = 3;
            btnLivros.Text = "Cadastrar Livros";
            btnLivros.UseVisualStyleBackColor = false;
            // 
            // btnConsulta
            // 
            btnConsulta.BackColor = SystemColors.HotTrack;
            btnConsulta.FlatStyle = FlatStyle.Flat;
            btnConsulta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsulta.ForeColor = SystemColors.ButtonHighlight;
            btnConsulta.Location = new Point(298, 317);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(220, 50);
            btnConsulta.TabIndex = 4;
            btnConsulta.Text = "Consultar Acervo";
            btnConsulta.UseVisualStyleBackColor = false;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(btnConsulta);
            Controls.Add(btnLivros);
            Controls.Add(btnAutores);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            MinimumSize = new Size(900, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblioteca - Sistema de Gerenciamento";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Button btnAutores;
        private Button btnLivros;
        private Button btnConsulta;
    }
}
