namespace MediaEscolar.Apresentacao.Secretaria
{
    partial class Secretaria
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
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.BackColor = System.Drawing.Color.DarkViolet;
            this.btnCadastrarAluno.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnCadastrarAluno.FlatAppearance.BorderSize = 0;
            this.btnCadastrarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarAluno.Font = new System.Drawing.Font("Mohave", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnCadastrarAluno.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrarAluno.Location = new System.Drawing.Point(12, 12);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(123, 44);
            this.btnCadastrarAluno.TabIndex = 0;
            this.btnCadastrarAluno.Text = "Cadastrar Aluno";
            this.btnCadastrarAluno.UseVisualStyleBackColor = false;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("ADAM.CG PRO", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(141, -3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(30, 34);
            this.btnSair.TabIndex = 32;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Secretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(174, 68);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastrarAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Secretaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secretaria";
            this.Load += new System.EventHandler(this.Secretaria_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Secretaria_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Secretaria_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarAluno;
        private System.Windows.Forms.Button btnSair;
    }
}