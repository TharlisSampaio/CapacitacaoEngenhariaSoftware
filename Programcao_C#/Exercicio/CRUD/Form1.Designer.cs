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
            dataRegistroPaciente = new DataGridView();
            btnAtualizarTabela = new Button();
            label6 = new Label();
            btnCancelar = new Button();
            textId = new TextBox();
            label7 = new Label();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataRegistroPaciente).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 19);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 0;
            label1.Text = "CADASTRO DO PACIENTE";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 105);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 158);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "CPF:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 209);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 3;
            label4.Text = "Data de Nascimento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 264);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 4;
            label5.Text = "Sexo:";
            label5.Click += label5_Click;
            // 
            // textNome
            // 
            textNome.Location = new Point(12, 123);
            textNome.Name = "textNome";
            textNome.Size = new Size(237, 23);
            textNome.TabIndex = 5;
            // 
            // textCpf
            // 
            textCpf.Location = new Point(12, 176);
            textCpf.Name = "textCpf";
            textCpf.Size = new Size(237, 23);
            textCpf.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSpringGreen;
            button1.Location = new Point(12, 300);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "SALVAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateNascimento
            // 
            dateNascimento.Location = new Point(12, 227);
            dateNascimento.Name = "dateNascimento";
            dateNascimento.Size = new Size(237, 23);
            dateNascimento.TabIndex = 11;
            dateNascimento.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // radioFeminino
            // 
            radioFeminino.AutoSize = true;
            radioFeminino.Checked = true;
            radioFeminino.Location = new Point(53, 264);
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
            radioMasculino.Location = new Point(150, 262);
            radioMasculino.Name = "radioMasculino";
            radioMasculino.Size = new Size(80, 19);
            radioMasculino.TabIndex = 13;
            radioMasculino.Text = "Masculino";
            radioMasculino.UseVisualStyleBackColor = true;
            // 
            // dataRegistroPaciente
            // 
            dataRegistroPaciente.AllowUserToAddRows = false;
            dataRegistroPaciente.AllowUserToDeleteRows = false;
            dataRegistroPaciente.BorderStyle = BorderStyle.None;
            dataRegistroPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataRegistroPaciente.GridColor = SystemColors.ControlDarkDark;
            dataRegistroPaciente.ImeMode = ImeMode.NoControl;
            dataRegistroPaciente.Location = new Point(316, 67);
            dataRegistroPaciente.Name = "dataRegistroPaciente";
            dataRegistroPaciente.RowTemplate.Height = 25;
            dataRegistroPaciente.Size = new Size(543, 200);
            dataRegistroPaciente.TabIndex = 14;
            dataRegistroPaciente.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAtualizarTabela
            // 
            btnAtualizarTabela.Location = new Point(761, 273);
            btnAtualizarTabela.Name = "btnAtualizarTabela";
            btnAtualizarTabela.Size = new Size(98, 23);
            btnAtualizarTabela.TabIndex = 15;
            btnAtualizarTabela.Text = "Atualizar Tabela";
            btnAtualizarTabela.UseVisualStyleBackColor = true;
            btnAtualizarTabela.Click += btnAtualizarTabela_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(509, 19);
            label6.Name = "label6";
            label6.Size = new Size(142, 15);
            label6.TabIndex = 16;
            label6.Text = "PACIENTES REGISTRADOS";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(174, 300);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // textId
            // 
            textId.Enabled = false;
            textId.Location = new Point(12, 79);
            textId.Name = "textId";
            textId.Size = new Size(43, 23);
            textId.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 61);
            label7.Name = "label7";
            label7.Size = new Size(21, 15);
            label7.TabIndex = 18;
            label7.Text = "ID:";
            label7.Click += label7_Click;
            // 
            // button2
            // 
            button2.Location = new Point(316, 273);
            button2.Name = "button2";
            button2.Size = new Size(135, 23);
            button2.TabIndex = 20;
            button2.Text = "ATUALIZAR REGISTRO";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightCoral;
            button3.Location = new Point(93, 300);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 21;
            button3.Text = "DELETAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 354);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textId);
            Controls.Add(label7);
            Controls.Add(btnCancelar);
            Controls.Add(label6);
            Controls.Add(btnAtualizarTabela);
            Controls.Add(dataRegistroPaciente);
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
            MaximizeBox = false;
            Name = "Form1";
            Text = "CADASTRAMENTO DE PACIENTES";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataRegistroPaciente).EndInit();
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
        private DataGridView dataRegistroPaciente;
        private Button btnAtualizarTabela;
        private Label label6;
        private Button btnCancelar;
        private TextBox textId;
        private Label label7;
        private Button button2;
        private Button button3;
    }
}