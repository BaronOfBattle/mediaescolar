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
            this.btnX2 = new System.Windows.Forms.Button();
            this.btnX3 = new System.Windows.Forms.Button();
            this.btnX4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numMedia1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedia2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedia3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedia4)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxAlunos
            // 
            this.cbxAlunos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAlunos.FormattingEnabled = true;
            this.cbxAlunos.Location = new System.Drawing.Point(207, 42);
            this.cbxAlunos.Name = "cbxAlunos";
            this.cbxAlunos.Size = new System.Drawing.Size(214, 21);
            this.cbxAlunos.TabIndex = 0;
            this.cbxAlunos.SelectedIndexChanged += new System.EventHandler(this.cbxAlunos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Olá, Professor. Aqui você pode alterar a nota dos seus alunos.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aluno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "1º Bimestre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "2º Bimestre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(237, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "3º Bimestre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(339, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "4º Bimestre";
            // 
            // lblMedia1
            // 
            this.lblMedia1.AutoSize = true;
            this.lblMedia1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia1.Location = new System.Drawing.Point(52, 109);
            this.lblMedia1.Name = "lblMedia1";
            this.lblMedia1.Size = new System.Drawing.Size(15, 16);
            this.lblMedia1.TabIndex = 7;
            this.lblMedia1.Text = "X";
            // 
            // lblMedia2
            // 
            this.lblMedia2.AutoSize = true;
            this.lblMedia2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia2.Location = new System.Drawing.Point(169, 109);
            this.lblMedia2.Name = "lblMedia2";
            this.lblMedia2.Size = new System.Drawing.Size(15, 16);
            this.lblMedia2.TabIndex = 8;
            this.lblMedia2.Text = "X";
            // 
            // lblMedia3
            // 
            this.lblMedia3.AutoSize = true;
            this.lblMedia3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia3.Location = new System.Drawing.Point(282, 109);
            this.lblMedia3.Name = "lblMedia3";
            this.lblMedia3.Size = new System.Drawing.Size(15, 16);
            this.lblMedia3.TabIndex = 9;
            this.lblMedia3.Text = "X";
            // 
            // lblMedia4
            // 
            this.lblMedia4.AutoSize = true;
            this.lblMedia4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia4.Location = new System.Drawing.Point(382, 109);
            this.lblMedia4.Name = "lblMedia4";
            this.lblMedia4.Size = new System.Drawing.Size(15, 16);
            this.lblMedia4.TabIndex = 10;
            this.lblMedia4.Text = "X";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(129, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "Aplicar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numMedia1
            // 
            this.numMedia1.DecimalPlaces = 1;
            this.numMedia1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numMedia1.Location = new System.Drawing.Point(41, 129);
            this.numMedia1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMedia1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numMedia1.Name = "numMedia1";
            this.numMedia1.ReadOnly = true;
            this.numMedia1.Size = new System.Drawing.Size(40, 20);
            this.numMedia1.TabIndex = 20;
            this.numMedia1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numMedia2
            // 
            this.numMedia2.DecimalPlaces = 1;
            this.numMedia2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numMedia2.Location = new System.Drawing.Point(159, 128);
            this.numMedia2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMedia2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numMedia2.Name = "numMedia2";
            this.numMedia2.ReadOnly = true;
            this.numMedia2.Size = new System.Drawing.Size(40, 20);
            this.numMedia2.TabIndex = 21;
            // 
            // numMedia3
            // 
            this.numMedia3.DecimalPlaces = 1;
            this.numMedia3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numMedia3.Location = new System.Drawing.Point(270, 129);
            this.numMedia3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMedia3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numMedia3.Name = "numMedia3";
            this.numMedia3.ReadOnly = true;
            this.numMedia3.Size = new System.Drawing.Size(40, 20);
            this.numMedia3.TabIndex = 22;
            this.numMedia3.ValueChanged += new System.EventHandler(this.numMedia3_ValueChanged);
            // 
            // numMedia4
            // 
            this.numMedia4.DecimalPlaces = 1;
            this.numMedia4.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numMedia4.Location = new System.Drawing.Point(371, 128);
            this.numMedia4.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMedia4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numMedia4.Name = "numMedia4";
            this.numMedia4.ReadOnly = true;
            this.numMedia4.Size = new System.Drawing.Size(40, 20);
            this.numMedia4.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Turma:";
            // 
            // cbxTurmas
            // 
            this.cbxTurmas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTurmas.FormattingEnabled = true;
            this.cbxTurmas.Location = new System.Drawing.Point(76, 42);
            this.cbxTurmas.Name = "cbxTurmas";
            this.cbxTurmas.Size = new System.Drawing.Size(50, 21);
            this.cbxTurmas.TabIndex = 25;
            this.cbxTurmas.SelectedIndexChanged += new System.EventHandler(this.cbxTurmas_SelectedIndexChanged);
            // 
            // btnX1
            // 
            this.btnX1.Location = new System.Drawing.Point(46, 154);
            this.btnX1.Name = "btnX1";
            this.btnX1.Size = new System.Drawing.Size(22, 22);
            this.btnX1.TabIndex = 26;
            this.btnX1.Text = "X";
            this.btnX1.UseVisualStyleBackColor = true;
            this.btnX1.Click += new System.EventHandler(this.btnX1_Click);
            // 
            // btnX2
            // 
            this.btnX2.Location = new System.Drawing.Point(166, 154);
            this.btnX2.Name = "btnX2";
            this.btnX2.Size = new System.Drawing.Size(22, 22);
            this.btnX2.TabIndex = 27;
            this.btnX2.Text = "X";
            this.btnX2.UseVisualStyleBackColor = true;
            this.btnX2.Click += new System.EventHandler(this.btnX2_Click);
            // 
            // btnX3
            // 
            this.btnX3.Location = new System.Drawing.Point(277, 154);
            this.btnX3.Name = "btnX3";
            this.btnX3.Size = new System.Drawing.Size(22, 22);
            this.btnX3.TabIndex = 28;
            this.btnX3.Text = "X";
            this.btnX3.UseVisualStyleBackColor = true;
            this.btnX3.Click += new System.EventHandler(this.btnX3_Click);
            // 
            // btnX4
            // 
            this.btnX4.Location = new System.Drawing.Point(377, 154);
            this.btnX4.Name = "btnX4";
            this.btnX4.Size = new System.Drawing.Size(22, 22);
            this.btnX4.TabIndex = 29;
            this.btnX4.Text = "X";
            this.btnX4.UseVisualStyleBackColor = true;
            this.btnX4.Click += new System.EventHandler(this.btnX4_Click);
            // 
            // Professor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(433, 262);
            this.Controls.Add(this.btnX4);
            this.Controls.Add(this.btnX3);
            this.Controls.Add(this.btnX2);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Professor";
            this.Text = "Gerenciador de Notas";
            this.Load += new System.EventHandler(this.Professor_Load);
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
        private System.Windows.Forms.Button btnX2;
        private System.Windows.Forms.Button btnX3;
        private System.Windows.Forms.Button btnX4;
    }
}