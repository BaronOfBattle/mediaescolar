namespace MediaEscolar.Apresentacao
{
    partial class Cadastro
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
            this.lblCadastro = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radAluno = new System.Windows.Forms.RadioButton();
            this.radProfessor = new System.Windows.Forms.RadioButton();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.btnFinalizarCadastro = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastro.Font = new System.Drawing.Font("Mohave", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblCadastro.Location = new System.Drawing.Point(43, 3);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(159, 52);
            this.lblCadastro.TabIndex = 0;
            this.lblCadastro.Text = "CADASTRO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mohave Medium", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mohave Medium", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(11, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirmar Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mohave Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(11, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Matrícula";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mohave Medium", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(14, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Você é:";
            // 
            // radAluno
            // 
            this.radAluno.AutoSize = true;
            this.radAluno.Checked = true;
            this.radAluno.FlatAppearance.BorderSize = 0;
            this.radAluno.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radAluno.Font = new System.Drawing.Font("Mohave", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAluno.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radAluno.Location = new System.Drawing.Point(19, 219);
            this.radAluno.Name = "radAluno";
            this.radAluno.Size = new System.Drawing.Size(75, 33);
            this.radAluno.TabIndex = 4;
            this.radAluno.TabStop = true;
            this.radAluno.Text = "Aluno";
            this.radAluno.UseVisualStyleBackColor = true;
            this.radAluno.CheckedChanged += new System.EventHandler(this.radAluno_CheckedChanged);
            // 
            // radProfessor
            // 
            this.radProfessor.AutoSize = true;
            this.radProfessor.FlatAppearance.BorderSize = 0;
            this.radProfessor.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radProfessor.Font = new System.Drawing.Font("Mohave", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radProfessor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radProfessor.Location = new System.Drawing.Point(93, 218);
            this.radProfessor.Name = "radProfessor";
            this.radProfessor.Size = new System.Drawing.Size(105, 33);
            this.radProfessor.TabIndex = 5;
            this.radProfessor.TabStop = true;
            this.radProfessor.Text = "Professor";
            this.radProfessor.UseVisualStyleBackColor = true;
            this.radProfessor.CheckedChanged += new System.EventHandler(this.radProfessor_CheckedChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Mohave", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.Black;
            this.txtSenha.Location = new System.Drawing.Point(17, 126);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(198, 23);
            this.txtSenha.TabIndex = 2;
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtConfirmarSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Mohave", 12F, System.Drawing.FontStyle.Bold);
            this.txtConfirmarSenha.ForeColor = System.Drawing.Color.Black;
            this.txtConfirmarSenha.Location = new System.Drawing.Point(17, 172);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.PasswordChar = '*';
            this.txtConfirmarSenha.Size = new System.Drawing.Size(198, 23);
            this.txtConfirmarSenha.TabIndex = 3;
            // 
            // txtMatricula
            // 
            this.txtMatricula.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMatricula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatricula.Font = new System.Drawing.Font("Mohave Light", 12F);
            this.txtMatricula.ForeColor = System.Drawing.Color.Black;
            this.txtMatricula.Location = new System.Drawing.Point(17, 81);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(198, 23);
            this.txtMatricula.TabIndex = 1;
            // 
            // btnFinalizarCadastro
            // 
            this.btnFinalizarCadastro.BackColor = System.Drawing.Color.DarkViolet;
            this.btnFinalizarCadastro.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnFinalizarCadastro.FlatAppearance.BorderSize = 0;
            this.btnFinalizarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarCadastro.Font = new System.Drawing.Font("Mohave", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarCadastro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFinalizarCadastro.Location = new System.Drawing.Point(43, 251);
            this.btnFinalizarCadastro.Name = "btnFinalizarCadastro";
            this.btnFinalizarCadastro.Size = new System.Drawing.Size(145, 44);
            this.btnFinalizarCadastro.TabIndex = 6;
            this.btnFinalizarCadastro.Text = "CADASTRAR";
            this.btnFinalizarCadastro.UseVisualStyleBackColor = false;
            this.btnFinalizarCadastro.Click += new System.EventHandler(this.btnFinalizarCadastro_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("ADAM.CG PRO", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(211, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(30, 34);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(240, 302);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnFinalizarCadastro);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.radProfessor);
            this.Controls.Add(this.radAluno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cadastro_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Cadastro_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Button btnFinalizarCadastro;
        public System.Windows.Forms.RadioButton radAluno;
        public System.Windows.Forms.RadioButton radProfessor;
        private System.Windows.Forms.Button btnSair;
    }
}