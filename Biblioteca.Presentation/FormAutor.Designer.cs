namespace Biblioteca.Presentation
{
    partial class FormAutor
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
            lblNome = new Label();
            txtNome = new TextBox();
            lblNacionalidade = new Label();
            txtNacionalidade = new TextBox();
            btnSalvar = new Button();
            btnLimpar = new Button();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(12, 70);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(61, 23);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(141, 70);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(400, 27);
            txtNome.TabIndex = 1;
            // 
            // lblNacionalidade
            // 
            lblNacionalidade.AutoSize = true;
            lblNacionalidade.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNacionalidade.Location = new Point(12, 122);
            lblNacionalidade.Name = "lblNacionalidade";
            lblNacionalidade.Size = new Size(123, 23);
            lblNacionalidade.TabIndex = 2;
            lblNacionalidade.Text = "Nacionalidade:";
            // 
            // txtNacionalidade
            // 
            txtNacionalidade.Location = new Point(141, 122);
            txtNacionalidade.Name = "txtNacionalidade";
            txtNacionalidade.Size = new Size(400, 27);
            txtNacionalidade.TabIndex = 3;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.HotTrack;
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = SystemColors.ButtonHighlight;
            btnSalvar.Location = new Point(211, 306);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 35);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.UseWaitCursor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = SystemColors.HotTrack;
            btnLimpar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpar.Location = new Point(326, 306);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(100, 35);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.UseWaitCursor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = SystemColors.HotTrack;
            btnVoltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = SystemColors.ButtonHighlight;
            btnVoltar.Location = new Point(441, 306);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(100, 35);
            btnVoltar.TabIndex = 6;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.UseWaitCursor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FormAutor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 353);
            Controls.Add(btnVoltar);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(txtNacionalidade);
            Controls.Add(lblNacionalidade);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(600, 400);
            Name = "FormAutor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Autores";
            Load += FormAutor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Label lblNacionalidade;
        private TextBox txtNacionalidade;
        private Button btnSalvar;
        private Button btnLimpar;
        private Button btnVoltar;
    }
}