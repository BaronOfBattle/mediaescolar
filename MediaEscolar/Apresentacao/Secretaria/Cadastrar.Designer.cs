namespace MediaEscolar.Apresentacao.Secretaria
{
    partial class Cadastrar
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.radProfessor = new System.Windows.Forms.RadioButton();
            this.radAluno = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTurmas = new System.Windows.Forms.ComboBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkViolet;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Mohave", 20.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(21, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mohave Medium", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(1, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mohave Medium", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(4, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo de Usuário";
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNome.Font = new System.Drawing.Font("Mohave Light", 12F);
            this.txbNome.ForeColor = System.Drawing.Color.Black;
            this.txbNome.Location = new System.Drawing.Point(7, 30);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(162, 23);
            this.txbNome.TabIndex = 5;
            // 
            // radProfessor
            // 
            this.radProfessor.AutoSize = true;
            this.radProfessor.FlatAppearance.BorderSize = 0;
            this.radProfessor.Font = new System.Drawing.Font("Mohave", 15.75F, System.Drawing.FontStyle.Bold);
            this.radProfessor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radProfessor.Location = new System.Drawing.Point(83, 124);
            this.radProfessor.Name = "radProfessor";
            this.radProfessor.Size = new System.Drawing.Size(105, 33);
            this.radProfessor.TabIndex = 7;
            this.radProfessor.TabStop = true;
            this.radProfessor.Text = "Professor";
            this.radProfessor.UseVisualStyleBackColor = true;
            // 
            // radAluno
            // 
            this.radAluno.AutoSize = true;
            this.radAluno.Checked = true;
            this.radAluno.FlatAppearance.BorderSize = 0;
            this.radAluno.Font = new System.Drawing.Font("Mohave", 15.75F, System.Drawing.FontStyle.Bold);
            this.radAluno.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radAluno.Location = new System.Drawing.Point(9, 124);
            this.radAluno.Name = "radAluno";
            this.radAluno.Size = new System.Drawing.Size(75, 33);
            this.radAluno.TabIndex = 6;
            this.radAluno.TabStop = true;
            this.radAluno.Text = "Aluno";
            this.radAluno.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mohave Medium", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(1, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Turma";
            // 
            // cbxTurmas
            // 
            this.cbxTurmas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxTurmas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTurmas.ForeColor = System.Drawing.Color.Black;
            this.cbxTurmas.FormattingEnabled = true;
            this.cbxTurmas.Location = new System.Drawing.Point(6, 78);
            this.cbxTurmas.Name = "cbxTurmas";
            this.cbxTurmas.Size = new System.Drawing.Size(50, 21);
            this.cbxTurmas.TabIndex = 9;
            this.cbxTurmas.SelectedIndexChanged += new System.EventHandler(this.cbxTurmas_SelectedIndexChanged);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("ADAM.CG PRO", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(158, -5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(30, 34);
            this.btnSair.TabIndex = 31;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(183, 203);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.cbxTurmas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radProfessor);
            this.Controls.Add(this.radAluno);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.Cadastrar_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cadastrar_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Cadastrar_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNome;
        public System.Windows.Forms.RadioButton radProfessor;
        public System.Windows.Forms.RadioButton radAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTurmas;
        private System.Windows.Forms.Button btnSair;
    }
}