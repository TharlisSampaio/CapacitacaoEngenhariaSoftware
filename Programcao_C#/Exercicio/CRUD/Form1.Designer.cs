namespace CRUD
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textNome = new TextBox();
            textCpf = new TextBox();
            button1 = new Button();
            dateNascimento = new DateTimePicker();
            radioFeminino = new RadioButton();
            radioMasculino = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 21);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 0;
            label1.Text = "CADASTRO DO PACIENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "CPF:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 153);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 3;
            label4.Text = "Data de Nascimento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 208);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 4;
            label5.Text = "Sexo:";
            label5.Click += label5_Click;
            // 
            // textNome
            // 
            textNome.Location = new Point(12, 67);
            textNome.Name = "textNome";
            textNome.Size = new Size(209, 23);
            textNome.TabIndex = 5;
            // 
            // textCpf
            // 
            textCpf.Location = new Point(12, 120);
            textCpf.Name = "textCpf";
            textCpf.Size = new Size(209, 23);
            textCpf.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSpringGreen;
            button1.Location = new Point(12, 244);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "SALVAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateNascimento
            // 
            dateNascimento.Location = new Point(12, 171);
            dateNascimento.Name = "dateNascimento";
            dateNascimento.Size = new Size(209, 23);
            dateNascimento.TabIndex = 11;
            dateNascimento.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // radioFeminino
            // 
            radioFeminino.AutoSize = true;
            radioFeminino.Checked = true;
            radioFeminino.Location = new Point(53, 208);
            radioFeminino.Name = "radioFeminino";
            radioFeminino.Size = new Size(75, 19);
            radioFeminino.TabIndex = 12;
            radioFeminino.TabStop = true;
            radioFeminino.Text = "Feminino";
            radioFeminino.UseVisualStyleBackColor = true;
            radioFeminino.CheckedChanged += radioFeminino_CheckedChanged;
            // 
            // radioMasculino
            // 
            radioMasculino.AutoSize = true;
            radioMasculino.Location = new Point(150, 206);
            radioMasculino.Name = "radioMasculino";
            radioMasculino.Size = new Size(80, 19);
            radioMasculino.TabIndex = 13;
            radioMasculino.Text = "Masculino";
            radioMasculino.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 377);
            Controls.Add(radioMasculino);
            Controls.Add(radioFeminino);
            Controls.Add(dateNascimento);
            Controls.Add(button1);
            Controls.Add(textCpf);
            Controls.Add(textNome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textNome;
        private TextBox textCpf;
        private Button button1;
        private DateTimePicker dateNascimento;
        private RadioButton radioFeminino;
        private RadioButton radioMasculino;
    }
}