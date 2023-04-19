using System;

namespace MediaEscolar.Apresentacao
{
    partial class Professor
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
            this.cbxAlunos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMedia1 = new System.Windows.Forms.Label();
            this.lblMedia2 = new System.Windows.Forms.Label();
            this.lblMedia3 = new System.Windows.Forms.Label();
            this.lblMedia4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numMedia1 = new System.Windows.Forms.NumericUpDown();
            this.numMedia2 = new System.Windows.Forms.NumericUpDown();
            this.numMedia3 = new System.Windows.Forms.NumericUpDown();
            this.numMedia4 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxTurmas = new System.Windows.Forms.ComboBox();
            this.btnX1 = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnX2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnX4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMedia1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedia2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedia3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedia4)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxAlunos
            // 
            this.cbxAlunos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxAlunos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAlunos.ForeColor = System.Drawing.Color.Black;
            this.cbxAlunos.FormattingEnabled = true;
            this.cbxAlunos.Location = new System.Drawing.Point(184, 59);
            this.cbxAlunos.Name = "cbxAlunos";
            this.cbxAlunos.Size = new System.Drawing.Size(237, 21);
            this.cbxAlunos.TabIndex = 0;
            this.cbxAlunos.SelectedIndexChanged += new System.EventHandler(this.cbxAlunos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mohave", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(33, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "GERENCIADOR DE MÉDIAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mohave", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(123, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aluno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mohave", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "1º Bimestre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mohave", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(115, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "2º Bimestre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mohave", 15.75F);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(222, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "3º Bimestre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mohave", 15.75F);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(327, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "4º Bimestre";
            // 
            // lblMedia1
            // 
            this.lblMedia1.AutoSize = true;
            this.lblMedia1.Font = new System.Drawing.Font("Mohave Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMedia1.Location = new System.Drawing.Point(45, 120);
            this.lblMedia1.Name = "lblMedia1";
            this.lblMedia1.Size = new System.Drawing.Size(23, 29);
            this.lblMedia1.TabIndex = 7;
            this.lblMedia1.Text = "X";
            // 
            // lblMedia2
            // 
            this.lblMedia2.AutoSize = true;
            this.lblMedia2.Font = new System.Drawing.Font("Mohave Light", 15.75F);
            this.lblMedia2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMedia2.Location = new System.Drawing.Point(157, 119);
            this.lblMedia2.Name = "lblMedia2";
            this.lblMedia2.Size = new System.Drawing.Size(23, 29);
            this.lblMedia2.TabIndex = 8;
            this.lblMedia2.Text = "X";
            // 
            // lblMedia3
            // 
            this.lblMedia3.AutoSize = true;
            this.lblMedia3.Font = new System.Drawing.Font("Mohave Light", 15.75F);
            this.lblMedia3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMedia3.Location = new System.Drawing.Point(266, 119);
            this.lblMedia3.Name = "lblMedia3";
            this.lblMedia3.Size = new System.Drawing.Size(23, 29);
            this.lblMedia3.TabIndex = 9;
            this.lblMedia3.Text = "X";
            // 
            // lblMedia4
            // 
            this.lblMedia4.AutoSize = true;
            this.lblMedia4.Font = new System.Drawing.Font("Mohave Light", 15.75F);
            this.lblMedia4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMedia4.Location = new System.Drawing.Point(368, 119);
            this.lblMedia4.Name = "lblMedia4";
            this.lblMedia4.Size = new System.Drawing.Size(23, 29);
            this.lblMedia4.TabIndex = 10;
            this.lblMedia4.Text = "X";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkViolet;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Mohave", 20.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(156, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "APLICAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numMedia1
            // 
            this.numMedia1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numMedia1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numMedia1.DecimalPlaces = 1;
            this.numMedia1.Font = new System.Drawing.Font("Mohave", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMedia1.ForeColor = System.Drawing.Color.Black;
            this.numMedia1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numMedia1.Location = new System.Drawing.Point(37, 154);
            this.numMedia1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMedia1.Name = "numMedia1";
            this.numMedia1.ReadOnly = true;
            this.numMedia1.Size = new System.Drawing.Size(40, 24);
            this.numMedia1.TabIndex = 20;
            this.numMedia1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numMedia2
            // 
            this.numMedia2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numMedia2.DecimalPlaces = 1;
            this.numMedia2.Font = new System.Drawing.Font("Mohave", 11.25F);
            this.numMedia2.ForeColor = System.Drawing.Color.Black;
            this.numMedia2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numMedia2.Location = new System.Drawing.Point(149, 155);
            this.numMedia2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMedia2.Name = "numMedia2";
            this.numMedia2.ReadOnly = true;
            this.numMedia2.Size = new System.Drawing.Size(40, 24);
            this.numMedia2.TabIndex = 21;
            // 
            // numMedia3
            // 
            this.numMedia3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numMedia3.DecimalPlaces = 1;
            this.numMedia3.Font = new System.Drawing.Font("Mohave", 11.25F);
            this.numMedia3.ForeColor = System.Drawing.Color.Black;
            this.numMedia3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numMedia3.Location = new System.Drawing.Point(260, 155);
            this.numMedia3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMedia3.Name = "numMedia3";
            this.numMedia3.ReadOnly = true;
            this.numMedia3.Size = new System.Drawing.Size(40, 24);
            this.numMedia3.TabIndex = 22;
            this.numMedia3.ValueChanged += new System.EventHandler(this.numMedia3_ValueChanged);
            // 
            // numMedia4
            // 
            this.numMedia4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numMedia4.DecimalPlaces = 1;
            this.numMedia4.Font = new System.Drawing.Font("Mohave", 11.25F);
            this.numMedia4.ForeColor = System.Drawing.Color.Black;
            this.numMedia4.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numMedia4.Location = new System.Drawing.Point(361, 155);
            this.numMedia4.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMedia4.Name = "numMedia4";
            this.numMedia4.ReadOnly = true;
            this.numMedia4.Size = new System.Drawing.Size(40, 24);
            this.numMedia4.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mohave", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(5, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 29);
            this.label7.TabIndex = 24;
            this.label7.Text = "Turma:";
            // 
            // cbxTurmas
            // 
            this.cbxTurmas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxTurmas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTurmas.ForeColor = System.Drawing.Color.Black;
            this.cbxTurmas.FormattingEnabled = true;
            this.cbxTurmas.Location = new System.Drawing.Point(69, 59);
            this.cbxTurmas.Name = "cbxTurmas";
            this.cbxTurmas.Size = new System.Drawing.Size(50, 21);
            this.cbxTurmas.TabIndex = 25;
            this.cbxTurmas.SelectedIndexChanged += new System.EventHandler(this.cbxTurmas_SelectedIndexChanged);
            // 
            // btnX1
            // 
            this.btnX1.BackColor = System.Drawing.Color.Red;
            this.btnX1.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnX1.FlatAppearance.BorderSize = 0;
            this.btnX1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX1.Font = new System.Drawing.Font("ADAM.CG PRO", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnX1.Location = new System.Drawing.Point(43, 182);
            this.btnX1.Name = "btnX1";
            this.btnX1.Size = new System.Drawing.Size(22, 22);
            this.btnX1.TabIndex = 26;
            this.btnX1.Text = "x";
            this.btnX1.UseVisualStyleBackColor = false;
            this.btnX1.Click += new System.EventHandler(this.btnX1_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("ADAM.CG PRO", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(406, -5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(30, 34);
            this.btnSair.TabIndex = 30;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label9.Location = new System.Drawing.Point(-4, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(468, 25);
            this.label9.TabIndex = 32;
            this.label9.Text = "______________________________________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label10.Location = new System.Drawing.Point(-15, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(468, 25);
            this.label10.TabIndex = 33;
            this.label10.Text = "______________________________________";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Komika Text", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(109, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(231, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "utilize o X para redefinir a nota de um aluno";
            // 
            // btnX2
            // 
            this.btnX2.BackColor = System.Drawing.Color.Red;
            this.btnX2.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnX2.FlatAppearance.BorderSize = 0;
            this.btnX2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX2.Font = new System.Drawing.Font("ADAM.CG PRO", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnX2.Location = new System.Drawing.Point(155, 182);
            this.btnX2.Name = "btnX2";
            this.btnX2.Size = new System.Drawing.Size(22, 22);
            this.btnX2.TabIndex = 35;
            this.btnX2.Text = "X";
            this.btnX2.UseVisualStyleBackColor = false;
            this.btnX2.Click += new System.EventHandler(this.btnX2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("ADAM.CG PRO", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(267, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 22);
            this.button3.TabIndex = 36;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnX3_Click);
            // 
            // btnX4
            // 
            this.btnX4.BackColor = System.Drawing.Color.Red;
            this.btnX4.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnX4.FlatAppearance.BorderSize = 0;
            this.btnX4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX4.Font = new System.Drawing.Font("ADAM.CG PRO", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnX4.Location = new System.Drawing.Point(369, 182);
            this.btnX4.Name = "btnX4";
            this.btnX4.Size = new System.Drawing.Size(22, 22);
            this.btnX4.TabIndex = 37;
            this.btnX4.Text = "X";
            this.btnX4.UseVisualStyleBackColor = false;
            this.btnX4.Click += new System.EventHandler(this.btnX4_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Location = new System.Drawing.Point(-15, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(468, 25);
            this.label8.TabIndex = 38;
            this.label8.Text = "______________________________________";
            // 
            // Professor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(433, 286);
            this.Controls.Add(this.btnX4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnX2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnX1);
            this.Controls.Add(this.cbxTurmas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numMedia4);
            this.Controls.Add(this.numMedia3);
            this.Controls.Add(this.numMedia2);
            this.Controls.Add(this.numMedia1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMedia4);
            this.Controls.Add(this.lblMedia3);
            this.Controls.Add(this.lblMedia2);
            this.Controls.Add(this.lblMedia1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxAlunos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Professor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Notas";
            this.Load += new System.EventHandler(this.Professor_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Professor_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Professor_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.numMedia1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedia2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedia3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedia4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cbxAlunos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMedia1;
        private System.Windows.Forms.Label lblMedia2;
        private System.Windows.Forms.Label lblMedia3;
        private System.Windows.Forms.Label lblMedia4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numMedia1;
        private System.Windows.Forms.NumericUpDown numMedia2;
        private System.Windows.Forms.NumericUpDown numMedia3;
        private System.Windows.Forms.NumericUpDown numMedia4;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cbxTurmas;
        private System.Windows.Forms.Button btnX1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnX2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnX4;
        private System.Windows.Forms.Label label8;
    }
}