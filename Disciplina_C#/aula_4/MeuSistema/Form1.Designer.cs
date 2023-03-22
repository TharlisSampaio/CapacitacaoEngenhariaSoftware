namespace MeuSistema
{
    partial class resultado
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
            entrada1 = new TextBox();
            entrada2 = new TextBox();
            number1 = new Label();
            number2 = new Label();
            somar = new Button();
            result = new Label();
            res = new TextBox();
            SuspendLayout();
            // 
            // entrada1
            // 
            entrada1.Location = new Point(145, 12);
            entrada1.Name = "entrada1";
            entrada1.Size = new Size(100, 23);
            entrada1.TabIndex = 0;
            // 
            // entrada2
            // 
            entrada2.Location = new Point(145, 41);
            entrada2.Name = "entrada2";
            entrada2.Size = new Size(100, 23);
            entrada2.TabIndex = 1;
            // 
            // number1
            // 
            number1.AutoSize = true;
            number1.Location = new Point(90, 19);
            number1.Name = "number1";
            number1.Size = new Size(53, 15);
            number1.TabIndex = 2;
            number1.Text = "Numer 1";
            number1.Click += label1_Click;
            // 
            // number2
            // 
            number2.AutoSize = true;
            number2.Location = new Point(90, 44);
            number2.Name = "number2";
            number2.Size = new Size(53, 15);
            number2.TabIndex = 3;
            number2.Text = "Numer 2";
            // 
            // somar
            // 
            somar.Location = new Point(68, 73);
            somar.Name = "somar";
            somar.Size = new Size(75, 23);
            somar.TabIndex = 4;
            somar.Text = "somar (+)";
            somar.UseVisualStyleBackColor = true;
            somar.Click += somar_Click;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(171, 81);
            result.Name = "result";
            result.Size = new Size(10, 15);
            result.TabIndex = 5;
            result.Text = " ";
            result.Click += label1_Click_1;
            // 
            // res
            // 
            res.Location = new Point(145, 70);
            res.Name = "res";
            res.Size = new Size(100, 23);
            res.TabIndex = 6;
            // 
            // resultado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 201);
            Controls.Add(res);
            Controls.Add(result);
            Controls.Add(somar);
            Controls.Add(number2);
            Controls.Add(number1);
            Controls.Add(entrada2);
            Controls.Add(entrada1);
            Name = "resultado";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox entrada1;
        private TextBox entrada2;
        private Label number1;
        private Label number2;
        private Button somar;
        private Label result;
        private TextBox res;
    }
}